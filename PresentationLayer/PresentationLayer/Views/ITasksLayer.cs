using System;
using System.Collections;

namespace PresentationLayer.Views
{
    public interface ITasksLayer
    {
        String Status { set; }
        bool IsDirty { get; set; }
        ICollection Tasks { set; }

        event EventHandler<EventArgs> NewTask;
        event EventHandler<EventArgs> PreviousTask;
        event EventHandler<EventArgs> NextTask;
        event EventHandler<int> SelectTask;
    }
}
