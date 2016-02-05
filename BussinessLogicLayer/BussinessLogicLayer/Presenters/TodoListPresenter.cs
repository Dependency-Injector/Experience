using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using BussinessLogicLayer.Enums;
using BussinessLogicLayer.Events;
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
    public class TodoListPresenter : IPresenter
    {
        private readonly ITodoListView view;
        private readonly ITasksRepository tasksRepository;
        private readonly IPublisher publisher;

        private List<Task> tasks;
        public event EventHandler<ShowNotificationEventArgs> NotificationAppeared;
        
        public TodoListPresenter(ITodoListView view, ITasksRepository tasksRepository, IPublisher publisher)
        {
            this.view = view;
            this.tasksRepository = tasksRepository;
            this.publisher = publisher;
        }

        #region Events

        public void OnViewDisplayed()
        {
            GetAndDisplayTasks();
        }
        
        private void New(object sender, EventArgs e)
        {
            publisher.Publish(new OpenTaskDetailsWindow(DisplayMode.Edit, null));
        }
        
        private void ShowFinishedTasks(object sender, bool showFinishedTasks)
        {
            GetAndDisplayTasks(showFinishedTasks);
        }

        #endregion

        #region Helper methods

        public void Initialize()
        {
            try
            {
                AttachEvents();
                GetAndDisplayTasks();
            }
            catch (Exception e)
            {
                Logger.Exception(e);
            }
        }

        private void AttachEvents()
        {
            view.NewTask += New;
            view.ShowFinishedTasks += ShowFinishedTasks;
            view.TaskDoubleClick += ShowTaskDetails;
        }


        private void GetAndDisplayTasks(bool includeFinishedTasks = false)
        {
            tasks = ObtainTasksList(includeFinishedTasks);
            tasks = SortTasks(tasks);

            if (tasks != null && tasks.Count > 0)
            {
                DisplayTasks(tasks);
            }
        }
        
        private void DisplayTasks(List<Task> tasksList)
        {
            var tasks = tasksList.ToDictionary(k => k.Id, val => val.Name);
            view.TasksGridItems = GetTasksGridItems(tasksList);
        }

        private IList<TaskGridItem> GetTasksGridItems(List<Task> tasksList)
        {
            IList<TaskGridItem> tasksGridItems = new List<TaskGridItem>();

            foreach (Task task in tasksList)
            {
                if (task.DueDate.HasValue)
                {
                    int daysToDeadline = (int) (task.DueDate.Value.Date - DateTime.Now.Date).TotalDays;
                    string deadlineLiteral = String.Empty;
                    if (daysToDeadline < 0)
                        deadlineLiteral = $"Overdue {Math.Abs(daysToDeadline)} days!";
                    else if (daysToDeadline == 0)
                        deadlineLiteral = "Today";
                    else if (daysToDeadline == 1)
                        deadlineLiteral = "Tomorrow";
                    else if (daysToDeadline > 1)
                        deadlineLiteral = task.DueDate.Value.ToString("M");

                    string timeSpent = task.GetTotalWorkloadLiteral();

                    String priority = task.GetPriorityLiteral();

                    String name = String.Empty;
                    /* if (task.Parent != null)
                         name = GetTaskNameForNestedTask(task);
                     else
                         name = task.Name;*/
                    if (task.Tasks != null && task.Tasks.Count > 0)
                        name = $"[Goal] {task.Name}";
                    else
                        name = task.Name;

                    TaskTextColor color;
                    if(task.Priority == Severity.High || task.DueDate.Value.Date < DateTime.Now.Date)
                         color = TaskTextColor.Red;
                    else if(task.DueDate.Value.Date == DateTime.Now.Date)
                        color = TaskTextColor.Yellow;
                    else
                        color = TaskTextColor.Normal;
                   
                    tasksGridItems.Add(new TaskGridItem(task.Id, name, deadlineLiteral, timeSpent, priority, color));
                }
            }

            return tasksGridItems;
        }

        private List<Task> ObtainTasksList(bool includeFinishedTasks = false)
        {
            List<Task> tasks = new List<Task>();

            if (tasksRepository.HasTasks() && ApplicationSettings.Current.IsAnyUserLoggedIn)
            {
                var tasksQuery = tasksRepository.Find(t => t.Owner.Id == ApplicationSettings.Current.CurrentUserId);

                if (!includeFinishedTasks)
                    tasksQuery = tasksQuery.Where(t => t.IsFinished == false);

                tasks = tasksQuery.ToList();
            }

            return tasks;
        }

        private List<Task> SortTasks(List<Task> tasksUnsorted, bool includeFinishedTasks = false)
        {
            return
                tasksUnsorted.OrderBy(t => t.DueDate.Value.Date)
                    .ThenByDescending(t => t.Priority)
                    .ToList();
        }


        private void ShowTaskDetails(object sender, int taskId)
        {
            publisher.Publish(new OpenTaskDetailsWindow(DisplayMode.View, taskId));
        }

        #endregion
    }

    
}
