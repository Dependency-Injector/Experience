using System;
using System.Collections;
using MetroFramework.Controls;
using PresentationLayer.Controls.Editors;
using PresentationLayer.Controls.Viewers;
using PresentationLayer.Views;

namespace PresentationLayer.Controls.Panels
{
    public partial class TasksControl : MetroUserControl, ITasksLayer
    {
        public TasksControl()
        {
            InitializeComponent();
        }

        public TaskViewer Viewer
        {
            get { return taskViewer; }
        }

        public TaskEditor Editor
        {
            get { return taskEditor; }
        }

        private void TasksControl_Load(object sender, EventArgs e)
        {

        }

        public string Status { get; set; }
        public bool IsDirty { get; set; }
        public ICollection Tasks { get; set; }
        public event EventHandler<EventArgs> NewTask;
        public event EventHandler<EventArgs> PreviousTask;
        public event EventHandler<EventArgs> NextTask;
        public event EventHandler<int> SelectTask;

        private void nextTaskButton_Click(object sender, EventArgs e)
        {
            if (NextTask != null)
                NextTask(this, e);
        }

        private void previousTaskButton_Click(object sender, EventArgs e)
        {
            if (PreviousTask != null)
                PreviousTask(this, e);
        }

        private void newTaskButton_Click(object sender, EventArgs e)
        {
            if (NewTask != null)
                NewTask(this, e);
        }
    }
}
