using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccessLayer.Repositories;
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

        public void AddHistoryEvent(HistoryEventType type, int? associatedEntityId = null, String description = "")
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
                historyEvent.Description = GetDefaultDescription(type, associatedEntityId);
            }

            if (associatedEntityId.HasValue)
                historyEvent.AssociatedEntityId = associatedEntityId.Value;

            historyRepository.Add(historyEvent);
        }

        private string GetDefaultDescription(HistoryEventType type, int? associatedEntityId)
        {
            StringBuilder description = new StringBuilder();
            Task task;
            WorkUnit workUnit;
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
                    description.AppendFormat("Work Unit of id = '{0}' was started.", workUnit.Id);
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

            return description.ToString();
        }
    }
}
