using System;
using System.Collections;
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

        private void TasksControl_Load(object sender, EventArgs e)
        {
            SetDisplayMode(DisplayMode.View);
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
<<<<<<< HEAD

        public string TaskDescription
        {
            get { return descriptionLabel.Text; }
=======
        public string TaskDescription
        {
            get { return descriptionTextBox.Text; }
>>>>>>> 6d0414dffd381edcb30463b5e75ea1347cea98b9
            set
            {
                descriptionLabel.Text = value;
                descriptionTextBox.Text = value;
            }
<<<<<<< HEAD
        }
        public int Priority
        {
            get
            {
                int priority = 0;
                if (lowPriorityRadioButton.Checked)
                    priority = 1;
                else if (mediumPriorityRadioButton.Checked)
                    priority = 2;
                else if (highPriorityRadioButton.Checked)
                    priority = 3;

                return priority;
            }
            set
            {
                switch (value)
                {
                    case 1:
                        priorityLabel.Text = "Low";
                        lowPriorityRadioButton.Checked = true;
                        break;
                    case 2:
                        priorityLabel.Text = "Medium";
                        mediumPriorityRadioButton.Checked = true;
                        break;
                    case 3:
                        priorityLabel.Text = "High";
                        highPriorityRadioButton.Checked = true;
                        break;
                    default:
                        priorityLabel.Text = "Unknown priority";
                        break;
                }
            }
        }

        public DateTime? DueDate
        {
            get { return DateTime.Now; }
            set
            {
                if (value.HasValue)
                {
                    startAndDueDate.Text = value.Value.ToShortDateString();
                    dueDateTime.Value = value.Value;
                }
            }
        }
=======
        }
        public int Priority { get; set; }
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

>>>>>>> 6d0414dffd381edcb30463b5e75ea1347cea98b9
        public bool IsFinished { get; set; }
        public DateTime? FinishDate { get; set; }

        public event EventHandler<EventArgs> EditTask;
        public event EventHandler<int> FinishTask;
        public string Status { get; set; }
        public bool IsDirty { get; set; }
        public ICollection Tasks { get; set; }
        public event EventHandler<EventArgs> NewTask;
        public event EventHandler<EventArgs> SaveTask;
        public event EventHandler<EventArgs> RemoveTask;
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

        private void editButton_Click(object sender, EventArgs e)
        {
            if (EditTask != null)
                EditTask(this, e);
<<<<<<< HEAD

            taskViewPanel.Hide();
            taskEditPanel.Show();
        }

        private void taskViewPanel_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
=======
>>>>>>> 6d0414dffd381edcb30463b5e75ea1347cea98b9

            SetDisplayMode(DisplayMode.Edit);
        }

        private void finishedButton_Click(object sender, EventArgs e)
        {
            if (FinishTask != null)
                FinishTask(this, 0);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (SaveTask != null)
                SaveTask(this, e);

<<<<<<< HEAD
            taskEditPanel.Hide();
            taskViewPanel.Show();
=======
            SetDisplayMode(DisplayMode.View);
>>>>>>> 6d0414dffd381edcb30463b5e75ea1347cea98b9
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD

            taskEditPanel.Hide();
            taskViewPanel.Show();
=======
            SetDisplayMode(DisplayMode.View);
        }


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
>>>>>>> 6d0414dffd381edcb30463b5e75ea1347cea98b9
        }
    }
}
