using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using BussinessLogicLayer.Interfaces;
using DataAccessLayer.Repositories.Interfaces;
using DataAccessLayer.Services.Interfaces;
using DataAccessLayer.Utilities;
using Model.Entities;
using Model.Enums;
using Utilities;

namespace BussinessLogicLayer.Presenters
{
    public class TaskPresenter
    {
        #region Private fields
        private readonly ITasksView view;
        private readonly ITasksRepository tasksRepository;
        private readonly IWorkUnitsRepository workUnitsRepository;
        private readonly ISkillsRepository skillsRepository;
        private readonly IProfileRepository profilesRepository;
        private readonly IHistoryService historyService;
        private readonly ITaskService taskService;
        private List<Task> tasks;
        private WorkUnit currentWorkUnit;
        private int selectedTaskIndex;
        private bool isTaskNew = true;
        private bool isPlayerCurrentlyWorking;
        private Profile currentUser;
        #endregion

        public TaskPresenter(ITasksView view, ITasksRepository tasksRepository, IWorkUnitsRepository workUnitsRepository, ISkillsRepository skillsRepository,
            IProfileRepository profileRepository, IHistoryService historyService, ITaskService tasksService)
        {
            this.view = view;

            this.tasksRepository = tasksRepository;
            this.workUnitsRepository = workUnitsRepository;
            this.skillsRepository = skillsRepository;
            this.profilesRepository = profileRepository;
            this.taskService = tasksService;
            this.historyService = historyService;

            Initialize();
        }

        #region Events

