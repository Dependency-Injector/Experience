using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DataAccessLayer.Model;
using DataAccessLayer.Repositories;
using PresentationLayer.Views;

namespace PresentationLayer.Presenters
{
    public enum DisplayMode
    {
        View,
        Edit    
    }

    public class TasksPresenter
    {
        #region Private fields

        private readonly ITasksView tasksView;
        private readonly ITaskViewerLayer taskViewer;

        private DisplayMode displayMode;

        private readonly TasksRepository repository;
        private List<Task> tasks;
        private int selectedTaskIndex;
        private bool isNew = true;

        #endregion

        public TasksPresenter(ITasksView tasksView, ITaskViewerLayer taskViewer)
        {
            this.tasksView = tasksView;
            this.taskViewer = taskViewer;

            repository = new TasksRepository();

            Initialize();
        }

        #region Events

        private void Initialize()
        {
            try
            {
                AttachEvents();
                ObtainTasksList();
                SetDisplayMode(DisplayMode.View);

                if (tasks != null && tasks.Count > 0)
                {
                    DisplayTaskInfo(tasks[0]);
                    DisplayTasksList(tasks);
                    SetStatus("{0} tasks were loaded", tasks.Count);
                    selectedTaskIndex = tasks.Count - 1;
                }
                else
                {
                    DisplayBlankTask();
                    SetStatus("No tasks were found");
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void SetDisplayMode(DisplayMode displayMode)
        {
            this.displayMode = displayMode;

            if (this.displayMode == DisplayMode.View)
            {
                
            }
        }

        private void ShowPrevious(object sender, EventArgs e)
        {
            if (selectedTaskIndex > 0)
            {
                selectedTaskIndex--;
                DisplayTaskInfo(GetTaskAtIndex(selectedTaskIndex));
                tasksView.IsDirty = false;
                SetStatus("Task: {0}", selectedTaskIndex + 1);
            }
            else
            {
                SetStatus("No previous task");
            }
        }

        private void ShowNext(object sender, EventArgs e)
        {
            if (selectedTaskIndex + 1 < tasks.Count)
            {
                selectedTaskIndex++;
                DisplayTaskInfo(GetTaskAtIndex(selectedTaskIndex));
                tasksView.IsDirty = false;
                SetStatus("Task: {0}", selectedTaskIndex + 1);
            }
            else
            {
                SetStatus("No next task");
            }
        }

        private void New(object sender, EventArgs e)
        {
            DisplayBlankTask();
            isNew = true;
            tasksView.IsDirty = false;
            selectedTaskIndex = tasks.Count - 1;
            SetStatus("New task created");
        }
        
        #endregion

        #region Helper methods

        private void AttachEvents()
        {
            tasksView.NewTask += New;
            tasksView.PreviousTask += ShowPrevious;
            tasksView.NextTask += ShowNext;
            tasksView.SelectTask += SelectTask;

            taskViewer.EditTask += EditTask;
            taskViewer.FinishTask += FinishTask;
        }

        private void EditTask(object sender, EventArgs e)
        {
            //taskViewer.Hide();
            
        }

        private void ObtainTasksList()
        {
            tasks = repository.HasTasks() ? repository.GetAll().ToList() : new List<Task>();
        }

        private void RefreshTasksGridview()
        {
            //view.Tasks = tasks;
        }

        private void DisplayTasksList(List<Task> tasksList)
        {
            tasksView.Tasks = SortTasks(tasksList);
            //view.Tasks = SortTasks(tasksList);
        }

        private void DisplayBlankTask()
        {
            taskViewer.TaskName = "[Name something to be done]";
            taskViewer.Priority = 1;
            //view.StartDate = DateTime.Now;
            taskViewer.DueDate = DateTime.Now.AddDays(7);
            taskViewer.IsFinished = false;
            taskViewer.FinishDate = null;
        }

        private void DisplayTaskInfo(Task task)
        {
            taskViewer.TaskName = task.Name;
            taskViewer.Priority = task.Priority;
            //view.StartDate = task.StartDate;
            taskViewer.DueDate = task.DueDate;
            taskViewer.IsFinished = task.IsFinished;
            taskViewer.FinishDate = task.FinishedDate;
            isNew = false;
        }

        private Task GetTaskAtIndex(int index)
        {
            if (tasks != null && tasks.Count > 0 && index < tasks.Count)
                return tasks[index];

            return null;
        }

        private Task GetSelectedTask()
        {
            return GetTaskAtIndex(selectedTaskIndex);
        }

        private void SelectTask(object sender, int id)
        {
            var indexOfTask = tasks.FindIndex(t => t.Id == id);
            var selectedTask = GetTaskAtIndex(indexOfTask);
            selectedTaskIndex = indexOfTask;
            DisplayTaskInfo(selectedTask);
        }

        private void FinishTask(object sender, int id)
        {
            
        }

        private void SelectTask(Task task)
        {
            SelectTask(this, task.Id);
        }

        private void FinishTask(Task task)
        {
            FinishTask(this, task.Id);
        }

        private List<Task> SortTasks(List<Task> tasksUnsorted)
        {
            return tasksUnsorted.OrderBy(t => t.DueDate).ToList();
        }

        private void SetStatus(String message, params object[] parameters)
        {
            //view.Status = String.Format(message, parameters);
        }

        #endregion
    }
}
