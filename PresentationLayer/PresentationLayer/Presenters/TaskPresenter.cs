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

        private readonly ITasksView view;
        private TasksRepository taskRepository;
        private WorkUnitsRepository workUnitsRepository;
        private List<Task> tasks;
        private WorkUnit currentWorkUnit;
        private int selectedTaskIndex;
        private bool isTaskNew = true;

        #endregion

        public TaskPresenter(ITasksView view)
        {
            this.view = view;
            taskRepository = new TasksRepository();
            workUnitsRepository = new WorkUnitsRepository();

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
                    DisplaySingleTaskInfo(tasks[0]);
                    DisplayTasksList(tasks);
                    selectedTaskIndex = tasks.Count - 1;
                }
                else
                {
                    DisplayBlankTask();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ShowPrevious(object sender, EventArgs e)
        {
            if (selectedTaskIndex > 0)
            {
                selectedTaskIndex--;
                DisplaySingleTaskInfo(GetTaskAtIndex(selectedTaskIndex));
                view.IsDirty = false;
            }
        }

        private void ShowNext(object sender, EventArgs e)
        {
            if (selectedTaskIndex + 1 < tasks.Count)
            {
                selectedTaskIndex++;
                DisplaySingleTaskInfo(GetTaskAtIndex(selectedTaskIndex));
                view.IsDirty = false;
            }
        }

        private void New(object sender, EventArgs e)
        {
            DisplayBlankTask();
            isTaskNew = true;
            view.IsDirty = false;
            selectedTaskIndex = tasks.Count - 1;
        }

        private void Save(object sender, EventArgs e)
        {
            var task = isTaskNew ? new Task() : GetSelectedTask();

            task.Name = view.TaskName;
            task.Description = view.TaskDescription;
            task.Priority = view.Priority;
            task.DueDate = view.DueDate;

            if (isTaskNew)
            {
                task.CreationDate = DateTime.Now;
                taskRepository.Add(task);
            }
            else
            {
                taskRepository.Update(task);
            }

            isTaskNew = false;
            view.IsDirty = false;
            ObtainTasksList();
            RefreshTasksGridview();
            SelectTask(task);
        }

        private void Remove(object sender, EventArgs e)
        {
            if (isTaskNew)
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

                taskRepository.Delete(task);

                tasks = taskRepository.GetAll().ToList();
                selectedTaskIndex = tasks.Count - 1;

                if (selectedTaskIndex > 0)
                {
                    DisplaySingleTaskInfo(tasks[selectedTaskIndex]);
                    isTaskNew = false;
                }
                else
                {
                    New(sender, e);
                    isTaskNew = true;
                }

                RefreshTasksGridview();
                DisplaySingleTaskInfo(task);
            }

        }

        private void Finish(object sender, EventArgs e)
        {
            var taskToFinish = GetSelectedTask();
            taskToFinish.IsFinished = true;
            taskToFinish.FinishedDate = DateTime.Now;
            taskRepository.Update(taskToFinish);
            DisplaySingleTaskInfo(taskToFinish);
        }

        private void StopWorkingOnTask(object sender, EventArgs e)
        {
            if (currentWorkUnit != null)
            {
                currentWorkUnit.EndTime = DateTime.Now;

                if (currentWorkUnit.StartTime.HasValue)
                {
                    TimeSpan workingTime = currentWorkUnit.EndTime.Value - currentWorkUnit.StartTime.Value;
                    currentWorkUnit.Duration = Convert.ToInt16(workingTime.TotalSeconds);
                }

                workUnitsRepository.Add(currentWorkUnit);

                RefreshWorkUnitsGridView();
            }
        }

        private void StartWorkingOnTask(object sender, EventArgs e)
        {
            currentWorkUnit = new WorkUnit
            {
                StartTime = DateTime.Now,
                Task = GetSelectedTask()
            };
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
            view.StartWorkingOnTask += StartWorkingOnTask;
            view.StopWorkingOnTask += StopWorkingOnTask;
        }

        private void ObtainTasksList()
        {
            tasks = taskRepository.HasTasks() ? taskRepository.GetAll().ToList() : new List<Task>();
        }

        private void RefreshTasksGridview()
        {
            view.Tasks = tasks;
        }

        private void RefreshWorkUnitsGridView()
        {
            view.WorkUnits = GetSelectedTask().WorkUnits.ToList();
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

        private void DisplaySingleTaskInfo(Task task)
        {
            view.TaskName = task.Name;
            view.TaskDescription = task.Description;
            view.Priority = task.Priority;
            view.DueDate = task.DueDate;
            view.IsFinished = task.IsFinished;
            view.FinishDate = task.FinishedDate;
            view.WorkUnits = task.WorkUnits.ToList();
            isTaskNew = false;
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
            DisplaySingleTaskInfo(selectedTask);
        }

        private void SelectTask(Task task)
        {
            SelectTask(this, task.Id);
        }

        private List<Task> SortTasksByDateAndPriority(List<Task> tasksUnsorted)
        {
            return tasksUnsorted.OrderBy(t => t.DueDate).ThenByDescending(t => t.IsFinished).ThenByDescending(t => t.Priority).ToList();
        }

        #endregion
    }
}
