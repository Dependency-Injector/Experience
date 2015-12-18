using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
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
    public class TaskPresenter : IPresenter
    {
        private readonly ITasksView view;
        private readonly ITasksRepository tasksRepository;
        private readonly IWorkUnitsRepository workUnitsRepository;
        private readonly ISkillsRepository skillsRepository;
        private readonly IProfileRepository profilesRepository;
        private readonly IHistoryService historyService;
        private readonly ITaskService tasksService;
        private readonly IProfileService profilesService;
        private readonly IWorkUnitsService workUnitsService;
        private readonly IImprovementsService improvementsService;

        private List<Task> tasks;
        private WorkUnit currentWorkUnit;
        private int selectedTaskIndex;
        private bool isTaskNew = true;
        private Profile currentUser;

        public TaskPresenter(ITasksView view, ITasksRepository tasksRepository, IWorkUnitsRepository workUnitsRepository, ISkillsRepository skillsRepository,
            IProfileRepository profilesRepository, IHistoryService historyService, ITaskService tasksService, IProfileService profilesService, IWorkUnitsService workUnitsService, IImprovementsService improvementsService)
        {
            this.view = view;

            this.tasksRepository = tasksRepository;
            this.workUnitsRepository = workUnitsRepository;
            this.skillsRepository = skillsRepository;
            this.profilesRepository = profilesRepository;
            this.tasksService = tasksService;
            this.historyService = historyService;
            this.profilesService = profilesService;
            this.workUnitsService = workUnitsService;
            this.improvementsService = improvementsService;
        }

        #region Events

        public void Initialize()
        {
            try
            {
                AttachEvents();
                GetAndDisplayTasks();
                SetDisplayMode(DisplayMode.View);
            }
            catch (Exception e)
            {
                Logger.Exception(e);
            }
        }

        public void OnViewDisplayed()
        {
            GetAndDisplayTasks();
        }

        private void ShowPrevious(object sender, EventArgs e)
        {
            if (selectedTaskIndex > 0)
            {
                selectedTaskIndex--;
                DisplayTaskDetails(GetTaskAtIndex(selectedTaskIndex));
                view.IsDirty = false;
            }
        }

        private void ShowNext(object sender, EventArgs e)
        {
            if (selectedTaskIndex + 1 < tasks.Count)
            {
                selectedTaskIndex++;
                DisplayTaskDetails(GetTaskAtIndex(selectedTaskIndex));
                view.IsDirty = false;
            }
        }

        private void New(object sender, EventArgs e)
        {
            DisplayBlankTaskDetails();
            isTaskNew = true;
            view.IsDirty = false;
            selectedTaskIndex = tasks.Count - 1;
            SetDisplayMode(DisplayMode.Edit);
        }

        private void Save(object sender, EventArgs e)
        {
            Task taskToSave = isTaskNew ? new Task() : GetSelectedTask();
            
            if (isTaskNew)
            {
                taskToSave = tasksService.CreateNewTask(currentUser.Id, view.TaskName, view.TaskDescription, view.DueDate.Value, view.Priority, view.ParentTaskId, view.SkillToTrainId, view.Difficulty);
                tasksService.SaveTask(taskToSave);

                //int xpForTaskCreation = tasksService.GetExperienceForCreation(taskToSave.Id);
                //Improvement improvement = improvementsService.CreateNewImprovement(currentUser.Id,
                //    ImprovementType.ExperienceGained, ImprovementOrigin.TaskCreation, xpForTaskCreation, taskToSave.Id);
                //improvementsService.SaveImprovement(improvement);
            }
            else
            {
                taskToSave = tasksService.UpdateExistingTask(taskToSave.Id, view.TaskName, view.TaskDescription, view.DueDate.Value, view.Priority, view.ParentTaskId, view.SkillToTrainId, view.Difficulty);
                tasksService.UpdateTask(taskToSave);
            }

            isTaskNew = false;
            view.IsDirty = false;
            
            GetAndDisplayTasks();
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
                DisplayTaskDetails(tasks[selectedTaskIndex]);
                isTaskNew = false;
            }
            else
            {
                New(sender, e);
                isTaskNew = true;
            }

            DisplayTasks(tasks);
            SetDisplayMode(DisplayMode.View);
        }
