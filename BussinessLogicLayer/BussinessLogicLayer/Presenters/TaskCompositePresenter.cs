using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using BussinessLogicLayer.Enums;
using BussinessLogicLayer.Events;
using BussinessLogicLayer.Interfaces;
using DataAccessLayer.Repositories.Interfaces;
using DataAccessLayer.Services.Interfaces;
using DataAccessLayer.Utilities;
using Model.Entities;
using Model.Enums;
using Utilities;
using Task = Model.Entities.Task;

namespace BussinessLogicLayer.Presenters
{
    public class TaskCompositePresenter : ICanHandle<OpenTaskCompositeWindow>
    {
        private readonly ITaskEditView editView;
        private readonly ITaskDisplayView displayView;

        private TaskDisplayPresenter taskDisplayPresenter;
        private TaskEditPresenter taskEditPresenter;

        private readonly ITasksRepository tasksRepository;
       
        private readonly IPublisher publisher;
        private readonly ISubscriber subscriber;

        private bool isTaskNew = true;
        private Task task;
        private int taskId = 0;
        private WorkUnit currentWorkUnit;

        public TaskCompositePresenter(ITaskDisplayView displayView, ITaskEditView editView, ITasksRepository tasksRepository,
            IPublisher publisher, ISubscriber subscriber, TaskDisplayPresenter taskDisplayPresenter, TaskEditPresenter taskEditPresenter)
        {
            this.displayView = displayView;
            this.editView = editView;

            this.tasksRepository = tasksRepository;

            this.publisher = publisher;
            this.subscriber = subscriber;

            this.taskDisplayPresenter = taskDisplayPresenter;
            this.taskEditPresenter = taskEditPresenter;
        }

        public void Initialize()
        {
            try
            {
                subscriber.Subscribe(this);
                AttachEvents();

                taskDisplayPresenter.Initialize();
                taskEditPresenter.Initialize();

                SetDisplayMode(DisplayMode.View);
            }
            catch (Exception ex)
            {
                Logger.Exception(ex);
            }
        }

        private void AttachEvents()
        {
            this.displayView.EditTask += EditTask;
            this.editView.CancelTaskEditing += CancelTaskEditing;
        }

        private void EditTask(object sender, EventArgs e)
        {
            SetDisplayMode(DisplayMode.Edit);
        }

        private void CancelTaskEditing(object sender, EventArgs e)
        {
            SetDisplayMode(DisplayMode.View);
        }
        
/*

        private void CloseViewEditWindow(object sender, EventArgs e)
        {
            //SetDisplayMode(DisplayMode.View);

            publisher.Publish(new WindowClosed(WindowType.TaskViewEdit));
        }

        private void Remove(object sender, EventArgs e)
        {
            if (isTaskNew)
            {
                //MessageBox.Show("This task is not saved yet, so it can't be deleted");
                return;
            }


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
            //historyService.AddHistoryEvent(HistoryEventType.TaskRemoved, task.Id);

            //view.IsVisible = false;
        }

*/


