using System;
using System.Collections;

namespace BussinessLogicLayer.Interfaces
{
    public interface ITasksView
    {
        String TaskName { get; set; }
        String TaskDescription { get; set; }
        int Priority { get; set; }
        DateTime? DueDate { get; set; }
        bool IsFinished { set; }
        DateTime? FinishDate { get; set; }
        String TotalWorkload { set; }
        String TotalExperienceGained { set; }
        String AssociatedSkillName { set; }
        bool IsDirty { get; set; }
        int? SkillToTrainId { get; set; }
        int? ParentTaskId { get; set; }
        ICollection WorkUnits { set; }
        ICollection Tasks { set; }
        ICollection SkillsAvailable { set; }

        event EventHandler<EventArgs> NewTask;
        event EventHandler<EventArgs> SaveTask;
        event EventHandler<EventArgs> RemoveTask;
        event EventHandler<EventArgs> FinishTask;
        event EventHandler<EventArgs> PreviousTask;
        event EventHandler<EventArgs> NextTask;
        event EventHandler<EventArgs> StartWorkingOnTask;
        event EventHandler<EventArgs> StopWorkingOnTask;
        event EventHandler<int> SelectTask;
    }
}
