using System;
using System.Text;
using DataAccessLayer.Repositories;
using DataAccessLayer.Repositories.Interfaces;
using DataAccessLayer.Services.Interfaces;
using Model.Entities;
using Model.Enums;
using Utilities;

namespace DataAccessLayer.Services
{
    public class HistoryService : IHistoryService
    {
        private IHistoryEventsRepository historyRepository;
        private ITasksRepository tasksRepository;
        private IWorkUnitsRepository workUnitsRepository;
        private ISkillsRepository skillsRepository;
        private IJournalRepository daysRepository;
        private IProfileRepository profilesRepository;

        private Profile currentUser;
        private Profile CurrentUser
        {
            get
            {
                if (currentUser == null)
                {
                    if (ApplicationSettings.Current.IsAnyUserLoggedIn &&
                        ApplicationSettings.Current.CurrentUserId.HasValue)
                    {
                        int currentUserId = ApplicationSettings.Current.CurrentUserId.Value;
                        currentUser = profilesRepository.Get(currentUserId);
                    }
                }
                return currentUser;
            }
        }

        public HistoryService()
        {
            historyRepository = new HistoryEventsRepository(@"Data Source=DMITRUSPACE;Initial Catalog=ExistenceDatabase;Integrated Security=True");
            tasksRepository = new TasksRepository(@"Data Source=DMITRUSPACE;Initial Catalog=ExistenceDatabase;Integrated Security=True");
            workUnitsRepository = new WorkUnitsRepository(@"Data Source=DMITRUSPACE;Initial Catalog=ExistenceDatabase;Integrated Security=True");
            skillsRepository = new SkillsRepository(@"Data Source=DMITRUSPACE;Initial Catalog=ExistenceDatabase;Integrated Security=True");
            daysRepository = new DaysRepository(@"Data Source=DMITRUSPACE;Initial Catalog=ExistenceDatabase;Integrated Security=True");
            profilesRepository = new ProfileRepository(@"Data Source=DMITRUSPACE;Initial Catalog=ExistenceDatabase;Integrated Security=True");
        }

        public HistoryService(IHistoryEventsRepository historyEventsRepository, ITasksRepository tasksRepository,
            IWorkUnitsRepository workUnitsRepository, ISkillsRepository skillsRepository,
            IJournalRepository daysRepository, IProfileRepository profilesRepository)
        {
            this.historyRepository = historyEventsRepository;
            this.tasksRepository = tasksRepository;
            this.workUnitsRepository = workUnitsRepository;
            this.skillsRepository = skillsRepository;
            this.daysRepository = daysRepository;
            this.profilesRepository = profilesRepository;
        }
        

        public void AddHistoryEvent(HistoryEventType type, int associatedTaskId, int? xpForEvent = null, int? newLevel = null)
        {
            AddHistoryEvent(type, associatedTaskId, "", xpForEvent, newLevel);
        }

        public void AddHistoryEvent(HistoryEventType type, int? associatedEntityId = null, String description = "", int? xpGained = null, int? levelGained = null)
        {
            HistoryEvent historyEvent = new HistoryEvent();
            historyEvent.Occured = DateTime.Now;
            historyEvent.Type = type;
            historyEvent.Owner = CurrentUser;

            if (!String.IsNullOrEmpty(description))
            {
                historyEvent.Description = description;
            }
            else
            {
                historyEvent.Description = GetDefaultDescription(type, associatedEntityId, xpGained, levelGained);
            }

            if (associatedEntityId.HasValue)
                historyEvent.AssociatedEntityId = associatedEntityId.Value;
            


            historyEvent.AdditionalInfo = GetAdditionalData(type, associatedEntityId, xpGained, levelGained);

            historyRepository.Add(historyEvent);
        }

        public void AddHistoryEvent(HistoryEventType type, int? associatedTaskId = null, int? xpForEvent = null, int? newLevel = null)
        {
            AddHistoryEvent(type, associatedTaskId, "", xpForEvent);
        }

        private string GetAdditionalData(HistoryEventType type, int? associatedEntityId, int? gainedXp = null, int? gainedLevel = null)
        {
            StringBuilder additionalData = new StringBuilder();
            Skill skill;

            switch (type)
            {
                case HistoryEventType.ExperienceGained:
                    if (gainedXp.HasValue)
                        additionalData.AppendFormat("Xp:{0}", gainedXp.Value);
                    break;

                case HistoryEventType.LevelGained:
                    if(gainedLevel.HasValue)
                        additionalData.AppendFormat("LevelReached:{0}", gainedLevel.Value);
                    break;

                case HistoryEventType.SkillExperienceGained:
                    if (associatedEntityId.HasValue && gainedXp.HasValue)
                    {
                        skill = skillsRepository.Get(associatedEntityId.Value);
                        additionalData.AppendFormat("Id:{0};Name:{1};Xp:{2}", skill.Id, skill.Name, gainedXp.Value);
                    }
                    break;

                case HistoryEventType.SkillLevelGained:
                    if (associatedEntityId.HasValue && gainedLevel.HasValue)
                    {
                        skill = skillsRepository.Get(associatedEntityId.Value);
                        additionalData.AppendFormat("SkillId:{0};SkillName:{1};LevelReached:{2}", skill.Id, skill.Name, gainedLevel.Value);
                    }
                    break;
            }

            return additionalData.ToString();
        }

