using System;
using System.Collections;

namespace BussinessLogicLayer.Interfaces
{
    public interface ITaskEditView : IHideable
    {
        String TaskName { get; set; }
        String TaskDescription { get; set; }
        int Priority { get; set; }
        int Difficulty { get; set; }
        DateTime? DueDate { get; set; }
        DateTime MinDueDate { get; set; }
        bool IsFinished { set; }
        bool IsDirty { set; }
        int? SkillToTrainId { get; set; }
        int? ParentTaskId { get; set; }
        bool CanBeFinished { set; }

        event EventHandler SaveTask;
        event EventHandler RemoveTask;
        event EventHandler<EventArgs> CancelTaskEditing;
        event EventHandler<EventArgs> ParentTaskChanged;

        ICollection WorkUnits { set; }
        ICollection SkillsAvailable { set; }
        ICollection ParentTasks { set; }
    }
}