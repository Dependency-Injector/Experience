using System;
using System.Collections;

namespace PresentationLayer.Views
{
    public interface ITasksLayer
    {
        String TaskName { get; set; }
        String TaskDescription { get; set; }
        int Priority { get; set; }
        DateTime? DueDate { get; set; }
        bool IsFinished { get; set; }
        DateTime? FinishDate { get; set; }

        event EventHandler<EventArgs> EditTask;
        event EventHandler<int> FinishTask;
        String Status { set; }
        bool IsDirty { get; set; }
        ICollection Tasks { set; }

        event EventHandler<EventArgs> NewTask;

        event EventHandler<EventArgs> SaveTask;

        event EventHandler<EventArgs> RemoveTask;
        event EventHandler<EventArgs> PreviousTask;
        event EventHandler<EventArgs> NextTask;
        event EventHandler<int> SelectTask;
    }
}
