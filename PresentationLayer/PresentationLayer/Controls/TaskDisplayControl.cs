using System;
using System.Collections;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BussinessLogicLayer.Interfaces;
using MetroFramework;
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

        public String Deadline
        {
            set { deadlineDate.Text = value; }
        }
        
        public String FinishDate { get; set; }

        public string AssociatedSkillName
        {
            set { attachedSkillNameLabel.Text = value; }
        }

        public string Priority { set { priorityLabel.Text = value; } }

        public bool ChildrenTasksPresent
        {
            set
            {
                childTasksLabel.Visible = value;
                childrenTasksPanel.Visible = value;
            }
        }

        public string ParentTaskName { set { parentTaskLabel.Text = value; } }

        public ICollection ChildrenTasks
        {
            set
            {
                ClearChildrenTasksPanel();
                FillChildrenTasksList(value);
            }
        }

        public EventHandler<EventArgs> EditTask { get; set; }
        public EventHandler<EventArgs> FinishTask { get; set; }
        
        public bool IsVisible
        {
            set { this.Visible = value; }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (EditTask != null)
                EditTask(this, e);
        }

        private void ClearChildrenTasksPanel()
        {
            childrenTasksPanel.Controls.Clear();
        }

        private void FillChildrenTasksList(ICollection childrenTasksRowData)
        {
            if (childrenTasksRowData != null && childrenTasksRowData.Count > 0)
            {
                foreach (var row in childrenTasksRowData)
                {
                    var rowData = row as string[];
                    if (rowData != null && rowData.Any())
                    {
                        bool finished;
                        if (rowData.Count() > 0 && bool.TryParse(rowData[1], out finished))
                        {
                            MetroCheckBox childTaskCheckBox = new MetroCheckBox();
                            childTaskCheckBox.Text = rowData[0];
                            childTaskCheckBox.Checked = finished;
                            childTaskCheckBox.Theme = MetroThemeStyle.Dark;
                            childTaskCheckBox.Dock = DockStyle.Top;
                            childTaskCheckBox.Enabled = false;

                            if (finished)
                                childTaskCheckBox.Font = new Font(childTaskCheckBox.Font, FontStyle.Strikeout);

                            childrenTasksPanel.Controls.Add(childTaskCheckBox);
                        }
                    }
                }
            }
        }

        private void finishedButton_Click(object sender, EventArgs e)
        {
            if (FinishTask != null)
                FinishTask(this, e);
        }
    }
}
