using System;
using System.Collections;
using Model.Enums;

namespace BussinessLogicLayer.Interfaces
{
    public interface ITaskEditView : IHideable
    {
        string Title { get; set; }
        String TaskName { get; set; }
        String TaskDescription { get; set; }
        int Priority { get; set; }
        int Difficulty { get; set; }
        DateTime? DueDate { get; set; }
        DateTime MinDueDate { get; set; }
        bool IsFinished { set; }
        DateTime? FinishDate { get; set; }
       
        bool IsDirty { set; }
        int? SkillToTrainId { get; set; }
        int? ParentTaskId { get; set; }
        String ParentTaskName { set; }
        bool CanBeFinished { set; }

        event EventHandler SaveTask;
        event EventHandler RemoveTask;
        event EventHandler<EventArgs> CancelTaskEditing;
        event EventHandler<EventArgs> FinishTask;
        event EventHandler<EventArgs> StartWorkingOnTask;
        event EventHandler<EventArgs> StopWorkingOnTask;
        event EventHandler<EventArgs> ParentTaskChanged;
        event EventHandler<EventArgs> CloseViewEditWindow;

        ICollection WorkUnits { set; }
        ICollection SkillsAvailable { set; }
        ICollection ChildrenTasks { set; }
    }
}