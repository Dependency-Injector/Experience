using System.Windows.Forms;
using BussinessLogicLayer.Interfaces;
using MetroFramework.Forms;

namespace View.Forms
{
    public partial class TaskCompositeForm : MetroForm, ITaskCompositeView
    {
        public ITaskDisplayView TaskDisplayView { get { return taskDisplayControl; } }
        public ITaskEditView TaskEditView { get { return taskEditControl; } }
    
        public TaskCompositeForm()
        {
            InitializeComponent();
        }

        public string Title
        {
            get { return this.Text; }
            set { this.Text = value; }
        }

        public bool IsVisible
        {
            set
            {
                if(value)
                    this.Show();
                else
                    this.Hide();
            }
        }

        private void TaskCompositeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Prevent closing form - instead, just hide it
            this.Hide();
            e.Cancel = true;
        }

        private void TaskCompositeForm_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
                this.Hide();
        }
    }
}
