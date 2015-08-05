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

        public string TaskName
        {
            set { nameLabel.Text = value; }
        }
        public string TaskDescription
        {
            set { descriptionLabel.Text = value; }
        }
        public int Priority
        {
            set
            {
                switch (value)
                {
                    case 1:
                        priorityLabel.Text = "Low";
                        break;
                    case 2:
                        priorityLabel.Text = "Medium";
                        break;
                    case 3:
                        priorityLabel.Text = "High";
                        break;
                    default:
                        priorityLabel.Text = "Unknown priority";
                        break;
                }
            }
        }
        public DateTime? DueDate
        {
            set
            {
                if (value.HasValue)
                    startAndDueDate.Text = value.Value.ToShortDateString();
                else
                {
                    startAndDueDate.Text = "No due date set";
                }
            }
        }
        public bool IsFinished
        {
            set
            {
                
            }
        }
        public DateTime? FinishDate
        {
            set
            {
                
            }
        }

        public event EventHandler<int> FinishTask;
        public event EventHandler<EventArgs> EditTask;
        

        private void finishedButton_Click(object sender, EventArgs e)
        {
            //if (FinishTask != null)
            //    FinishTask(this, e);
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (EditTask != null)
                EditTask(this, e);
        }
    }
}
