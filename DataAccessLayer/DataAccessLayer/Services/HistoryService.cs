using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccessLayer.Repositories;
using DataAccessLayer.Utilities;
using Model.Entities;
using Model.Enums;

namespace DataAccessLayer.Services
{
    public class HistoryService
    {
        private HistoryEventsRepository historyRepository;
        private TasksRepository taskRepository;
        private WorkUnitsRepository workUnitsRepository;
        private SkillsRepository skillRepository;
         

        public HistoryService()
        {
            historyRepository = new HistoryEventsRepository(@"Data Source=DMITRUSPACE\DMITRUSERVER;Initial Catalog=EntitiesDatabase;Integrated Security=True");
            taskRepository = new TasksRepository(@"Data Source=DMITRUSPACE\DMITRUSERVER;Initial Catalog=EntitiesDatabase;Integrated Security=True");
            workUnitsRepository = new WorkUnitsRepository(@"Data Source=DMITRUSPACE\DMITRUSERVER;Initial Catalog=EntitiesDatabase;Integrated Security=True");
            skillRepository = new SkillsRepository(@"Data Source=DMITRUSPACE\DMITRUSERVER;Initial Catalog=EntitiesDatabase;Integrated Security=True");
        }

        public void AddHistoryEvent(HistoryEventType type, int? associatedEntityId = null, String description = "", int? XP = null)
        {
            HistoryEvent historyEvent = new HistoryEvent();
            historyEvent.Occured = DateTime.Now;
            historyEvent.Type = type;
           
            if (!String.IsNullOrEmpty(description))
            {
                historyEvent.Description = description;
            }
            else
            {
                historyEvent.Description = GetDefaultDescription(type, associatedEntityId, XP);
            }

            if (associatedEntityId.HasValue)
                historyEvent.TaskId = associatedEntityId.Value;

            historyRepository.Add(historyEvent);
        }

        private string GetDefaultDescription(HistoryEventType type, int? associatedEntityId, int? gainedXp)
        {
            StringBuilder description = new StringBuilder();
            Task task = new Task();
            WorkUnit workUnit = new WorkUnit();
            Skill skill;


            switch (type)
            {
                case HistoryEventType.TaskCreated:
                    task = taskRepository.Get(associatedEntityId.Value);
                    description.AppendFormat("Task of id = '{0}' and name = '{1}' was created.", task.Id, task.Name);
                    break;
                case HistoryEventType.TaskEdited:
                    task = taskRepository.Get(associatedEntityId.Value);
                    description.AppendFormat("Task of id = '{0}' and name = '{1}' was edited.", task.Id, task.Name);
                    break;
                case HistoryEventType.TaskRemoved:
                    task = taskRepository.Get(associatedEntityId.Value);
                    if (task != null)
                    {
                        description.AppendFormat("Task of id = '{0}' and name = '{1}' was removed.", task.Id, task.Name);
                    }
                    else
                    {
                        description.AppendFormat("Task  was removed.");

                    }
                    break;
                case HistoryEventType.TaskFinished:
                    task = taskRepository.Get(associatedEntityId.Value);
                    description.AppendFormat("Task of id = '{0}' and name = '{1}' was finished.", task.Id, task.Name);
                    break;

                case HistoryEventType.WorkStarted:
                    workUnit = workUnitsRepository.Get(associatedEntityId.Value);
                    if(workUnit != null)
                        description.AppendFormat("Work Unit of id = '{0}' was started.", workUnit.Id);
                    else
                        description.AppendFormat("Work started.");

                    break;
                case HistoryEventType.WorkStopped:
                    workUnit = workUnitsRepository.Get(associatedEntityId.Value);
                    description.AppendFormat("Work Unit of id = '{0}' was stopped.", workUnit.Id);
                    break;
                case HistoryEventType.ExperienceGained:
                    break;
                case HistoryEventType.LevelGained:
                    break;
                case HistoryEventType.SkillExperienceGained:
                    break;
                case HistoryEventType.SkillLevelGained:
                    break;
                case HistoryEventType.ProfileCreated:
                    break;
                case HistoryEventType.ProfileEdited:
                    break;
                case HistoryEventType.ProfileRemoved:
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(type), type, null);
            }

            if (task != null && task.SkillToTrain != null && workUnit != null)
                description.AppendFormat(" Skill {0} gained {1} experience.", task.SkillToTrain.Name, workUnit.GetDurationInHours() * ExperienceDefaultValues.ExperiencePerHour);

            if (gainedXp.HasValue)
                description.AppendFormat(" Gained {0} experience.", gainedXp.Value);

            return description.ToString();
        }

        public void AddHistoryEvent(HistoryEventType type, int associatedTaskId, int xpForEvent)
        {
            AddHistoryEvent(type, associatedTaskId, "", xpForEvent);
        }
    }
}
