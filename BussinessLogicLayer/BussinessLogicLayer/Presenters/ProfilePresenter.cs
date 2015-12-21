using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BussinessLogicLayer.GridRowTemplates;
using BussinessLogicLayer.Interfaces;
using DataAccessLayer.Repositories.Interfaces;
using DataAccessLayer.Services.Interfaces;
using DataAccessLayer.Utilities;
using Model.Entities;
using Model.Enums;
using Utilities;

namespace BussinessLogicLayer.Presenters
{
    public class ProfilePresenter : IPresenter
    {
        private readonly IProfileView view;
        private readonly IProfileRepository profileRepository;
        private readonly IHistoryEventsRepository historyEventsRepository;
        private readonly ISkillsService skillsService;
        private readonly IImprovementsRepository improvementsRepository;
        private readonly IImprovementsService improvementsService;

        private List<String> newSkillsToAdd;
        private List<int> skillsIdsToRemove;
        private Profile currentUser;

        public ProfilePresenter(IProfileView view, IProfileRepository profileRepository, IHistoryEventsRepository historyEventsRepository, ISkillsService skillsService, IImprovementsRepository improvementsRepository, IImprovementsService improvementsService)
        {
            this.view = view;
            this.profileRepository = profileRepository;
            this.historyEventsRepository = historyEventsRepository;
            this.skillsService = skillsService;
            this.improvementsRepository = improvementsRepository;
            this.improvementsService = improvementsService;
        }

        public void Initialize()
        {
            try
            {
                AttachEvents();

                if (ApplicationSettings.Current.IsAnyUserLoggedIn && ApplicationSettings.Current.CurrentUserId.HasValue)
                {
                    int currentUserId = ApplicationSettings.Current.CurrentUserId.Value;
                    currentUser = ObtainProfile(currentUserId);
                    if (currentUser != null)
                    {
                        DisplayProfileInfo(currentUser);
                        SetDisplayMode(DisplayMode.View);
                    }
                }
            }
            catch (Exception e)
            {
                Logger.Exception(e);
            }
        }

        private void AttachEvents()
        {
            view.AddNewSkill += AddNewSkill;
            view.RemoveSkill += RemoveSkill;
            view.EditProfile += EditProfile;
            view.CancelChanges += CancelChanges;
            view.SaveChanges += SaveChanges;
            view.SkillSelected += ViewOnSkillSelected;
        }

        private void ViewOnSkillSelected()
        {
            int? selectedSkillId = view.SelectedSkill;
        }

        private String getSaveChangesWarning()
        {
            StringBuilder saveChangesWarning = new StringBuilder();
            saveChangesWarning.AppendFormat("Are you sure?");

            if (newSkillsToAdd != null && newSkillsToAdd.Count > 0)
            {
                saveChangesWarning.AppendLine();
                saveChangesWarning.AppendFormat("{0} skills will be added.", newSkillsToAdd.Count);
            }

            if (skillsIdsToRemove != null && skillsIdsToRemove.Count > 0)
            {
                saveChangesWarning.AppendLine();
                saveChangesWarning.AppendFormat("{0} skills will be removed.", skillsIdsToRemove.Count);
            }

            return saveChangesWarning.ToString();
        }

        private void RemoveSelectedSkills()
        {
            if (skillsIdsToRemove != null)
            {
                foreach (int skillToRemoveId in skillsIdsToRemove)
                {
                    skillsService.RemoveSkill(skillToRemoveId);
                }

                skillsIdsToRemove.Clear();
            }
        }

        private void AddNewSkills()
        {
            if (newSkillsToAdd != null)
            {
                foreach (String skillToAdd in newSkillsToAdd)
                {
                    Skill skillToSave = skillsService.CreateNewSkill(currentUser.Id, skillToAdd);
                    skillsService.SaveSkill(skillToSave);
                }

                newSkillsToAdd.Clear();
            }
        }

