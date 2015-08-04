using System;
using System.Collections;
using MetroFramework.Controls;
using PresentationLayer.Views;

namespace PresentationLayer.Controls
{
    public partial class TaskEditorEditor : MetroUserControl, ITaskEditorLayer
    {
        public TaskEditorEditor()
        {
            InitializeComponent();
        }
        
        #region Properties

        public String TaskName
        {
            get { return nameTextBox.Text; }
            set { nameTextBox.Text = value; }
        }

        public int Priority
        {
            get
            {
                int priority = 0;
                if (lowPriorityRadioButton.Checked)
                    priority = 0;
                else if (mediumPriorityRadioButton.Checked)
                    priority = 1;
                else if (highPriorityRadioButton.Checked)
                    priority = 2;

                return priority;
            }
            set
            {
                switch (value)
                {
                    case 0:
                        lowPriorityRadioButton.Checked = true;
                        break;
                    case 1:
                        mediumPriorityRadioButton.Checked = true;
                        break;
                    case 2:
                        highPriorityRadioButton.Checked = true;
                        break;
                }
            }
        }

        public DateTime? StartDate
        {
            get { return startDateTime.Value; }
            set
            {
                if (value.HasValue)
                    startDateTime.Value = value.Value;
            }
        }

        public DateTime? DueDate
        {
            get
            {
                return dueDateTime.Value;
            }
            set
            {
                if (value.HasValue)
                    dueDateTime.Value = value.Value;
            }
        }

        public DateTime? FinishDate { get; set; }

        public bool IsFinished
        {
            get { return isCompletedCheckBox.Checked; }
            set { isCompletedCheckBox.Checked = value; }
        }

        public string Status
        {
            set { statusTextBox.Text = value; }
        }

        public bool IsDirty { get; set; }

        public ICollection Tasks
        {
            set { tasksGridView.DataSource = value; }
        }

        #endregion

        #region Event handlers

        public event EventHandler<EventArgs> SaveTask;
        public event EventHandler<EventArgs> NewTask;
        public event EventHandler<EventArgs> PreviousTask;
        public event EventHandler<EventArgs> NextTask;
        public event EventHandler<EventArgs> RemoveTask;
        public event EventHandler<EventArgs> Finished;
        public event EventHandler<EventArgs> Unfinished;
        public event EventHandler<int> SelectTask;

        #endregion

        private void TaskEditor_Load(object sender, EventArgs e)
        {
            IsDirty = false;
        }

        private void isCompletedCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (Finished != null)
                Finished(this, e);
        }

        private void nextTaskButton_Click(object sender, EventArgs e)
        {
            if (NewTask != null)
                NewTask(this, e);
        }

        private void previousTaskButton_Click(object sender, EventArgs e)
        {
            if (PreviousTask != null)
                PreviousTask(this, e);
        }

        private void newTaskButton_Click(object sender, EventArgs e)
        {
            if (NextTask != null)
                NextTask(this, e);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (SaveTask != null)
                SaveTask(this, e);
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (RemoveTask != null)
                RemoveTask(this, e);
        }

        private void tasksGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (tasksGridView.SelectedRows.Count > 0)
            {
                var selectedCell = tasksGridView.SelectedRows[0].Cells[0];
                if (selectedCell != null)
                {
                    int selectedCellValue;
                    if (int.TryParse(selectedCell.Value.ToString(), out selectedCellValue))
                    {
                        if (SelectTask != null)
                            SelectTask(this, selectedCellValue);
                    }
                }
            }
        }
    }
}
