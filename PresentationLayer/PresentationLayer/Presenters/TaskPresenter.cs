using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DataAccessLayer.Model;
using DataAccessLayer.Repositories;
using PresentationLayer.Views;

namespace PresentationLayer.Presenters
{
    public class TaskPresenter
    {
        #region Private fields

        private readonly ITasksLayer view;
        private TasksRepository repository;
        private List<Task> tasks;
        private int selectedTaskIndex;
        private bool isNew = true;

        #endregion

        public TaskPresenter(ITasksLayer view)
        {
            this.view = view;
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
                tasks = SortTasksByDateAndPriority(tasks);

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

        private void ShowPrevious(object sender, EventArgs e)
        {
            if (selectedTaskIndex > 0)
            {
                selectedTaskIndex--;
                DisplayTaskInfo(GetTaskAtIndex(selectedTaskIndex));
                view.IsDirty = false;
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
                view.IsDirty = false;
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
            view.IsDirty = false;
            selectedTaskIndex = tasks.Count - 1;
            SetStatus("New task created");
        }

        private void Save(object sender, EventArgs e)
        {
            var task = isNew ? new Task() : GetSelectedTask();

            task.Name = view.TaskName;
            task.Description = view.TaskDescription;
            task.Priority = view.Priority;
            task.DueDate = view.DueDate;

            if (isNew)
            {
                task.CreationDate = DateTime.Now;
                repository.Add(task);
            }
            else
            {
                repository.Update(task);
            }

            isNew = false;
            view.IsDirty = false;
            SetStatus("Task saved");
            ObtainTasksList();
            RefreshTasksGridview();
            SelectTask(task);
        }

        private void Remove(object sender, EventArgs e)
        {
            if (isNew)
            {
                MessageBox.Show("This task is not saved yet, so it can't be deleted");
            }
            else
            {
                Task task = GetSelectedTask();
                if (task == null)
                {
                    MessageBox.Show("No task to remove");
                }

                repository.Delete(task);

                tasks = repository.GetAll().ToList();
                selectedTaskIndex = tasks.Count - 1;

                if (selectedTaskIndex > 0)
                {
                    DisplayTaskInfo(tasks[selectedTaskIndex]);
                    isNew = false;
                }
                else
                {
                    New(sender, e);
                    isNew = true;
                }

                RefreshTasksGridview();
                DisplayTaskInfo(task);
            }

        }

        private void Finish(object sender, EventArgs e)
        {
            var taskToFinish = GetSelectedTask();
            taskToFinish.IsFinished = true;
            taskToFinish.FinishedDate = DateTime.Now;
            repository.Update(taskToFinish);
            DisplayTaskInfo(taskToFinish);
        }
        #endregion

        #region Helper methods

        private void AttachEvents()
        {
            view.NewTask += New;
            view.SaveTask += Save;
            view.RemoveTask += Remove;
            view.FinishTask += Finish;
            view.PreviousTask += ShowPrevious;
            view.NextTask += ShowNext;
            view.SelectTask += SelectTask;
        }

        private void ObtainTasksList()
        {
            tasks = repository.HasTasks() ? repository.GetAll().ToList() : new List<Task>();
        }

        private void RefreshTasksGridview()
        {
            view.Tasks = tasks;
        }

        private void DisplayTasksList(List<Task> tasksList)
        {
            view.Tasks = SortTasksByDateAndPriority(tasksList);
        }

        private void DisplayBlankTask()
        {
            view.TaskName = "[Name something to be done]";
            view.Priority = 1;
            view.TaskDescription = "[Describe your task]";
            view.DueDate = DateTime.Now.AddDays(7);
            view.IsFinished = false;
            view.FinishDate = null;
        }

        private void DisplayTaskInfo(Task task)
        {
            view.TaskName = task.Name;
            view.TaskDescription = task.Description;
            view.Priority = task.Priority;
            view.DueDate = task.DueDate;
            view.IsFinished = task.IsFinished;
            view.FinishDate = task.FinishedDate;
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

        private void SelectTask(Task task)
        {
            SelectTask(this, task.Id);
        }

        private List<Task> SortTasksByDateAndPriority(List<Task> tasksUnsorted)
        {
            return tasksUnsorted.OrderBy(t => t.DueDate).OrderByDescending(t => t.Priority).ToList();
        }

        private void SetStatus(String message, params object[] parameters)
        {
            //view.Status = String.Format(message, parameters);
        }

        #endregion
    }
}
