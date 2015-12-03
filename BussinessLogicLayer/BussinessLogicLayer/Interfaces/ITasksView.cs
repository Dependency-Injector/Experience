using System;
using System.Collections;
using System.Collections.Generic;
using BussinessLogicLayer.GridRowTemplates;

namespace BussinessLogicLayer.Interfaces
{
    public interface ITasksView
    {
        int TaskId { get; set; }
        String TaskName { get; set; }
        String TaskDescription { get; set; }
        int Priority { get; set; }
        DateTime? DueDate { get; set; }
        DateTime MinDueDate { get; set; }
        bool IsFinished { set; }
        DateTime? FinishDate { get; set; }
        String TotalWorkload { set; }
        String TotalExperienceGained { set; }
        String AssociatedSkillName { set; }
        bool IsDirty {  set; }
        int? SkillToTrainId { get; set; }
        int? ParentTaskId { get; set; }
        bool CanBeFinished { set; }
        String ParentTaskName { set; }
        int SelectedTaskIndex { set; }
        ICollection WorkUnits { set; }
        Dictionary<int, string> Tasks { set; }
        ICollection SkillsAvailable { set; }
        ICollection ChildrenTasks { set; }
        IList<TaskGridItem> TasksGridItems { set; }
             
        bool TaskListEnabled { set; }
        bool TaskDetailsPanelVisible { set; }
        bool TaskEditPanelVisible { set; }
        bool ActionButtonsVisible { set; }
        bool WorkUnitsPanelVisible { set; }

        event EventHandler<EventArgs> NewTask;
        event EventHandler<EventArgs> SaveTask;
        event EventHandler<EventArgs> EditTask;
        event EventHandler<EventArgs> RemoveTask;
        event EventHandler<EventArgs> CancelTaskEditing;
        event EventHandler<EventArgs> FinishTask;
        event EventHandler<EventArgs> PreviousTask;
        event EventHandler<EventArgs> NextTask;
        event EventHandler<EventArgs> StartWorkingOnTask;
        event EventHandler<EventArgs> StopWorkingOnTask;
        event EventHandler<EventArgs> ParentTaskChanged;
        event EventHandler<int> SelectTask;

        event EventHandler<bool> ShowFinishedTasks;
    }
}