        /*private void Save(object sender, EventArgs e)
        {
            Task taskToSave = isTaskNew ? new Task() : task;

            if (isTaskNew)
            {
                taskToSave = tasksService.CreateNewTask(Globals.DmitruUserId, view.TaskName, view.TaskDescription, view.DueDate.Value, view.Priority, view.ParentTaskId, view.SkillToTrainId, view.Difficulty);
                tasksService.SaveTask(taskToSave);
            }
            else
            {
                taskToSave = tasksService.UpdateExistingTask(taskToSave.Id, view.TaskName, view.TaskDescription, view.DueDate.Value, view.Priority, view.ParentTaskId, view.SkillToTrainId, view.Difficulty);
                tasksService.UpdateTask(taskToSave);
            }

            isTaskNew = false;
            view.IsDirty = false;

            SetDisplayMode(DisplayMode.View);
        }

        private void New(object sender, EventArgs e)
        {
            publisher.Publish(new OpenTaskDetailsWindow(DisplayMode.Edit, null));

            /*DisplayBlankTaskDetails();
            isTaskNew = true;
            view.IsDirty = false;
            selectedTaskIndex = tasks.Count - 1;
            SetDisplayMode(DisplayMode.Edit);#1#
        }

        private void Finish(object sender, EventArgs e)
        {
            var taskToFinish = task;
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

            this.view.IsVisible = false;
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

        private void StartWorkingOnTask(object sender, EventArgs e)
        {
            Task selectedTask = task;
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

        private void View_SaveTask(object sender, EventArgs e)
        {
            //Task taskToSave = isTaskNew ? new Task() : GetSelectedTask();

            Task taskToSave = task;

            if (isTaskNew)
            {
                taskToSave = tasksService.CreateNewTask(Globals.DmitruUserId, view.TaskName, view.TaskDescription, view.DueDate.Value, view.Priority, view.ParentTaskId, view.SkillToTrainId, view.Difficulty);
                tasksService.SaveTask(taskToSave);
            }
            else
            {
                taskToSave = tasksService.UpdateExistingTask(taskToSave.Id, view.TaskName, view.TaskDescription, view.DueDate.Value, view.Priority, view.ParentTaskId, view.SkillToTrainId, view.Difficulty);
                tasksService.UpdateTask(taskToSave);
            }

            isTaskNew = false;
            view.IsVisible = false;
        }

        public void OnViewDisplayed()
        {
        }

        public void EditTask(int taskId)
        {
            task = tasksRepository.Get(taskId);
            if (task != null)
            {
                isTaskNew = false;
            }
            else
            {
                isTaskNew = true;
                task = new Task();
            }

            DisplayTaskDetails(task);
        }

        private void DisplayBlankTaskDetails()
        {
            view.TaskName = "[Name something to be done]";
            view.Priority = 2;
            view.Difficulty = 2;
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
            view.SkillsAvailable = GetSkillsRows(skillsRepository.Find(s => s.Owner.Id == Globals.DmitruUserId).ToList());
            view.SkillToTrainId = null;
            view.ParentTaskId = null;
        }

        private void DisplayTaskDetails(Task task)
        {
            view.Title = task.Name;
            view.TaskDescription = task.Description;
            view.Priority = (int)task.Priority;
            view.Difficulty = (int)task.Difficulty;
            view.MinDueDate = task.DueDate.Value.Date;
            view.DueDate = task.DueDate;
            view.AssociatedSkillName = task.SkillToTrain != null ? task.SkillToTrain.Name : "-";
            view.TotalWorkload = task.WorkUnits != null ? task.GetTotalWorkloadLiteral() : "-";
            view.TotalExperienceGained = task.WorkUnits != null ? task.GetTotalExperienceGainedLiteral() : "-";
            view.ActionButtonsVisible = !task.IsFinished;
            view.FinishDate = task.FinishedDate;
            view.SkillsAvailable = GetSkillsRows(skillsRepository.Find(s => s.Owner.Id == Globals.DmitruUserId).ToList());
            view.SkillToTrainId = task.SkillToTrain?.Id;
            view.ParentTaskId = task.Parent?.Id;
            view.ParentTaskName = task.Parent != null ? task.Parent.Name : "-";
            view.CanBeFinished = tasksService.IsFinishingAllowed(task.Id);
            view.ChildrenTasks = GetChildrenTasksRows(task.Tasks);
            view.IsVisible = true;

            DisplayWorkUnitsList(task.WorkUnits.ToList());
        }*/

        private void SetDisplayMode(DisplayMode displayMode)
        {
            if (displayMode == DisplayMode.Edit)
            {
                taskDisplayPresenter.HideView();
                taskEditPresenter.ShowView();
            }
            else if (displayMode == DisplayMode.View)
            {

                taskDisplayPresenter.ShowView();
                taskEditPresenter.HideView();
            }
        }

        private void DevelopPlayerSkillByWorkingOnTask(WorkUnit workReported)
        {
            Task taskWorkedOn = tasksRepository.Get(workReported.Task.Id);

            // Check if any skill is attached to task
            if (taskWorkedOn.SkillToTrain != null && workReported.Duration.HasValue)
            {
                Skill skillToTrain = taskWorkedOn.SkillToTrain;

                // Give xp to skill TODO
                int experienceForWorkUnit = (int)ExperienceDefaultValues.GetExperienceForWork(workReported.Duration.Value);
                //profilesService.UserSkillGainedExperience(skillToTrain.Id, experienceForWorkUnit);
                //historyService.AddHistoryEvent(HistoryEventType.SkillExperienceGained, skillToTrain.Id, experienceForWorkUnit);

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

        public void Handle(OpenTaskCompositeWindow eventData)
        {
            if (eventData.EntityId.HasValue)
            {
                taskId = eventData.EntityId.Value;
                taskDisplayPresenter.DisplayTaskDetails(taskId);
                taskEditPresenter.EditTask(taskId);
            }
            else if (!eventData.EntityId.HasValue)
            {
                taskEditPresenter.NewTask();
            }

            SetDisplayMode(eventData.DisplayMode);
        }
    }
}
