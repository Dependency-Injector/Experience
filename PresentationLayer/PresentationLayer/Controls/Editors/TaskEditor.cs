using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            get { return nameTextBox.Text; }
            set { nameTextBox.Text = value; }
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
                        break;
                    case 2:
                        mediumPriorityRadioButton.Checked = true;
                        break;
                    case 3:
                        highPriorityRadioButton.Checked = true;
                        break;
                }
            }
        }

        public DateTime? StartDate
        {
            get
            {
                return DateTime.Now;
            }
            set
            {
                if (value.HasValue)
                    dueDateTime.Value = value.Value;
                else
                    dueDateTime.Value = DateTime.Now.AddDays(7);

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

        private void metroRadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void saveChangesButton_Click(object sender, EventArgs e)
        {
            if (SaveTask != null)
                SaveTask(this, e);
        }

        private void cancelChangesButton_Click(object sender, EventArgs e)
        {

        }

        private void TaskEditor_Load(object sender, EventArgs e)
        {
            IsDirty = false;
        }
    }
}
