﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using BussinessLogicLayer.Interfaces;
using DataAccessLayer;
using DataAccessLayer.Repositories;
using DataAccessLayer.Services;
using DataAccessLayer.Utilities;
using Model.Entities;
using Model.Enums;

namespace BussinessLogicLayer.Presenters
{
    public class TaskPresenter
    {
        #region Private fields
        private readonly ITasksView view;
        private readonly TasksRepository taskRepository;
        private readonly TaskService taskService;
        private readonly WorkUnitsRepository workUnitsRepository;
        private readonly SkillsRepository skillsRepository;
        private readonly HistoryService historyService;
        private readonly ProfileRepository profilesRepository;
        private List<Task> tasks;
        private WorkUnit currentWorkUnit;
        private int selectedTaskIndex;
        private bool isTaskNew = true;
        private bool isPlayerCurrentlyWorking;
        #endregion

        public TaskPresenter(ITasksView view)
        {
            this.view = view;

            taskRepository = new TasksRepository();
            workUnitsRepository = new WorkUnitsRepository();
            skillsRepository = new SkillsRepository();
            profilesRepository = new ProfileRepository();
            taskService = new TaskService();
            historyService = new HistoryService();

            Initialize();
        }

        #region Events

        private void Initialize()
        {
            try
            {
                AttachEvents();
                tasks = ObtainTasksList();
                tasks = SortTasks(tasks);

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
            catch (Exception e)
            {
                Logger.Exception(e);
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
            Task taskToSave = isTaskNew ? new Task() : GetSelectedTask();
            Profile currentUser = profilesRepository.Get(Properties.Settings.Default.CurrentlyLoggedPlayerId);

            if (isTaskNew)
            {
                taskToSave = taskService.CreateNewTask(currentUser.Id, view.TaskName, view.TaskDescription, view.DueDate.Value, view.Priority, view.ParentTaskId, view.SkillToTrainId);
                taskToSave.Owner = currentUser;
                taskService.SaveTask(taskToSave);
            }
            else
            {
                taskToSave = taskService.UpdateExistingTask(taskToSave.Id, view.TaskName, view.TaskDescription, view.DueDate.Value, view.Priority, view.ParentTaskId, view.SkillToTrainId);
                taskRepository.Update(taskToSave);
                historyService.AddHistoryEvent(HistoryEventType.TaskEdited, taskToSave.Id);
            }

            isTaskNew = false;
            view.IsDirty = false;

            tasks = ObtainTasksList();
            tasks = SortTasks(tasks);
            DisplayTasksList(tasks);
            SelectTask(taskToSave);
        }

        private void Remove(object sender, EventArgs e)
        {
            if (isTaskNew)
            {
                //MessageBox.Show("This task is not saved yet, so it can't be deleted");
                return;
            }

            Task task = GetSelectedTask();
            if (task == null)
            {
                // MessageBox.Show("No task to remove");
                return;
            }
            else
            {
                // DialogResult taskDeleteConfirmation = MessageBox.Show("Delete task '{0}'?", "Confirm deletion", MessageBoxButtons.YesNo);
                //if (taskDeleteConfirmation == DialogResult.No)
                //     return;
            }

            taskRepository.Delete(task);

            historyService.AddHistoryEvent(HistoryEventType.TaskRemoved, task.Id);

            tasks = ObtainTasksList();
            tasks = SortTasks(tasks);
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

            DisplayTasksList(tasks);
        }

        private void Finish(object sender, EventArgs e)
        {
            var taskToFinish = GetSelectedTask();
            taskService.FinishTask(taskToFinish);

            int xpForTaskFinish = ExperienceDefaultValues.GetExperienceForTask(taskToFinish.Priority);
            SkillTrainer.GiveXp(xpForTaskFinish);
            historyService.AddHistoryEvent(HistoryEventType.TaskFinished, taskToFinish.Id, xpForTaskFinish);

            DisplaySingleTaskInfo(taskToFinish);
            DisplayTasksList(tasks);
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
                historyService.AddHistoryEvent(HistoryEventType.WorkStopped, currentWorkUnit.Id);
                
                Task task = taskRepository.Get(currentWorkUnit.Task.Id);
                taskService.WorkedOnTask(task, currentWorkUnit);
                
                DisplayWorkUnitsList(task.WorkUnits.ToList());
            }
        }

        private void StartWorkingOnTask(object sender, EventArgs e)
        {
            currentWorkUnit = new WorkUnit
            {
                StartTime = DateTime.Now,
                Task = GetSelectedTask()
            };

            historyService.AddHistoryEvent(HistoryEventType.WorkStarted, currentWorkUnit.Id);
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
            view.ShowFinishedTasks += ShowFinishedTasks;
        }

        private void ShowFinishedTasks(object sender, bool e)
        {
            // TODO
        }

        private List<Task> ObtainTasksList()
        {
            return taskRepository.HasTasks() ? taskRepository.Find(t => t.Owner.Id == Properties.Settings.Default.CurrentlyLoggedPlayerId).ToList() : new List<Task>();
        }

        private ICollection GetTasksRows(List<Task> tasksToGetRowsFrom)
        {
            List<string[]> taskRows = new List<string[]>();

            foreach (var task in tasksToGetRowsFrom)
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

                    string[] taskRow = new string[]
                    {
                        $"{task.Id}",
                        $"{task.Name}",
                        $"{deadlineLiteral}",
                        $"{timeSpent}",
                        $"{priority}",
                        $"{task.IsFinished}"
                    };

                    taskRows.Add(taskRow);
                }
            }

