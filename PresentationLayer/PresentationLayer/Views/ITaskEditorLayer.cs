using System;

namespace PresentationLayer.Views
{
    public interface ITaskEditorLayer
    {
        String TaskName { get; set; }
        int Priority { get; set; }
        DateTime? DueDate { get; set; }
        bool IsFinished { get; set; }
        DateTime? FinishDate { get; set; }
        bool IsDirty { get; set; }

        event EventHandler<EventArgs> SaveTask;
        event EventHandler<EventArgs> NewTask;
        event EventHandler<EventArgs> RemoveTask;
        event EventHandler<int> SelectTask;
    }
}
