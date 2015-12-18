using System;
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
            int? parentTaskId, int? associatedSkillId, int difficulty)
        {
            Task task = new Task();
            task.Name = name;
            task.Description = description;
            task.Priority = TaskDefaults.Priorities[priority].Severity;
            task.Difficulty = TaskDefaults.Difficulties[difficulty].Difficulty;
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

        public Task UpdateExistingTask(int taskId, string name, string description, DateTime dueDateTime, int priority, int? parentTaskId, int? associatedSkillId, int difficulty)
        {
            Task task = tasksRepository.Get(taskId);
            task.Name = name;
            task.Description = description;
            task.Priority = TaskDefaults.Priorities[priority].Severity;
            task.Difficulty = TaskDefaults.Difficulties[difficulty].Difficulty;
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
           /* if (task.SkillToTrain != null && workUnit.Duration.HasValue)
            {
                double experienceForWorkUnit = ExperienceDefaultValues.GetExperienceForWork(workUnit.Duration.Value);
                
                SkillTrainer.GiveXpToSkill(task.SkillToTrain.Id, experienceForWorkUnit);
                historyService.AddHistoryEvent(HistoryEventType.SkillExperienceGained, task.SkillToTrain.Id, experienceForWorkUnit);

                if (SkillTrainer.HasSkillReachedNewLevel(task.SkillToTrain.Id))
                {
                    int skillNewLevel = SkillTrainer.GetSkillNewLevel(task.SkillToTrain.Id);
                    SkillTrainer.SkillLevelUp(task.SkillToTrain.Id, skillNewLevel);
                    historyService.AddHistoryEvent(HistoryEventType.SkillLevelGained, task.SkillToTrain.Id, newLevel: skillNewLevel);
                }
            }
*/
        }

        public void UpdateTask(Task taskToUpdate)
        {
            tasksRepository.Update(taskToUpdate);
            historyService.AddHistoryEvent(HistoryEventType.TaskEdited, taskToUpdate.Id);
        }

        /// <summary>
        /// Returns overall xp for completing the task. Experience is calculated as follows:
        /// 
        ///     Experience = ([Base experience for completing task] + [Experience for spending time on task]) * [Task severity multiplier] * [Task difficulty multiplier]
        ///     
        /// Severity multipliers are:
        ///     Low priority - 0.5
        ///     Medium priority - 1
        ///     High priority - 1.5
        /// 
        /// 
        /// Example - high priority task, which was finished in 3 hours
        ///     
        ///     Experience  = ([Base 10XP] + [3 hours * 10XP/hour]) * 1.5 = 40XP * 1.5 = 60XP 
        /// </summary>
        /// <param name="taskId"></param>
        /// <returns></returns>
        public int GetExperienceForCompletion(int taskId)
        {
            double overallXpForTaskCompletion = ExperienceDefaultValues.BaseExperienceForTaskCompletion;

            Task task = tasksRepository.Get(taskId);
            if (task != null)
            {
                int baseXpForTaskFinish = ExperienceDefaultValues.BaseExperienceForTaskCompletion;
                double severityMultiplier = ExperienceDefaultValues.GetSeverityMultiplier(task.Priority);
                double difficultyMultiplier = ExperienceDefaultValues.GetDifficultyMultiplier(task.Difficulty);
                int random = GetRandomBetween(ExperienceDefaultValues.RandomMin, ExperienceDefaultValues.RandomMax);
                double randomMultiplier = (double) ((double) random / 10);

                Random rnd = new Random();
                int month = rnd.Next(1, 13);
                double experienceForWorkUnits = 0;

                if (task.WorkUnits != null && task.WorkUnits.Count > 0)
                {
                    foreach (WorkUnit workUnit in task.WorkUnits)
                    {
                        double experienceForWorkUnit =
                            ExperienceDefaultValues.GetExperienceForWork(workUnit.Duration.Value);
                        experienceForWorkUnits += experienceForWorkUnit;
                    }
                }

                overallXpForTaskCompletion = (baseXpForTaskFinish + experienceForWorkUnits)*severityMultiplier*difficultyMultiplier*randomMultiplier;
            }

            return (int)overallXpForTaskCompletion;
        }

        public int GetRandomBetween(int min, int max)
        {
            Random rnd = new Random();
            return rnd.Next(min, max);
        }

        public int GetExperienceForCreation(int taskId)
        {
            double xpForTaskCreation = ExperienceDefaultValues.CreatingTaskXp;

            Task task = tasksRepository.Get(taskId);
            if (task != null)
            {
                int baseXpForTaskCreation = ExperienceDefaultValues.CreatingTaskXp;
                double severityMultiplier = ExperienceDefaultValues.GetSeverityMultiplier(task.Priority);
                
                xpForTaskCreation = baseXpForTaskCreation * severityMultiplier;
            }

            return (int)xpForTaskCreation;
        }
    }
}
