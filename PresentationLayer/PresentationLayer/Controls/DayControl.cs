using System;
using BussinessLogicLayer.Interfaces;
using MetroFramework.Controls;

namespace PresentationLayer.Controls
{
    public partial class DayControl : MetroUserControl, IDayView
    {
        private bool raiseDayChangedEvent = true;

        public string Thoughts
        {
            get { return thoughtsTextBox.Text; }
            set { thoughtsTextBox.Text = value; }
        }
        public DateTime Date
        {
            set
            {
                raiseDayChangedEvent = false;
                selectedDayDateTime.Value = value;
                raiseDayChangedEvent = true;

                String dayDateText = value.ToString("dddd, d MMMM");
                dateLabel.Text = dayDateText;
            }
        }

        public DateTime DaySelectorMinDate
        {
            set { selectedDayDateTime.MinDate = value; }
        }

        public DateTime DaySelectorMaxDate
        {
            set { selectedDayDateTime.MaxDate = value; }
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
        
        public event EventHandler<EventArgs> SaveDayChanges;
        public event EventHandler<EventArgs> CancelDayChanges;
        public event EventHandler<EventArgs> EditDay;
        public event EventHandler<EventArgs> ShowPreviousDay;
        public event EventHandler<EventArgs> ShowNextDay;
        public event EventHandler<DateTime> DateChanged;

        public DayControl()
        {
            InitializeComponent();
        }

        #region Event handlers

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
            if (EditDay != null)
                EditDay(this, e);
        }

        private void saveChangesButton_Click(object sender, EventArgs e)
        {
            if (SaveDayChanges != null)
                SaveDayChanges(this, e);
        }

        private void selectedDayDateTime_ValueChanged(object sender, EventArgs e)
        {
            if (DateChanged != null && raiseDayChangedEvent)
                DateChanged(this, selectedDayDateTime.Value);
        }

        #endregion Event handlers
    }
}
