using System;
using System.Windows.Forms;
using BussinessLogicLayer.Interfaces;
using MetroFramework.Controls;
using Day = Model.Entities.Day;

namespace PresentationLayer.Controls
{
    public partial class DayControl : MetroUserControl, IDayView
    {
        private Day todayData;

        public DayControl()
        {
            InitializeComponent();
        }

        public string Thoughts
        {
            get { return thoughtsTextBox.Text; }
            set { thoughtsTextBox.Text = value; }
        }

        public DateTime Date
        {
            set
            {
                String dayDateText = value.ToString("dddd, d MMMM");
                dateLabel.Text = dayDateText;
            }
        }

        public int DayNumber
        {
            set { dayNumberLabel.Text = $"Day {value.ToString()}"; }
        }

        public IWin32Window Window {
            get { return this.Window; }
            }

        public event EventHandler<EventArgs> SaveDay;
        public event EventHandler<EventArgs> PreviousDay;
        public event EventHandler<EventArgs> NextDay;

        private void previousDayButton_Click(object sender, EventArgs e)
        {
            if (PreviousDay != null)
                PreviousDay(this, e);
        }

        private void nextDayButton_Click(object sender, EventArgs e)
        {
            if (NextDay != null)
                NextDay(this, e);
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            thoughtsTextBox.Enabled = true;
            saveChangesButton.Enabled = true;
            editButton.Enabled = false;


        }

        private void saveChangesButton_Click(object sender, EventArgs e)
        {
            if (SaveDay != null)
            {
                SaveDay(this, e);
            }

            thoughtsTextBox.Enabled = false;
            saveChangesButton.Enabled = false;
            editButton.Enabled = true;
        }
    }
}
