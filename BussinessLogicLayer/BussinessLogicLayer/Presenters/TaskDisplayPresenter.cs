using System;
using System.Collections;
using System.Collections.Generic;
using BussinessLogicLayer.Interfaces;
using DataAccessLayer.Repositories.Interfaces;
using DataAccessLayer.Utilities;
using Model.Entities;
using Task = Model.Entities.Task;

namespace BussinessLogicLayer.Presenters
{
    public class TaskDisplayPresenter
    {
        private readonly ITaskDisplayView view;
        private readonly ITasksRepository tasksRepository;
        
        private Task task;

        public TaskDisplayPresenter(ITaskDisplayView view, ITasksRepository tasksRepository)
        {
            this.view = view;
            this.tasksRepository = tasksRepository;
        }

        public void Initialize()
        {
            try
            {
                /*int taskId = 7001;
                task = tasksRepository.Get(taskId);

                if(task != null)
                    DisplayTaskDetails(task);*/
            }
            catch (Exception ex)
            {
                Logger.Exception(ex);
            }
        }

        public void DisplayTaskDetails(Task task)
        {
            view.TaskName = task.Name;
            view.TaskDescription = task.Description;
            view.Deadline = task.DueDate.Value;
            view.AssociatedSkillName = task.SkillToTrain != null ? task.SkillToTrain.Name : "-";
            view.ParentTaskName = task.Parent != null ? task.Parent.Name : "-";
            view.ChildrenTasks = GetChildrenTasksRows(task.Tasks);
            view.Priority = task.GetPriorityLiteral();
            
            /*view.Priority = (int)task.Priority;
            view.Difficulty = (int)task.Difficulty;
            view.MinDueDate = task.DueDate.Value.Date;
            view.DueDate = task.DueDate;*/
            //view.TotalWorkload = task.WorkUnits != null ? task.GetTotalWorkloadLiteral() : "-";
            //view.TotalExperienceGained = task.WorkUnits != null ? task.GetTotalExperienceGainedLiteral() : "-";
            //view.ActionButtonsVisible = !task.IsFinished;
            view.FinishDate = task.FinishedDate;
            /*view.SkillsAvailable = GetSkillsRows(skillsRepository.Find(s => s.Owner.Id == Globals.DmitruUserId).ToList());
            view.SkillToTrainId = task.SkillToTrain?.Id;
            view.ParentTaskId = task.Parent?.Id;*/
            //view.CanBeFinished = tasksService.IsFinishingAllowed(task.Id);
            //view.IsVisible = true;
            //DisplayWorkUnitsList(task.WorkUnits.ToList());
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

        public void HideView()
        {
            view.IsVisible = false;
        }

        public void ShowView()
        {
            view.IsVisible = true;
        }

        internal void DisplayTaskDetails(int id)
        {
            task = tasksRepository.Get(id);
            DisplayTaskDetails(task);
        }
    }
}
