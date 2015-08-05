using System;
using System.Collections;

namespace PresentationLayer.Views
{
    public interface ITasksView
    {
        String TaskName { get; set; }
        String TaskDescription { get; set; }
        int Priority { get; set; }
        DateTime? DueDate { get; set; }
        bool IsFinished {  set; }
        DateTime? FinishDate { get; set; }
        bool IsDirty { get; set; }
        ICollection Tasks { set; }


        event EventHandler<EventArgs> NewTask;
        event EventHandler<EventArgs> SaveTask;
        event EventHandler<EventArgs> RemoveTask;
        event EventHandler<EventArgs> FinishTask;
        event EventHandler<EventArgs> PreviousTask;
        event EventHandler<EventArgs> NextTask;
        event EventHandler<int> SelectTask;
    }
}
