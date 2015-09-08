using System;
using DataAccessLayer.Repositories;
using DataAccessLayer.Repositories.Interfaces;
using DataAccessLayer.Services.Interfaces;
using DataAccessLayer.Utilities;
using Model.Classes;
using Model.Entities;
using Model.Enums;

namespace DataAccessLayer.Services
{
    public class TaskService : ITaskService
    {
        private ITasksRepository tasksRepository;
        private ISkillsRepository skillsRepository;
        private IHistoryService historyService;
        private IWorkUnitsRepository workUnitsRepository;
        private IProfileRepository profileRepository;

        public TaskService(ITasksRepository tasksRepository, ISkillsRepository skillsRepository, IWorkUnitsRepository workUnitsRepository, IProfileRepository profileRepository, IHistoryService historyService)
        {
            this.tasksRepository = tasksRepository;
            this.skillsRepository = skillsRepository;
            this.historyService = historyService;
            this.workUnitsRepository = workUnitsRepository;
            this.profileRepository = profileRepository;
        }
        
        public Task CreateNewTask(int? ownerId, String name, String description, DateTime dueDateTime, int priority,
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
                task.Parent = tasksRepository.Get(parentTaskId.Value);

            if (ownerId.HasValue)
                task.Owner = profileRepository.First(p => p.Id == ownerId.Value);

            return task;
        }

        public Task UpdateExistingTask(int taskId, string name, string description, DateTime dueDateTime, int priority, int? parentTaskId, int? associatedSkillId)
        {
            Task task = tasksRepository.Get(taskId);
            task.Name = name;
            task.Description = description;
            task.Priority = TaskDefaults.Priorities[priority].Severity;
            task.DueDate = dueDateTime;
            task.CreationDate = DateTime.Now;

            if (associatedSkillId.HasValue)
                task.SkillToTrain = skillsRepository.First(s => s.Id == associatedSkillId);

            if (parentTaskId.HasValue && parentTaskId.Value > 0)
                task.Parent = tasksRepository.Get(parentTaskId.Value);

            return task;
        }

        public void FinishTask(Task taskToFinish)
        {
            taskToFinish.IsFinished = true;
            taskToFinish.FinishedDate = DateTime.Now;
            tasksRepository.Update(taskToFinish);
        }

        /// <summary>
        /// Checks if there are unfinished children tasks. Task can be finished only if it doesn't have unfinished children tasks.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool IsFinishingAllowed(int id)
        {
            var task = tasksRepository.Get(id);
            if (task.IsFinished)
                return false;

            var childrenTasks = tasksRepository.Find(t => t.Parent.Id == id);
            foreach (var childrenTask in childrenTasks)
            {
                if (!childrenTask.IsFinished)
                    return false;
            }

            return true;
        }

        public void SaveTask(Task taskToSave)
        {
            tasksRepository.Add(taskToSave);
            
            historyService.AddHistoryEvent(HistoryEventType.TaskCreated, taskToSave.Id);
        }



        public void WorkedOnTask(Task task, WorkUnit workUnit)
        {
            if (task.SkillToTrain != null && workUnit.Duration.HasValue)
            {
                int gainedExperience = SkillTrainer.CalculateXpForWork(workUnit.Duration.Value);
                SkillTrainer.GiveXpToSkill(task.SkillToTrain.Id, gainedExperience);
                historyService.AddHistoryEvent(HistoryEventType.SkillExperienceGained, task.SkillToTrain.Id, gainedExperience);

                if (SkillTrainer.HasSkillReachedNewLevel(task.SkillToTrain.Id))
                {
                    int skillNewLevel = SkillTrainer.GetSkillNewLevel(task.SkillToTrain.Id);
                    SkillTrainer.SkillLevelUp(task.SkillToTrain.Id, skillNewLevel);
                    historyService.AddHistoryEvent(HistoryEventType.SkillLevelGained, task.SkillToTrain.Id, newLevel: skillNewLevel);
                }
            }

        }
    }
}
