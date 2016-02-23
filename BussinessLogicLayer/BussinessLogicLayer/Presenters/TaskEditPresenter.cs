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
using Task = Model.Entities.Task;

namespace BussinessLogicLayer.Presenters
{
    public class TaskEditPresenter
    {
        private readonly ITaskEditView view;

        private readonly ITasksRepository tasksRepository;
        private readonly ISkillsRepository skillsRepository;
        private readonly IHistoryService historyService;
        private readonly ITasksService tasksService;
        
        private bool isTaskNew;
        private Task task;

        public TaskEditPresenter(ITaskEditView view, ITasksRepository tasksRepository, ISkillsRepository skillsRepository,
            IHistoryService historyService, ITasksService tasksService)
        {
            this.view = view;
            this.tasksRepository = tasksRepository;
            this.skillsRepository = skillsRepository;
            this.tasksService = tasksService;
            this.historyService = historyService;
        }

        public void Initialize()
        {
            try
            {
                AttachEvents();
            }
            catch (Exception ex)
            {
                Logger.Exception(ex);
            }
        }

        public void SetTask(Task task)
        {
            this.task = task;
            this.isTaskNew = false;
        }

        private void AttachEvents()
        {
            view.SaveTask += Save;
            view.RemoveTask += Remove;
            view.ParentTaskChanged += ParentTaskChanged;
        }
        
        private void Remove(object sender, EventArgs e)
        {
            tasksRepository.Delete(task);
            historyService.AddHistoryEvent(HistoryEventType.TaskRemoved, task.Id);
        }
        
        private void Save(object sender, EventArgs e)
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
                        //view.DueDate = parentTask.DueDate;
                    }
                }
            }
        }
        
        public void NewTask()
        {
            task = new Task();
            isTaskNew = true;

            view.TaskName = "[Name something to be done]";
            view.Priority = 2;
            view.Difficulty = 2;
            view.TaskDescription = "[Describe your task]";
            view.MinDueDate = DateTime.Today;
            view.DueDate = DateTime.Now.AddDays(1);
            view.IsFinished = false;
            view.SkillsAvailable = GetAvailableSkillsRows(skillsRepository.Find(s => s.Owner.Id == Globals.DmitruUserId).ToList());
            view.SkillToTrainId = null;
            view.ParentTasksAvailable = GetAvailableParentTasks(tasksRepository.Find(t => t.Owner.Id == Globals.DmitruUserId && t.IsFinished == false).ToList());
            view.ParentTaskId = null;
            view.CanBeRemoved = false;
        }

        public void EditTask()
        {
            view.TaskName = task.Name;
            view.TaskDescription = task.Description;
            view.Priority = (int)task.Priority;
            view.Difficulty = (int)task.Difficulty;
            view.MinDueDate = task.DueDate.Value.Date;
            view.DueDate = task.DueDate;
            view.SkillsAvailable = GetAvailableSkillsRows(skillsRepository.Find(s => s.Owner.Id == Globals.DmitruUserId).ToList());
            view.SkillToTrainId = task.SkillToTrain?.Id;
            view.ParentTasksAvailable = GetAvailableParentTasks(tasksRepository.Find(t => t.Owner.Id == Globals.DmitruUserId && t.IsFinished == false).ToList());
            view.ParentTaskId = task.Parent?.Id;
            view.CanBeFinished = tasksService.IsFinishingAllowed(task.Id);
            view.CanBeRemoved = true;
        }

        private ICollection GetAvailableParentTasks(List<Task> tasks)
        {            
            List<string[]> taskRows = new List<string[]>();

            foreach (var task in tasks)
            {
                string[] taskRow = new string[]
                {
                    $"{task.Id}",
                    $"{task.Name}"
                };

                taskRows.Add(taskRow);
            }

            return taskRows;
        }
        
        private ICollection GetAvailableSkillsRows(List<Skill> skills)
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

        public void ShowView()
        {
            view.IsVisible = true;
        }

        public void HideView()
        {
            view.IsVisible = false;
        }

        public void OnViewDisplayed()
        {
        }
    }
}