            return taskRows;
        }

        private ICollection GetWorkUnitsRows(List<WorkUnit> unitsOfWork)
        {
            List<string[]> workUnitsRows = new List<string[]>();

            foreach (var unitOfWork in unitsOfWork)
            {
                if (unitOfWork.StartTime.HasValue && unitOfWork.EndTime.HasValue)
                {
                    String startDate = unitOfWork.StartTime.Value.ToString("dddd, d MMMM HH:mm");
                    String endDate = unitOfWork.EndTime.Value.ToString("dddd, d MMMM HH:mm");
                    TimeSpan duration = new TimeSpan(0, 0, 0, unitOfWork.Duration.Value);

                    if (duration.TotalMinutes < 5)
                        continue;

                    String durationLiteral;
                    if (duration.TotalHours < 1)
                        durationLiteral = $"{duration.Minutes}m";
                    else
                        durationLiteral = $"{duration.Hours}h {duration.Minutes}min";

                    string[] taskRow = new string[]
                    {
                        $"{startDate}",
                        $"{endDate}",
                        $"{durationLiteral}"
                    };

                    workUnitsRows.Add(taskRow);
                }
            }

            return workUnitsRows;
        }

        private ICollection GetSkillsRows(List<Skill> skills)
        {
            List<string[]> skillsRows = new List<string[]>();

            foreach (var skill in skills)
            {
                string[] skillRow = new string[]
                {
                    $"{skill.Id}",
                    $"{skill.Name}"
                };

                skillsRows.Add(skillRow);
            }

            return skillsRows;
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

        private List<Task> SortTasks(List<Task> tasksUnsorted)
        {
            return
                tasksUnsorted.Where(t => t.IsFinished == false)
                    .OrderBy(t => t.DueDate.Value.Date)
                    .ThenByDescending(t => t.Priority)
                    .ToList();
        }

        private void DisplayWorkUnitsList(List<WorkUnit> workUnits)
        {
            view.WorkUnits = GetWorkUnitsRows(workUnits);
        }

        private void DisplayTasksList(List<Task> tasksList)
        {
            view.Tasks = GetTasksRows(tasksList);
        }

        private void DisplayBlankTask()
        {
            view.TaskName = "[Name something to be done]";
            view.Priority = 1;
            view.TaskDescription = "[Describe your task]";
            view.DueDate = DateTime.Now.AddDays(1);
            view.AssociatedSkillName = "-";
            view.TotalWorkload = "-";
            view.TotalExperienceGained = "-";
            view.IsFinished = false;
            view.FinishDate = null;
            view.WorkUnits = null;
            view.SkillsAvailable = GetSkillsRows(skillsRepository.GetAll().ToList());
            view.SkillToTrainId = null;
            view.ParentTaskId = null;
        }

        private void DisplaySingleTaskInfo(Task task)
        {
            view.TaskName = task.Name;
            view.TaskDescription = task.Description;
            view.Priority = (int)task.Priority;
            view.DueDate = task.DueDate;
            view.AssociatedSkillName = task.SkillToTrain != null ? task.SkillToTrain.Name : "-";
            view.TotalWorkload = task.WorkUnits != null ? task.GetTotalWorkloadLiteral() : "-";
            view.TotalExperienceGained = task.WorkUnits != null ? task.GetTotalExperienceGained() : "-";
            view.IsFinished = task.IsFinished;
            view.FinishDate = task.FinishedDate;
            view.WorkUnits = GetWorkUnitsRows(task.WorkUnits.ToList());
            view.SkillsAvailable = GetSkillsRows(skillsRepository.GetAll().ToList());
            view.SkillToTrainId = task.SkillToTrain?.Id;
            view.ParentTaskId = task.Parent?.Id;
            view.CanBeFinished = taskService.IsFinishingAllowed(task.Id);
            isTaskNew = false;
        }

        #endregion
    }
}
