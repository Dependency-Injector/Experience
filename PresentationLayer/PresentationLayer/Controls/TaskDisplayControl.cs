using System;
using System.Collections;
using BussinessLogicLayer.Interfaces;
using MetroFramework.Controls;

namespace View.Controls
{
    public partial class TaskDisplayControl : MetroUserControl, ITaskDisplayView
    {
        public TaskDisplayControl()
        {
            InitializeComponent();
        }

        public string TaskName
        {
            set
            {
                nameLabel.Text = value;
            }
        }

        public string TaskDescription
        {
            set
            {
                descriptionLabel.Text = value;
            }
        }

        public DateTime Deadline
        {
            set { deadlineDate.Text = value.ToString("d"); }
        }
        
        public DateTime? FinishDate { get; set; }

        public string AssociatedSkillName
        {
            set { attachedSkillNameLabel.Text = value; }
        }

        public string Priority { set { priorityLabel.Text = value; } }

        public string ParentTaskName { set { parentTaskLabel.Text = value; } }

        public ICollection ChildrenTasks
        {
            set
            {
                //childrenTasksPanel
            }
        }

        public EventHandler<EventArgs> EditTask { get; set; }


        public bool IsVisible
        {
            set { this.Visible = value; }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (EditTask != null)
                EditTask(this, e);
        }
    }
}
