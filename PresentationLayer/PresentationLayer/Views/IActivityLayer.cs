using System;

namespace PresentationLayer.Views
{
    public interface IActivityLayer
    {
        String ActivityName { get; set; }
        DateTime? StartDateTime { get; set; }
        DateTime? EndDateTime { get; set; }
        DateTime? ElapsedTime { get; set; }
        bool IsDirty { get; set; }

        event EventHandler<EventArgs> NewActivity;
        event EventHandler<EventArgs> StopActivity;
        event EventHandler<EventArgs> Pause;
        event EventHandler<EventArgs> StartActivity;
        event EventHandler<EventArgs> ReportActivity;
        event EventHandler<EventArgs> Delete;
    }
}
