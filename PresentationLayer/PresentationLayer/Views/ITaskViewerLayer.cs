using System;

namespace PresentationLayer.Views
{
    public interface ITaskViewerLayer
    {
        String TaskName { set; }
        String TaskDescription { set; }
        int Priority { set; }
        DateTime? DueDate { set; }
        bool IsFinished { set; }
        DateTime? FinishDate { set; }

        event EventHandler<EventArgs> EditTask;
        event EventHandler<int> FinishTask;
    }
}
