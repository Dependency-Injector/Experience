using System;
using System.Collections;
using MetroFramework.Controls;
using PresentationLayer.Views;

namespace PresentationLayer.Controls.Editors
{
    public partial class TaskEditor : MetroUserControl, ITaskEditorLayer
    {
        public TaskEditor()
        {
            InitializeComponent();
        }

        public string TaskName
        {
            get { return taskNameTextBox.Text; }
            set { taskNameTextBox.Text = value; }
        }

        public int Priority
        {
            get
            {
                if (lowPriorityRadioButton.Checked)
                    return 1;
                else if (mediumPriorityButton.Checked)
                    return 2;
                else if (highPriorityButton.Checked)
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
                        break;
                    case 2:
                        mediumPriorityButton.Checked = true;
                        break;
                    case 3:
                        highPriorityButton.Checked = true;
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
                    dueDateTime.Value = value.Value;
                else
                    dueDateTime.Value = DateTime.Now.AddDays(7);
            }
        }

        public bool IsFinished { get; set; }
        public DateTime? FinishDate { get; set; }
        public bool IsDirty { get; set; }
        public event EventHandler<EventArgs> SaveTask;
        public event EventHandler<EventArgs> NewTask;
        public event EventHandler<EventArgs> RemoveTask;
        public event EventHandler<int> SelectTask;

        private void descriptionTextBox_Click(object sender, EventArgs e)
        {

        }

        private void saveChangesButton_Click(object sender, EventArgs e)
        {
            if (SaveTask != null)
                SaveTask(this, e);
        }

        private void cancelChanges_Click(object sender, EventArgs e)
        {
            if (cancelChanges != null)
                cancelChanges(this, e);
        }

        private void TaskEditor_Load(object sender, EventArgs e)
        {
            IsDirty = false;
        }
    }
}