        private void Initialize()
        {
            try
            {
                if (ApplicationSettings.Current.IsAnyUserLoggedIn)
                {
                    currentUser = profilesRepository.Get(ApplicationSettings.Current.CurrentUserId.Value);

                    AttachEvents();
                    tasks = ObtainTasksList();
                    tasks = SortTasks(tasks);

                    if (tasks != null && tasks.Count > 0)
                    {
                        DisplaySingleTaskInfoForUser(tasks[0], currentUser.Id);
                        DisplayTasksList(tasks);
                        selectedTaskIndex = tasks.Count - 1;
                    }
                    else
                    {
                        DisplayBlankTaskForUser(currentUser.Id);
                    }

                    SetDisplayMode(DisplayMode.View);
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
                DisplaySingleTaskInfoForUser(GetTaskAtIndex(selectedTaskIndex), currentUser.Id);
                view.IsDirty = false;
            }
        }

        private void ShowNext(object sender, EventArgs e)
        {
            if (selectedTaskIndex + 1 < tasks.Count)
            {
                selectedTaskIndex++;
                DisplaySingleTaskInfoForUser(GetTaskAtIndex(selectedTaskIndex), currentUser.Id);
                view.IsDirty = false;
            }
        }

        private void New(object sender, EventArgs e)
        {
            DisplayBlankTaskForUser(currentUser.Id);
            isTaskNew = true;
            view.IsDirty = false;
            selectedTaskIndex = tasks.Count - 1;
            SetDisplayMode(DisplayMode.Edit);
        }

        private void Save(object sender, EventArgs e)
        {
            Task taskToSave = isTaskNew ? new Task() : GetSelectedTask();
            Profile currentUser = profilesRepository.Get(ApplicationSettings.Current.CurrentUserId.Value);

            if (isTaskNew)
            {
                taskToSave = taskService.CreateNewTask(currentUser.Id, view.TaskName, view.TaskDescription, view.DueDate.Value, view.Priority, view.ParentTaskId, view.SkillToTrainId);
                taskService.SaveTask(taskToSave);
            }
            else
            {
                taskToSave = taskService.UpdateExistingTask(taskToSave.Id, view.TaskName, view.TaskDescription, view.DueDate.Value, view.Priority, view.ParentTaskId, view.SkillToTrainId);
                taskService.UpdateTask(taskToSave);
            }

            isTaskNew = false;
            view.IsDirty = false;

            tasks = ObtainTasksList();
            tasks = SortTasks(tasks);
            DisplayTasksList(tasks);
            SelectTask(taskToSave);
            SetDisplayMode(DisplayMode.View);
        }

        private void Edit(object sender, EventArgs e)
        {
            SetDisplayMode(DisplayMode.Edit);
        }

        private void CancelTaskEditing(object sender, EventArgs e)
        {
            SetDisplayMode(DisplayMode.View);
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

            tasksRepository.Delete(task);

            historyService.AddHistoryEvent(HistoryEventType.TaskRemoved, task.Id);

            tasks = ObtainTasksList();
            tasks = SortTasks(tasks);
            selectedTaskIndex = tasks.Count - 1;

            if (selectedTaskIndex > 0)
            {
                DisplaySingleTaskInfoForUser(tasks[selectedTaskIndex], currentUser.Id);
                isTaskNew = false;
            }
            else
            {
                New(sender, e);
                isTaskNew = true;
            }

            DisplayTasksList(tasks);
            SetDisplayMode(DisplayMode.View);
        }

        private void Finish(object sender, EventArgs e)
        {
            var taskToFinish = GetSelectedTask();
            taskService.FinishTask(taskToFinish);

            int xpForTaskFinish = ExperienceDefaultValues.GetExperienceForTask(taskToFinish.Priority);
            SkillTrainer.GiveXp(xpForTaskFinish);
            historyService.AddHistoryEvent(HistoryEventType.TaskFinished, taskToFinish.Id, xpForTaskFinish);

            DisplaySingleTaskInfoForUser(taskToFinish, currentUser.Id);
            DisplayTasksList(tasks);
            SetDisplayMode(DisplayMode.View);
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
                
                Task task = tasksRepository.Get(currentWorkUnit.Task.Id);
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
            view.EditTask += Edit;
            view.CancelTaskEditing += CancelTaskEditing;
            view.RemoveTask += Remove;
            view.FinishTask += Finish;
            view.PreviousTask += ShowPrevious;
            view.NextTask += ShowNext;
            view.SelectTask += SelectTask;
            view.StartWorkingOnTask += StartWorkingOnTask;
            view.StopWorkingOnTask += StopWorkingOnTask;
            view.ShowFinishedTasks += ShowFinishedTasks;
            view.ParentTaskChanged += ParentTaskChanged;
        }

        private void ParentTaskChanged(object sender, EventArgs e)
        {
            // Change task max due date when it exceeds parent task due date
            if (view.ParentTaskId.HasValue)
            {
                Task parentTask = tasksRepository.Get(view.ParentTaskId.Value);
                if (parentTask != null)
                {
                    if (view.DueDate > parentTask.DueDate)
                    {
                        view.DueDate = parentTask.DueDate;
                    }
                }
            }
        }

        private void ShowFinishedTasks(object sender, bool e)
        {
            // TODO
        }

        private List<Task> ObtainTasksList()
        {
            return tasksRepository.HasTasks() && ApplicationSettings.Current.IsAnyUserLoggedIn ? tasksRepository.Find(t => t.Owner.Id == ApplicationSettings.Current.CurrentUserId).ToList() : new List<Task>();
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

                    String name = String.Empty;
                    if (task.Parent != null)
                        name = GetTaskNameForNestedTask(task);
                    else
                        name = task.Name;

                    string[] taskRow = new string[]
                    {
                        $"{task.Id}",
                        $"{name}",
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

        private string GetTaskNameForNestedTask(Task taskWithParent)
        {
            String name = taskWithParent.Name;
            Task tempTask = taskWithParent;
            while (tempTask.Parent != null)
            {
                name = "   " + name;
                tempTask = tempTask.Parent;
            }
            return name;
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
            DisplaySingleTaskInfoForUser(selectedTask, currentUser.Id);
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

        private void DisplayBlankTaskForUser(int userId)
        {
            view.TaskName = "[Name something to be done]";
            view.Priority = 1;
            view.TaskDescription = "[Describe your task]";
            view.DueDate = DateTime.Now.AddDays(1);
            view.AssociatedSkillName = "-";
            view.TotalWorkload = "-";
            view.TotalExperienceGained = "-";
            view.IsFinished = false;
            view.ActionButtonsVisible = true;
            view.FinishDate = null;
            view.WorkUnits = null;
            view.SkillsAvailable = GetSkillsRows(skillsRepository.Find(s => s.Owner.Id == userId).ToList());
            view.SkillToTrainId = null;
            view.ParentTaskId = null;
        }

        private void DisplaySingleTaskInfoForUser(Task task, int userId)
        {
            view.TaskName = task.Name;
            view.TaskDescription = task.Description;
            view.Priority = (int)task.Priority;
            view.DueDate = task.DueDate;
            view.AssociatedSkillName = task.SkillToTrain != null ? task.SkillToTrain.Name : "-";
            view.TotalWorkload = task.WorkUnits != null ? task.GetTotalWorkloadLiteral() : "-";
            view.TotalExperienceGained = task.WorkUnits != null ? task.GetTotalExperienceGained() : "-";
            //view.IsFinished = task.IsFinished;
            view.ActionButtonsVisible = !task.IsFinished;
            view.FinishDate = task.FinishedDate;
            view.WorkUnits = GetWorkUnitsRows(task.WorkUnits.ToList());
            view.SkillsAvailable = GetSkillsRows(skillsRepository.Find(s => s.Owner.Id == userId).ToList());
            view.SkillToTrainId = task.SkillToTrain?.Id;
            view.ParentTaskId = task.Parent?.Id;
            view.CanBeFinished = taskService.IsFinishingAllowed(task.Id);
            
            isTaskNew = false;
        }

        private void SetDisplayMode(DisplayMode displayMode)
        {
            if (displayMode == DisplayMode.Edit)
            {
                view.TaskDetailsPanelVisible = false;
                view.TaskEditPanelVisible = true;
                view.TaskListEnabled = false;
            }
            else if (displayMode == DisplayMode.View)
            {
                view.TaskDetailsPanelVisible = true;
                view.TaskEditPanelVisible = false;
                view.TaskListEnabled = true;
            }
        }

        #endregion
    }
}