        private string GetDefaultDescription(HistoryEventType type, int? associatedEntityId, int? gainedXp = null, int? gainedLevel = null)
        {
            StringBuilder description = new StringBuilder();
            StringBuilder additionalData = new StringBuilder();
            Task task = new Task();
            WorkUnit workUnit = new WorkUnit();
            Skill skill;
            Day day;
            Profile profile;

            switch (type)
            {
                case HistoryEventType.TaskCreated:
                    task = tasksRepository.Get(associatedEntityId.Value);
                    description.AppendFormat("Task of id = '{0}' and name = '{1}' was created.", task.Id, task.Name);
                    break;

                case HistoryEventType.TaskEdited:
                    task = tasksRepository.Get(associatedEntityId.Value);
                    description.AppendFormat("Task of id = '{0}' and name = '{1}' was edited.", task.Id, task.Name);
                    break;

                case HistoryEventType.TaskRemoved:
                    task = tasksRepository.Get(associatedEntityId.Value);
                    if (task != null)
                        description.AppendFormat("Task of id = '{0}' and name = '{1}' was removed.", task.Id, task.Name);
                    else
                        description.AppendFormat("Task  was removed.");
                    break;

                case HistoryEventType.TaskFinished:
                    task = tasksRepository.Get(associatedEntityId.Value);
                    description.AppendFormat("Task of id = '{0}' and name = '{1}' was finished.", task.Id, task.Name);
                    break;

                case HistoryEventType.WorkStarted:
                    workUnit = workUnitsRepository.Get(associatedEntityId.Value);
                    if (workUnit != null)
                        description.AppendFormat("Work Unit of id = '{0}' was started.", workUnit.Id);
                    else
                        description.AppendFormat("Work started.");

                    break;

                case HistoryEventType.WorkStopped:
                    workUnit = workUnitsRepository.Get(associatedEntityId.Value);
                    description.AppendFormat("Work Unit of id = '{0}' was stopped.", workUnit.Id);
                    break;

                case HistoryEventType.ExperienceGained:
                    description.AppendFormat("Gained {0} xp.", gainedXp.Value);
                    break;

                case HistoryEventType.LevelGained:
                    description.AppendFormat("Reached {0} level.", gainedLevel.Value);
                    break;

                case HistoryEventType.SkillExperienceGained:
                    if (associatedEntityId.HasValue)
                    {
                        skill = skillsRepository.Get(associatedEntityId.Value);
                        description.AppendFormat("Skill of id = '{0}' ({1}) gained {2} xp.", skill.Id, skill.Name, gainedXp.Value);
                    }
                    break;

                case HistoryEventType.SkillLevelGained:
                    if (associatedEntityId.HasValue)
                    {
                        skill = skillsRepository.Get(associatedEntityId.Value);
                        description.AppendFormat("Skill of id = '{0}' ({1}) gained {2} xp.", skill.Id, skill.Name,
                            gainedLevel.Value);
                    }
                    break;

                case HistoryEventType.SkillCreated:
                    if (associatedEntityId.HasValue)
                    {
                        skill = skillsRepository.Get(associatedEntityId.Value);
                        description.AppendFormat("Skill of id = '{0}' and name = '{1}' was created.", skill.Id, skill.Name);
                    }
                    break;

                case HistoryEventType.SkillEdited:
                    if (associatedEntityId.HasValue)
                    {
                        skill = skillsRepository.Get(associatedEntityId.Value);
                        description.AppendFormat("Skill of id = '{0}' and name = '{1}' was edited.", skill.Id, skill.Name);
                    }
                    break;

                case HistoryEventType.SkillRemoved:
                    description.AppendFormat("Skill  was removed.");
                    break;

                case HistoryEventType.ProfileCreated:
                    if (associatedEntityId.HasValue)
                    {
                        profile = profilesRepository.Get(associatedEntityId.Value);
                        description.AppendFormat("Profile of id = '{0}' and name = '{1}' was created.", profile.Id, profile.Name);
                    }
                    break;

                case HistoryEventType.ProfileEdited:
                    if (associatedEntityId.HasValue)
                    {
                        profile = profilesRepository.Get(associatedEntityId.Value);
                        description.AppendFormat("Profile of id = '{0}' and name = '{1}' was edited.", profile.Id, profile.Name);
                    }
                    break;

                case HistoryEventType.ProfileRemoved:
                    description.AppendFormat("Profile was removed.");
                    break;

                case HistoryEventType.DaySaved:
                    if (associatedEntityId.HasValue)
                    {
                        day = daysRepository.Get(associatedEntityId.Value);
                        description.AppendFormat("Day '{0}' was created.", day.Id);
                        // TODO
                        // description.AppendFormat("Day '{0}' was created for user '{1}'.", day.Id, day.Owner.Id);
                    }
                    break;

                case HistoryEventType.DayUpdated:
                    break;


                default:
                    throw new ArgumentOutOfRangeException(nameof(type), type, null);
            }

            return description.ToString();
        }

        
    }
}
