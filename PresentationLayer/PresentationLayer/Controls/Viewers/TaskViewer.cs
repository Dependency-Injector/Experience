using System;
using MetroFramework.Controls;
using PresentationLayer.Views;

namespace PresentationLayer.Controls.Viewers
{
    public partial class TaskViewer : MetroUserControl, ITaskViewerLayer
    {
        public TaskViewer()
        {
            InitializeComponent();
        }

        public string TaskName { get; set; }
        public int Priority { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? DueDate { get; set; }
        public bool IsFinished { get; set; }
        public DateTime? FinishDate { get; set; }
        public event EventHandler<EventArgs> FinishTask;

        private void finishedButton_Click(object sender, EventArgs e)
        {
            if (FinishTask != null)
                FinishTask(this, e);
        }
    }
}
