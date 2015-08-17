using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccessLayer.Repositories;
using Model.Classes;
using Model.Entities;
using Model.Enums;

namespace DataAccessLayer.Services
{
    public class TaskService
    {
        private TasksRepository taskRepository;
        private SkillsRepository skillsRepository;
        private HistoryService historyService;

        public TaskService()
        {
            taskRepository = new TasksRepository();
            skillsRepository = new SkillsRepository();
            historyService = new HistoryService();
        }

        public void AddNewTask(String name, String description, DateTime dueDateTime, int priority,
            int? parentTaskId, int? associatedSkillId)
        {
            Task task = new Task();
            task.Name = name;
            task.Description = description;
            task.Priority = TaskDefaults.Priorities[priority].Severity;
            task.DueDate = dueDateTime;
            task.CreationDate = DateTime.Now;

            if (associatedSkillId.HasValue)
                task.SkillToTrain = skillsRepository.First(s => s.Id == associatedSkillId);

            if (parentTaskId.HasValue)
                task.Parent = taskRepository.Get(parentTaskId.Value);
            

            taskRepository.Add(task);

            historyService.AddHistoryEvent(HistoryEventType.TaskCreated, task.Id);
            
        }
    }
}
