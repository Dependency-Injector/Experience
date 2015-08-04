using System;

namespace PresentationLayer.Views
{
    public interface ITaskViewerLayer
    {
        String TaskName { get; set; }
        int Priority { get; set; }
        DateTime? StartDate { get; set; }
        DateTime? DueDate { get; set; }
        bool IsFinished { get; set; }
        DateTime? FinishDate { get; set; }

        event EventHandler<EventArgs> FinishTask;
    }
}
