using System;
using System.Collections;
using System.Collections.Generic;
using BussinessLogicLayer.Interfaces;
using DataAccessLayer.Repositories.Interfaces;
using DataAccessLayer.Services.Interfaces;
using DataAccessLayer.Utilities;
using Model.Entities;
using Model.Enums;
using Utilities;
using Task = Model.Entities.Task;
using BussinessLogicLayer.Events;
using BussinessLogicLayer.Enums;

namespace BussinessLogicLayer.Presenters
{
    public class TaskDisplayPresenter
    {
        private readonly ITaskDisplayView view;
        private readonly ITasksRepository tasksRepository;
        private readonly IHistoryService historyService;
        private readonly ITasksService tasksService;
        private readonly IProfileService profilesService;
        private readonly IImprovementsService improvementsService;
        private readonly IPublisher publisher;

        private Task task;

        public TaskDisplayPresenter(ITaskDisplayView view, ITasksRepository tasksRepository, IHistoryService historyService, 
            ITasksService tasksService, IProfileService profilesService, IImprovementsService improvementsService, IPublisher publisher)
        {
            this.view = view;
            this.tasksRepository = tasksRepository;
            this.tasksService = tasksService;
            this.historyService = historyService;
            this.profilesService = profilesService;
            this.improvementsService = improvementsService;
            this.publisher = publisher;
        }

        public void Initialize()
        {
            try
            {
                AttachEvents();
            }
            catch (Exception ex)
            {
                Logger.Exception(ex);
            }
        }

        public void SetTask(Task task)
        {
            this.task = task;
        }

        public void DisplayTaskDetails()
        {
            view.TaskName = task.Name;

            if (!String.IsNullOrEmpty(task.Description))
                view.TaskDescription = task.Description;
            else
                view.TaskDescription = "-";

            if (task.DueDate.HasValue)
                view.Deadline = task.DueDate.Value.ToString("dd MM yyyy");

            if (task.SkillToTrain != null)
                view.AssociatedSkillName = task.SkillToTrain.Name;
            else
                view.AssociatedSkillName = "-";

            if (task.Parent != null)
                view.ParentTaskName = task.Parent.Name;
            else
                view.ParentTaskName = "-";

            if (task.IsFinished)
                view.FinishDate = task.FinishedDate.Value.ToString("d");

            if (task.Tasks != null && task.Tasks.Count > 0)
            {
                view.ChildrenTasksPresent = true;
                view.ChildrenTasks = GetChildrenTasksRows(task.Tasks);
            }
            else
            {
                view.ChildrenTasksPresent = false;
            }

            view.Priority = task.GetPriorityLiteral();
        }

        private void AttachEvents()
        {
            view.FinishTask += FinishTask;
        }

        private void FinishTask(object sender, EventArgs eventArgs)
        {
            var taskToFinish = task;

            if(taskToFinish.IsFinished)
                throw new Exception("Task already finished");

            int xpForTaskFinish = tasksService.GetExperienceForCompletion(taskToFinish.Id);

            // Finish task and save info about this
            tasksService.FinishTask(taskToFinish);
            historyService.AddHistoryEvent(HistoryEventType.TaskFinished, taskToFinish.Id, xpForTaskFinish);

            
            Improvement improvement = improvementsService.CreateNewImprovement(Globals.DmitruUserId, ImprovementType.ExperienceGained, ImprovementOrigin.TaskCompletion, xpForTaskFinish, taskToFinish.Id);
            improvementsService.SaveImprovement(improvement);
            profilesService.UserGainedExperience(taskToFinish.Owner.Id, xpForTaskFinish);

            if (taskToFinish.SkillToTrain != null)
            {
                int experienceForTask = 0;

                if (taskToFinish.WorkUnits != null && taskToFinish.WorkUnits.Count > 0)
                {
                    int experienceForWorkUnits = 0;

                    foreach (var workUnit in taskToFinish.WorkUnits)
                    {
                        experienceForWorkUnits +=
                            (int)ExperienceDefaultValues.GetExperienceForWork(workUnit.Duration.Value);
                    }

                    experienceForTask = experienceForWorkUnits;
                }
                else
                {
                    experienceForTask = xpForTaskFinish;
                }

                if (experienceForTask > 0)
                {
                    Improvement skillImprovement = improvementsService.CreateNewImprovement(Globals.DmitruUserId, ImprovementType.SkillExperienceGained, ImprovementOrigin.TaskCompletion, experienceForTask, taskToFinish.Id, taskToFinish.SkillToTrain.Id);
                    improvementsService.SaveImprovement(skillImprovement);
                    profilesService.UserSkillGainedExperience(taskToFinish.SkillToTrain.Id, experienceForTask);

                    if (taskToFinish.SkillToTrain.HasReachedNewLevel())
                    {
                        // Give skill new level
                        int skillNewLevel = taskToFinish.SkillToTrain.GetNewLevel();

                        Improvement skillLevelUpImprovement = improvementsService.CreateNewImprovement(Globals.DmitruUserId, ImprovementType.SkillLevelUp, ImprovementOrigin.TaskCompletion, skillNewLevel, taskToFinish.Id, taskToFinish.SkillToTrain.Id);
                        improvementsService.SaveImprovement(skillLevelUpImprovement);
                        profilesService.UserSkillReachedNewLevel(taskToFinish.SkillToTrain.Id, skillNewLevel);

                        historyService.AddHistoryEvent(HistoryEventType.SkillLevelGained, taskToFinish.SkillToTrain.Id, newLevel: skillNewLevel);
                    }
                }
            }

            // Propagate task changed event
            publisher.Publish(new TasksChangedEvent(ListChangeType.Update, taskToFinish.Id));

            string notificationText = "";// NotificationCreator.GetNotificationText();
            notificationText += $"You have finished {taskToFinish.Name} task and gained {xpForTaskFinish} XP. Congratulations!";
            publisher.Publish(new ShowNotificationEvent("Task finished!", notificationText));
        }

        private ICollection GetChildrenTasksRows(ICollection<Task> childrenTasks)
        {
            List<string[]> childrenTasksRows = new List<string[]>();

            foreach (var childrenTask in childrenTasks)
            {
                string[] childrenTaskRow = new string[]
                {
                    $"{childrenTask.Name}",
                    $"{childrenTask.IsFinished}"
                };

                childrenTasksRows.Add(childrenTaskRow);
            }

            return childrenTasksRows;
        }

        public void HideView()
        {
            view.IsVisible = false;
        }

        public void ShowView()
        {
            view.IsVisible = true;
        }
    }
}
