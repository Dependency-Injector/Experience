using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BussinessLogicLayer.Interfaces;
using DataAccessLayer.Repositories;
using DataAccessLayer.Repositories.Interfaces;
using DataAccessLayer.Services.Interfaces;
using DataAccessLayer.Utilities;
using Model.Classes;
using Model.Entities;
using Model.Enums;
using Utilities;

namespace BussinessLogicLayer.Presenters
{
    public class ProfilePresenter : IEditable
    {
        private readonly IProfileView view;
        private readonly IProfileRepository profileRepository;
        private readonly IHistoryEventsRepository historyEventsRepository;
        private readonly ISkillsService skillsService;

        private List<String> newSkillsToAdd = null;
        private List<int> skillsIdsToRemove = null;
        private Profile currentUser;

        public ProfilePresenter(IProfileView view, IProfileRepository profileRepository, IHistoryEventsRepository historyEventsRepository, ISkillsService skillsService)
        {
            this.view = view;
            this.profileRepository = profileRepository;
            this.historyEventsRepository = historyEventsRepository;
            this.skillsService = skillsService;

            Initialize();
        }

        private void Initialize()
        {
            try
            {
                if (ApplicationSettings.Current.IsAnyUserLoggedIn && ApplicationSettings.Current.CurrentUserId.HasValue)
                {
                    int currentUserId = ApplicationSettings.Current.CurrentUserId.Value;
                    currentUser = ObtainProfile(currentUserId);
                    if (currentUser != null)
                    {
                        AttachEvents();
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
        }

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

            DialogResult saveConfirmation = MessageBox.Show(saveChangesWarning.ToString(), "Confirm save changes",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (saveConfirmation == DialogResult.Yes)
            {
                if (newSkillsToAdd != null)
                {
                    foreach (String skillToAdd in newSkillsToAdd)
                    {
                        Skill skillToSave = skillsService.CreateNewSkill(currentUser.Id, skillToAdd);
                        skillsService.SaveSkill(skillToSave);
                    }
                }

                if (skillsIdsToRemove != null)
                {
                    foreach (int skillToRemoveId in skillsIdsToRemove)
                    {
                        skillsService.RemoveSkill(skillToRemoveId);
                    }
                }

                SetDisplayMode(DisplayMode.View);
            }
        }

        private void DisplayProfileInfo(Profile profile)
        {
            view.PlayerName = profile.Name;
            view.History = profile.History;
            view.Age = profile.AgeInYears().HasValue ? profile.AgeInYears().Value.ToString() : "[birth date not set]";
            view.Experience = profile.Experience;
            view.Level = profile.Level;
            view.LevelProgress = profile.LevelProgressInPercent();
            view.Skills = profile.Skills.ToList();
            var experienceEvents =
                historyEventsRepository.Find(
                    he =>
                        he.Type == HistoryEventType.ExperienceGained ||
                        he.Type == HistoryEventType.LevelGained ||
                        he.Type == HistoryEventType.SkillExperienceGained ||
                        he.Type == HistoryEventType.SkillLevelGained).ToList();

            view.ExperienceEventData = GetExperienceEventRows(experienceEvents);
        }

        private List<string[]> GetExperienceEventRows(List<HistoryEvent> historyEvents)
        {
            List<string[]> workUnitsRows = new List<string[]>();

            foreach (var historyEvent in historyEvents)
            {
                String occuredDate = historyEvent.Occured.ToString("dddd, d MMMM HH:mm");
                String eventType = historyEvent.Type.ToString();

                string[] taskRow = new string[]
                {
                    $"{occuredDate}",
                    $"{eventType}",
/*                    $"{durationLiteral}"*/
                };

                workUnitsRows.Add(taskRow);
            }

            return workUnitsRows;
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
                view.RemoveSkillColumnVisible = true;
                view.AddNewSkillPanelVisible = true;
                view.EditProfileButtonVisible = false;
            }
            else if (displayMode == DisplayMode.View)
            {
                view.SaveChangesButtonVisible = false;
                view.CancelChangesButtonVisible = false;
                view.RemoveSkillColumnVisible = false;
                view.AddNewSkillPanelVisible = false;
                view.EditProfileButtonVisible = true;
            }
        }
    }
}
