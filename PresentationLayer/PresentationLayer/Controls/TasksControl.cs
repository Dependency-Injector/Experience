using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework.Controls;
using PresentationLayer.Views;
using Utilities;

namespace PresentationLayer.Controls
{
    public partial class TasksControl : MetroUserControl, ITasksView
    {
        public TasksControl()
        {
            InitializeComponent();
        }

        public string TaskName
        {
            get { return nameTextBox.Text; }
            set
            {
                nameLabel.Text = value;
                nameTextBox.Text = value;
            }
        }
        public string TaskDescription
        {
            get { return descriptionTextBox.Text; }
            set
            {
                descriptionLabel.Text = value;
                descriptionTextBox.Text = value;
            }
        }
        public int Priority
        {
            get
            {
                if (lowPriorityRadioButton.Checked)
                    return 1;
                else if (mediumPriorityRadioButton.Checked)
                    return 2;
                else if (highPriorityRadioButton.Checked)
                    return 3;
                else
                    return 0;
            }

            set
            {
                if (TaskDefaults.Priorities.ContainsKey(value))
                {
                    PriorityLevel priority = TaskDefaults.Priorities[value];

                    switch (priority.Severity)
                    {
                        case Severity.Low:
                            lowPriorityRadioButton.Checked = true;
                            break;
                        case Severity.Medium:
                            mediumPriorityRadioButton.Checked = true;
                            break;
                        case Severity.High:
                            highPriorityRadioButton.Checked = true;
                            break;
                    }

                    priorityLabel.Text = priority.Name;
                    priorityLabel.BackColor = priority.Color;
                }
            }
        }
        public DateTime? DueDate
        {
            get { return dueDateTime.Value; }
            set
            {
                if (value.HasValue)
                {
                    startAndDueDate.Text = value.Value.ToShortDateString();
                    dueDateTime.Value = value.Value;
                }
            }
        }

        public bool IsFinished
        {
            set
            {
                PrepareButtonsForTask(value);
            }
        }

        public DateTime? FinishDate { get; set; }
        public bool IsDirty { get; set; }
        public ICollection WorkUnits { set { workUnitsGrid.DataSource = value; } }

        public ICollection Tasks
        {
            set { tasksListGrid.DataSource = value; }
        }

        public event EventHandler<EventArgs> NewTask;
        public event EventHandler<EventArgs> SaveTask;
        public event EventHandler<EventArgs> RemoveTask;
        public event EventHandler<EventArgs> FinishTask;

        public event EventHandler<EventArgs> PreviousTask;
        public event EventHandler<EventArgs> NextTask;
        public event EventHandler<int> SelectTask;

        public event EventHandler<EventArgs> StartWorkingOnTask;
        public event EventHandler<EventArgs> StopWorkingOnTask;

        #region Events

        private void TasksControl_Load(object sender, EventArgs e)
        {
            IsDirty = true;
            SetDisplayMode(DisplayMode.View);
        }

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

            SetDisplayMode(DisplayMode.Edit);
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            SetDisplayMode(DisplayMode.Edit);
        }

        private void finishedButton_Click(object sender, EventArgs e)
        {
            if (FinishTask != null)
                FinishTask(this, e);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (SaveTask != null)
                SaveTask(this, e);

            SetDisplayMode(DisplayMode.View);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            SetDisplayMode(DisplayMode.View);
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (RemoveTask != null)
                RemoveTask(this, e);

            SetDisplayMode(DisplayMode.View);
        }

        private void tasksListGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (SelectTask != null)
            {
                if (tasksListGrid.SelectedRows.Count > 0)
                {
                    var selectedRow = tasksListGrid.SelectedRows[0];
                    if (selectedRow.Cells[0].Value != null)
                    {
                        var cellValue = selectedRow.Cells[0].Value;

                        int selectedTaskId;
                        if (int.TryParse(cellValue.ToString(), out selectedTaskId))
                            SelectTask(tasksListGrid, selectedTaskId);
                    }
                }
            }
        }

        private void tasksListGrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (e.ListChangedType != ListChangedType.ItemDeleted)
            {
                DataGridViewCellStyle lowPriorityStyle = tasksListGrid.DefaultCellStyle.Clone();
                DataGridViewCellStyle mediumPriorityStyle = tasksListGrid.DefaultCellStyle.Clone();
                DataGridViewCellStyle highPriorityStyle = tasksListGrid.DefaultCellStyle.Clone();

                lowPriorityStyle.BackColor = TaskDefaults.Priorities[1].Color;
                lowPriorityStyle.SelectionBackColor = TaskDefaults.Priorities[1].SelectionColor;
                mediumPriorityStyle.BackColor = TaskDefaults.Priorities[2].Color;
                mediumPriorityStyle.SelectionBackColor = TaskDefaults.Priorities[2].SelectionColor;
                highPriorityStyle.BackColor = TaskDefaults.Priorities[3].Color;
                highPriorityStyle.SelectionBackColor = TaskDefaults.Priorities[3].SelectionColor;

                var dataGridViewColumn = tasksListGrid.Columns["Priority"];
                if (dataGridViewColumn == null)
                {
                    SetColumnNames();
                    dataGridViewColumn = tasksListGrid.Columns["Priority"];
                }

                if (dataGridViewColumn != null)
                {
                    int priorityColumnIndex = dataGridViewColumn.Index;

                    foreach (DataGridViewRow row in tasksListGrid.Rows)
                    {
                        if (row.Cells[priorityColumnIndex].Value.ToString() == "1")
                        {
                            row.DefaultCellStyle = lowPriorityStyle;
                            
                        }
                        else if (row.Cells[priorityColumnIndex].Value.ToString() == "2")
                        {
                            row.DefaultCellStyle = mediumPriorityStyle;
                        }
                        else if (row.Cells[priorityColumnIndex].Value.ToString() == "3")
                        {
                            row.DefaultCellStyle = highPriorityStyle;
                        }

                    }
                }
            }
            
        }

        private void startWorkButton_Click(object sender, EventArgs e)
        {
            if (StartWorkingOnTask != null)
                StartWorkingOnTask(this, e);

            stopWorkingButton.Enabled = true;
            startWorkButton.Enabled = false;
        }

        private void stopWorkingButton_Click(object sender, EventArgs e)
        {
            if (StopWorkingOnTask != null)
                StopWorkingOnTask(this, e);

            startWorkButton.Enabled = true;
            stopWorkingButton.Enabled = false;
        }

        #endregion Events

        private void SetDisplayMode(DisplayMode displayMode)
        {
            if (displayMode == DisplayMode.Edit)
            {
                taskDetailsPanel.Hide();
                taskEditPanel.Show();
            }
            else if (displayMode == DisplayMode.View)
            {
                taskEditPanel.Hide();
                taskDetailsPanel.Show();
            }
        }

        public void SetColumnNames()
        {
            priorityGridColumn.Name = "Priority";
        }

        private void PrepareButtonsForTask(bool finished)
        {
            if (finished)
            {
                finishedButton.Visible = false;
                editButton.Visible = false;

                startWorkButton.Visible = false;
                stopWorkingButton.Visible = false;
            }
            else
            {
                editButton.Visible = true;
                finishedButton.Visible = true;

                startWorkButton.Visible = true;
                stopWorkingButton.Visible = true;
                startWorkButton.Enabled = true;
            }
        }

    }

    internal enum DisplayMode
    {
        View,
        Edit
    }
}
