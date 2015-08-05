using System;
using System.Collections;
using System.Windows.Forms;
using MetroFramework.Controls;
using PresentationLayer.Controls.Editors;
using PresentationLayer.Controls.Viewers;
using PresentationLayer.Presenters;
using PresentationLayer.Views;

namespace PresentationLayer.Controls.Panels
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
                switch (value)
                {
                    case 1:
                        lowPriorityRadioButton.Checked = true;
                        priorityLabel.Text = "Low";
                        break;
                    case 2:
                        mediumPriorityRadioButton.Checked = true;
                        priorityLabel.Text = "Medium";
                        break;
                    case 3:
                        highPriorityRadioButton.Checked = true;
                        priorityLabel.Text = "High";
                        break;
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
                if (value)
                {
                    finishedButton.Visible = false;
                    editButton.Visible = false;
                }
                else
                {
                    editButton.Visible = true;
                    finishedButton.Visible = true;
                }
            }
        }
        public DateTime? FinishDate { get; set; }
        public bool IsDirty { get; set; }

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
        }

        private void tasksListGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (tasksListGrid.SelectedRows.Count > 0)
            {
                var selectedRow = tasksListGrid.SelectedRows[0];
                if (selectedRow.Cells[0].Value != null)
                {
                    var cellValue = selectedRow.Cells[0].Value;

                    int selectedTaskId = 0;
                    if (int.TryParse(cellValue.ToString(), out selectedTaskId))
                        SelectTask(tasksListGrid, selectedTaskId);
                }
            }
        }
        #endregion Events

        private void SetDisplayMode(DisplayMode displayMode)
        {
            if (displayMode == DisplayMode.Edit)
            {
                taskViewPanel.Hide();
                taskEditPanel.Show();
            }
            else if (displayMode == DisplayMode.View)
            {
                taskEditPanel.Hide();
                taskViewPanel.Show();
            }
        }

        
    }
}
