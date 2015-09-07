using System;
using BussinessLogicLayer.Interfaces;
using MetroFramework.Controls;
using Model.Enums;

namespace PresentationLayer.Controls
{
    public partial class DayControl : MetroUserControl, IDayView
    {
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
        public bool ShowNextDayButton
        {
            set { nextDayButton.Visible = value; }
        }
        public bool ShowPreviousDayButton
        {
            set { previousDayButton.Visible = value; }
        }
        public bool ShowEditButton
        {
            set { editButton.Visible = value; }
        }
        public bool ShowSaveChangesButton
        {
            set { saveChangesButton.Visible = value; }
        }
        public bool ThoughtsTextBoxEnabled
        {
            set { thoughtsTextBox.Enabled = value; }
        }
        
        public event EventHandler<EventArgs> SaveDay;
        public event EventHandler<SwitchDisplayModeEventArgs> SwitchDisplayMode;
        public event EventHandler<EventArgs> ShowPreviousDay;
        public event EventHandler<EventArgs> ShowNextDay;

        public DayControl()
        {
            InitializeComponent();
        }

        private void previousDayButton_Click(object sender, EventArgs e)
        {
            if (ShowPreviousDay != null)
                ShowPreviousDay(this, e);
        }

        private void nextDayButton_Click(object sender, EventArgs e)
        {
            if (ShowNextDay != null)
                ShowNextDay(this, e);
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            SwitchDisplayModeEventArgs args = new SwitchDisplayModeEventArgs();
            args.DisplayMode = DisplayMode.Edit;

            if (SwitchDisplayMode != null)
                SwitchDisplayMode(this, args);
        }

        private void saveChangesButton_Click(object sender, EventArgs e)
        {
            if (SaveDay != null)
                SaveDay(this, e);
        }
    }
}
