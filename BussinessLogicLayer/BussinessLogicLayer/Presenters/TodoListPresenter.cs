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
    public class TodoListPresenter : IPresenter, ICanHandle<TasksChangedEvent>
    {
        private readonly ITodoListView view;
        private readonly ITasksRepository tasksRepository;
        private readonly IPublisher publisher;
        private readonly ISubscriber subscriber;

        private List<Task> tasks;
        public event EventHandler<ShowNotificationEvent> NotificationAppeared;
        
        public TodoListPresenter(ITodoListView view, ITasksRepository tasksRepository, IPublisher publisher, ISubscriber subscriber)
        {
            this.view = view;
            this.tasksRepository = tasksRepository;
            this.publisher = publisher;
            this.subscriber = subscriber;
        }

        #region Events

        public void OnViewDisplayed()
        {
            //GetAndDisplayTasks();
        }
        
        private void New(object sender, EventArgs e)
        {
            publisher.Publish(new OpenWindowEvent(WindowType.TaskWindow, DisplayMode.Edit, null));
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

                subscriber.Subscribe(this);
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
            view.ChangeSorting += ChangeSorting;
        }

        private void GetAndDisplayTasks()
        {
            tasks = ObtainTasksList();
            tasks = SortTasks(tasks, view.SortingType);
            DisplayTasks(tasks);
        }

        private void ChangeSorting(object sender, SortingType sortingType)
        {
            tasks = SortTasks(tasks, sortingType);
            DisplayTasks(tasks);
        }

        private void GetAndDisplayTasks(bool includeFinishedTasks = false)
        {
            tasks = ObtainTasksList(includeFinishedTasks);

            if (tasks != null && tasks.Count > 0)
            {
                tasks = SortTasks(tasks, view.SortingType, includeFinishedTasks);
                DisplayTasks(tasks);
            }
        }
        
        private void DisplayTasks(List<Task> tasksList)
        {
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

                    String name = task.Name;
                    if (task.Parent != null)
                         name = GetTaskNameForNestedTask(task);
                    else if (task.Tasks != null && task.Tasks.Count > 0)
                        name = $"[Goal] {name}";
                    
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

        private string GetTaskNameForNestedTask(Task task)
        {
            string name = "";// task.Name;
            if (view.SortingType == SortingType.ByGoal)
            {
                Task parent = task.Parent;
                while (parent != null)
                {
                    name += " - ";
                    parent = parent.Parent;
                }
                name += task.Name;
            }
            else
                name = task.Name; 

            //    name = $" - {task.Name}";
            //else
            //    string name = $"{task.Name}";

            //string name = $"[{task.Parent.Name}] - {task.Name}";
            //string name = string.Format("[{0}] - {1}", task.Parent.Name, task.Name);
            return name;
        }

        private List<Task> ObtainTasksList(bool includeFinishedTasks = false)
        {
            if (tasksRepository.HasTasks())
            {
                var tasksQuery = tasksRepository.Find(t => t.Owner.Id == Globals.DmitruUserId);

                if (!includeFinishedTasks)
                    tasksQuery = tasksQuery.Where(t => t.IsFinished == false);

                tasks = tasksQuery.ToList();
            }

            return tasks;
        }

        private List<Task> FlattenTaskHierarchy(Task task)
        {
            List<Task> flatGoalHierarchy = new List<Task>();
            flatGoalHierarchy.Add(task);
            if (task.Tasks.Count > 0)
            {
                foreach (var subtask in task.Tasks)
                {
                    flatGoalHierarchy.AddRange(FlattenTaskHierarchy(subtask));
                }
            }
            return flatGoalHierarchy;
        }

        private List<Task> SortTasks(List<Task> tasksUnsorted, SortingType sortingType, bool includeFinishedTasks = false)
        {
            List<Task> sortedTasks = new List<Task>();
            
            switch (sortingType)
            {
                // First by due date from past to future
                // Then by priority
                case SortingType.ByDeadline:
                    sortedTasks = tasksUnsorted
                        .OrderBy(t => t.DueDate.Value.Date)
                        .ThenByDescending(t => t.Priority).ToList();
                    break;

                // Single tasks first
                // Then top level goal tasks
                // Then hierarchically to bottom
                case SortingType.ByGoal:
                    var singleTasks = tasksUnsorted.Where(t => (t.Tasks == null || t.Tasks.Count == 0) && t.Parent == null);
                    sortedTasks.AddRange(singleTasks);

                    var goals = tasksUnsorted.Where(t => t.Tasks != null && t.Tasks.Count > 0 && t.Parent == null);
                    foreach(var goal in goals)
                    {
                        sortedTasks.AddRange(FlattenTaskHierarchy(goal));
                    }
                    break;

                case SortingType.Unknown:
                    sortedTasks = tasksUnsorted;
                    break;
            }

            return sortedTasks.ToList();
        }
        
        private void ShowTaskDetails(object sender, int taskId)
        {
            publisher.Publish(new OpenWindowEvent(WindowType.TaskWindow, DisplayMode.View, taskId));
        }

        public void Handle(TasksChangedEvent tasksChangedEvent)
        {
            GetAndDisplayTasks();
        }

        #endregion
    }

    
}
