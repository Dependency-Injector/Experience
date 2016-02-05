using System;
using System.Collections;
using BussinessLogicLayer.Interfaces;
using MetroFramework.Controls;

namespace PresentationLayer.Controls
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

        public DateTime? DueDate
        {
            set
            {
                if (value.HasValue)
                {
                    startAndDueDate.Text = value.Value.ToString("M");
                }
            }
        }
        
        public bool IsFinished
        {
            set
            {
                //if(value)
                //    ShowActionButtons(false);
                //else
                //    ShowActionButtons(true);
            }
        }

        public DateTime? FinishDate { get; set; }

        public string TotalWorkload
        {
            set
            {
                totalWorkloadLabel.Text = value;
            }
        }

        public string TotalExperienceGained
        {
            set { totalExpGainedLabel.Text = value; }
        }

        public string AssociatedSkillName
        {
            set { attachedSkillNameLabel.Text = value; }
        }

        public string ParentTaskName { set {} }
        public ICollection WorkUnits { set {} }
        public ICollection ChildrenTasks { set {} }

        public bool IsVisible
        {
            set { this.Visible = value; }
        }
    }
}