/*

        private void DevelopPlayerSkillByWorkingOnTask(WorkUnit workReported)
        {
            Task taskWorkedOn = tasksRepository.Get(workReported.Task.Id);

            // Check if any skill is attached to task
            if (taskWorkedOn.SkillToTrain != null && workReported.Duration.HasValue)
            {
                Skill skillToTrain = taskWorkedOn.SkillToTrain;

                // Give xp to skill
                int experienceForWorkUnit = (int)ExperienceDefaultValues.GetExperienceForWork(workReported.Duration.Value);
                profilesService.UserSkillGainedExperience(skillToTrain.Id, experienceForWorkUnit);
                historyService.AddHistoryEvent(HistoryEventType.SkillExperienceGained, skillToTrain.Id, experienceForWorkUnit);

                /#1#/ Check if skill leveled up
                if (skillToTrain.HasReachedNewLevel())
                {
                    // Give skill new level
                    int skillNewLevel = skillToTrain.GetNewLevel();
                    profilesService.UserSkillReachedNewLevel(skillToTrain.Id, skillNewLevel);
                    historyService.AddHistoryEvent(HistoryEventType.SkillLevelGained, skillToTrain.Id, newLevel: skillNewLevel);
                }#1#
            }
*/

        private void Finish(object sender, EventArgs e)
        {
            var taskToFinish = GetSelectedTask();
            int xpForTaskFinish = tasksService.GetExperienceForCompletion(taskToFinish.Id);

            // Finish task and save info about this
            tasksService.FinishTask(taskToFinish);
            historyService.AddHistoryEvent(HistoryEventType.TaskFinished, taskToFinish.Id, xpForTaskFinish);


            Improvement improvement = improvementsService.CreateNewImprovement(currentUser.Id, ImprovementType.ExperienceGained, ImprovementOrigin.TaskCompletion, xpForTaskFinish, taskToFinish.Id);
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
                            (int) ExperienceDefaultValues.GetExperienceForWork(workUnit.Duration.Value);
                    }

                    experienceForTask = experienceForWorkUnits;
                }
                else
                {
                    experienceForTask = xpForTaskFinish;
                }

                if (experienceForTask > 0)
                {
                    Improvement skillImprovement = improvementsService.CreateNewImprovement(currentUser.Id, ImprovementType.SkillExperienceGained, ImprovementOrigin.TaskCompletion, experienceForTask, taskToFinish.Id, taskToFinish.SkillToTrain.Id);
                    improvementsService.SaveImprovement(skillImprovement);
                    profilesService.UserSkillGainedExperience(taskToFinish.SkillToTrain.Id, experienceForTask);

                    if (taskToFinish.SkillToTrain.HasReachedNewLevel())
                    {
                        // Give skill new level
                        int skillNewLevel = taskToFinish.SkillToTrain.GetNewLevel();

                        Improvement skillLevelUpImprovement = improvementsService.CreateNewImprovement(currentUser.Id, ImprovementType.SkillLevelUp, ImprovementOrigin.TaskCompletion, skillNewLevel, taskToFinish.Id, taskToFinish.SkillToTrain.Id);
                        improvementsService.SaveImprovement(skillLevelUpImprovement);
                        profilesService.UserSkillReachedNewLevel(taskToFinish.SkillToTrain.Id, skillNewLevel);

                        historyService.AddHistoryEvent(HistoryEventType.SkillLevelGained, taskToFinish.SkillToTrain.Id, newLevel: skillNewLevel);
                    }
                }
            }
           // historyService.AddHistoryEvent(HistoryEventType.ExperienceGained, taskToFinish.Id, xpForTaskFinish);