        private void DisplayProfileInfo(Profile profile)
        {
            var userImprovements = improvementsRepository.Find(i => i.Owner.Id == profile.Id).ToList();
            var userImprovementsGridItems = GetImprovementsGridItems(userImprovements).OrderByDescending(ui => ui.When).ToList(); 

            view.PlayerName = profile.Name;
            view.History = profile.History;
            view.Age = profile.AgeInYears().HasValue ? profile.AgeInYears().Value.ToString() : "[birth date not set]";
            view.Experience = $"{profile.Experience} / {profile.GetExperienceWhenNewLevel()}"; 
            view.Level = profile.Level;
            view.LevelProgress = profile.LevelProgressInPercent();
            view.Skills = MakeBindingSourceFromList(GetSkillsGridItems(profile.Skills));
            view.ProfileRelatedEvents = MakeBindingSourceFromList(userImprovementsGridItems);
        }

        private List<SkillGridItem> GetSkillsGridItems(ICollection<Skill> skills)
        {
            List<SkillGridItem> skillGridViewItems = new List<SkillGridItem>();

            foreach (Skill skill in skills)
            {
                String experienceLiteral = $"{skill.Experience} / {skill.GetExperienceWhenNewLevel()} ({skill.GetNewLevelProgress()})";
                skillGridViewItems.Add(new SkillGridItem(skill.Id, skill.Name, skill.Level.ToString(), experienceLiteral));    
            }

            return skillGridViewItems;
        }
        
        private List<ImprovementGridItem> GetImprovementsGridItems(List<Improvement> improvements)
        {
            List<ImprovementGridItem> profileRelatedEvents = new List<ImprovementGridItem>();

            foreach (var improvement in improvements)
            {
                String occuredDate = improvement.Occured.ToString("dddd, d MMMM HH:mm");
                String eventType = improvement.Type.ToString();
                String improvementDescription = improvementsService.GetImprovementDescription(improvement);

                profileRelatedEvents.Add(new ImprovementGridItem(improvement.Occured, occuredDate, improvementDescription));
            }

            return profileRelatedEvents;
        }
        
        private Profile ObtainProfile(int profileId)
        {
            return profileRepository.HasProfile() ? profileRepository.First(p => p.Id == profileId) : null;
        }

        public void SetDisplayMode(DisplayMode displayMode)
        {
            if (displayMode == DisplayMode.Edit)
            {
                view.SaveChangesButtonVisible = true;
                view.CancelChangesButtonVisible = true;
                view.AddNewSkillPanelVisible = true;
                view.EditProfileButtonVisible = false;
            }
            else if (displayMode == DisplayMode.View)
            {
                view.SaveChangesButtonVisible = false;
                view.CancelChangesButtonVisible = false;
                view.AddNewSkillPanelVisible = false;
                view.EditProfileButtonVisible = true;
            }
        }
        
        public static BindingSource MakeBindingSourceFromList(IList list)
        {
            BindingSource source = new BindingSource();
            source.DataSource = list;
            return source;
        }

        #region Events

        private void EditProfile(object sender, EventArgs e)
        {
            SetDisplayMode(DisplayMode.Edit);
        }

        private void AddNewSkill(object sender, EventArgs e)
        {
            if (newSkillsToAdd == null)
                newSkillsToAdd = new List<string>();

            newSkillsToAdd.Add(view.NewSkillName);
            view.NewSkillName = "(New skill name)";
        }

        private void RemoveSkill(object sender, int skillToRemoveId)
        {
            if (skillsIdsToRemove == null)
                skillsIdsToRemove = new List<int>();

            skillsIdsToRemove.Add(skillToRemoveId);
        }

        private void CancelChanges(object sender, EventArgs e)
        {
            SetDisplayMode(DisplayMode.View);
        }

        private void SaveChanges(object sender, EventArgs e)
        {
            String saveChangesWarning = getSaveChangesWarning();
            DialogResult saveConfirmation = MessageBox.Show(saveChangesWarning, "Confirm save changes", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (saveConfirmation == DialogResult.Yes)
            {
                AddNewSkills();
                RemoveSelectedSkills();
                SetDisplayMode(DisplayMode.View);
            }
        }

        public void OnViewDisplayed()
        {
            int currentUserId = ApplicationSettings.Current.CurrentUserId.Value;
            currentUser = ObtainProfile(currentUserId);
            if (currentUser != null)
            {
                DisplayProfileInfo(currentUser);
                SetDisplayMode(DisplayMode.View);
            }

            view.ProfileDisplayed = true;
        }

        #endregion
    }
}