/*
            Profile user = profilesRepository.Get(taskToFinish.Owner.Id);
            if (user.HasReachedNewLevel())
            {
                int newLevel = user.GetNewLevel();
                profilesService.UserReachedNewLevel(taskToFinish.Owner.Id, newLevel);
                historyService.AddHistoryEvent(HistoryEventType.LevelGained, taskToFinish.Owner.Id, "", levelGained: newLevel);
            }*/

            //ObtainAndDisplayTasks();
            GetAndDisplayTasks();
            DisplayTaskDetails(taskToFinish);
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

                workUnitsService.AddWorkUnit(currentWorkUnit);
                historyService.AddHistoryEvent(HistoryEventType.WorkStopped, currentWorkUnit.Id);

                currentWorkUnit = workUnitsRepository.Get(currentWorkUnit.Id);
                DevelopPlayerSkillByWorkingOnTask(currentWorkUnit);

                Task task = tasksRepository.Get(currentWorkUnit.Task.Id);
                DisplayWorkUnitsList(task.WorkUnits.ToList());
            }
        }

        private void StartWorkingOnTask(object sender, EventArgs e)
        {
            Task selectedTask = GetSelectedTask();
            currentWorkUnit = workUnitsService.CreateNewWorkUnit(selectedTask.Id, DateTime.Now);
            historyService.AddHistoryEvent(HistoryEventType.WorkStarted, currentWorkUnit.Id);
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

        private void ShowFinishedTasks(object sender, bool showFinishedTasks)
        {
            GetAndDisplayTasks(showFinishedTasks);
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

        private void GetAndDisplayTasks(bool includeFinishedTasks = false)
        {
            currentUser = profilesRepository.Get(ApplicationSettings.Current.CurrentUserId.Value);
            tasks = ObtainTasksList(includeFinishedTasks);
            tasks = SortTasks(tasks);

            if (tasks != null && tasks.Count > 0)
            {
                DisplayTaskDetails(tasks[0]);
                DisplayTasks(tasks);
                selectedTaskIndex = tasks.Count - 1;        // At start, select last task
            }
            else
            {
                DisplayBlankTaskDetails();
            }
        }
        
        private void DisplayTasks(List<Task> tasksList)
        {
            view.Tasks = tasksList.ToDictionary(k => k.Id, val => val.Name);
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
                    
                   
                    tasksGridItems.Add(new TaskGridItem(task.Id, name, deadlineLiteral, timeSpent, priority));
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
        
        private ICollection GetTasksRows(List<Task> tasksToGetRowsFrom)
        {
            List<string[]> taskRows = new List<string[]>();

            foreach (var task in tasksToGetRowsFrom)
            {
                if (task.DueDate.HasValue)
                {
                    int daysToDeadline = (int)(task.DueDate.Value.Date - DateTime.Now.Date).TotalDays;
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

                    //if (duration.TotalMinutes < 5)
                    //    continue;

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

        private ICollection GetChildrenTasksRows(ICollection<Task> childrenTasks)
        {
            List<string[]> childrenTasksRows = new List<string[]>();

            foreach (var childrenTask in childrenTasks)
            {
                string[] childrenTaskRow = new string[]
                {
                    $"{childrenTask.Name}",
                    $"{childrenTask.IsFinished}",
/*                    $"{durationLiteral}"*/
                };

                childrenTasksRows.Add(childrenTaskRow);
            }

            return childrenTasksRows;
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
            view.SelectedTaskIndex = selectedTaskIndex;

            DisplayTaskDetails(selectedTask);
        }

        private void SelectTask(Task task)
        {
            SelectTask(this, task.Id);
        }

        private void DisplayWorkUnitsList(List<WorkUnit> workUnits)
        {
            if (workUnits != null && workUnits.Count > 0)
            {
                view.WorkUnits = GetWorkUnitsRows(workUnits);
                view.WorkUnitsPanelVisible = true;
            }
            else
            {
                view.WorkUnitsPanelVisible = false;
            }
        }

        private void DisplayBlankTaskDetails()
        {
            view.TaskName = "[Name something to be done]";
            view.Priority = 1;
            view.TaskDescription = "[Describe your task]";
            view.MinDueDate = DateTime.Today;
            view.DueDate = DateTime.Now.AddDays(1);
            view.AssociatedSkillName = "-";
            view.TotalWorkload = "-";
            view.TotalExperienceGained = "-";
            view.IsFinished = false;
            view.ActionButtonsVisible = true;
            view.FinishDate = null;
            view.WorkUnits = null;
            view.SkillsAvailable = GetSkillsRows(skillsRepository.Find(s => s.Owner.Id == currentUser.Id).ToList());
            view.SkillToTrainId = null;
            view.ParentTaskId = null;
        }

        private void DisplayTaskDetails(Task task)
        {
            view.TaskName = task.Name;
            view.TaskDescription = task.Description;
            view.Priority = (int)task.Priority;
            view.Difficulty = (int) task.Difficulty;
            view.MinDueDate = task.DueDate.Value.Date;
            view.DueDate = task.DueDate;
            view.AssociatedSkillName = task.SkillToTrain != null ? task.SkillToTrain.Name : "-";
            view.TotalWorkload = task.WorkUnits != null ? task.GetTotalWorkloadLiteral() : "-";
            view.TotalExperienceGained = task.WorkUnits != null ? task.GetTotalExperienceGainedLiteral() : "-";
            view.ActionButtonsVisible = !task.IsFinished;
            view.FinishDate = task.FinishedDate;
            view.SkillsAvailable = GetSkillsRows(skillsRepository.Find(s => s.Owner.Id == currentUser.Id).ToList());
            view.SkillToTrainId = task.SkillToTrain?.Id;
            view.ParentTaskId = task.Parent?.Id;
            view.ParentTaskName = task.Parent != null ? task.Parent.Name : "-";
            view.CanBeFinished = tasksService.IsFinishingAllowed(task.Id);
            view.ChildrenTasks = GetChildrenTasksRows(task.Tasks);

            DisplayWorkUnitsList(task.WorkUnits.ToList());

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

        private void DevelopPlayerSkillByWorkingOnTask(WorkUnit workReported)
        {
            Task taskWorkedOn = tasksRepository.Get(workReported.Task.Id);

            // Check if any skill is attached to task
            if (taskWorkedOn.SkillToTrain != null && workReported.Duration.HasValue)
            {
                Skill skillToTrain = taskWorkedOn.SkillToTrain;

                // Give xp to skill
                int experienceForWorkUnit = (int)ExperienceDefaultValues.GetExperienceForWork(workReported.Duration.Value);
                profilesService.UserSkillGainedExperience(skillToTrain.Id, experienceForWorkUnit);
                historyService.AddHistoryEvent(HistoryEventType.SkillExperienceGained, skillToTrain.Id, experienceForWorkUnit);

                /*// Check if skill leveled up
                if (skillToTrain.HasReachedNewLevel())
                {
                    // Give skill new level
                    int skillNewLevel = skillToTrain.GetNewLevel();
                    profilesService.UserSkillReachedNewLevel(skillToTrain.Id, skillNewLevel);
                    historyService.AddHistoryEvent(HistoryEventType.SkillLevelGained, skillToTrain.Id, newLevel: skillNewLevel);
                }*/
            }

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
        
        #endregion
    }
}
