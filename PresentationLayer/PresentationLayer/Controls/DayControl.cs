using System;
using System.Collections.Generic;
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
        public int DayNumber
        {
            set { dayNumberLabel.Text = $"Day {value.ToString()}"; }
        }
        public int? ChoosenEntryId
        {
            get
            {
                if (choosenDiaryEntryComboBox.SelectedItem != null)
                {
                    var selectedDay = (KeyValuePair<int, string>)choosenDiaryEntryComboBox.SelectedItem;
                    if (selectedDay.Key > 0)
                        return selectedDay.Key;
                }

                return null;
            }
            set
            {
                raiseDayChangedEvent = false;
                if (choosenDiaryEntryComboBox.Items.Count > 0)
                {
                    if (value.HasValue)
                    {
                        choosenDiaryEntryComboBox.SelectItemByValue(value.Value);
                    }
                    else
                    {
                        choosenDiaryEntryComboBox.SelectedIndex = 0;
                    }
                }
                raiseDayChangedEvent = false;
            }
        }
        public Dictionary<int, string> Entries
        {
            set
            {
                ClearEntriesComboBox();
                FillEntriesList(value);
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
        public event EventHandler<EventArgs> EditDay;
        public event EventHandler<EventArgs> ShowPreviousDay;
        public event EventHandler<EventArgs> ShowNextDay;
        public event EventHandler<DateTime> DateChanged;
        public event EventHandler<int> EntrySelected;

        public DayControl()
        {
            InitializeComponent();
        }
        
        private void ClearEntriesComboBox()
        {
            choosenDiaryEntryComboBox.Items.Clear();
        }

        private void FillEntriesList(Dictionary<int, string> entries)
        {
            if (entries != null && entries.Count > 0)
            {
                KeyValuePair<int, string> emptyItem = new KeyValuePair<int, string>(0, "");
                choosenDiaryEntryComboBox.Items.Add(emptyItem);

                foreach (var entry in entries)
                {
                    choosenDiaryEntryComboBox.Items.Add(entry);
                }
            }
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

        private void choosenDiaryEntryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (EntrySelected != null && raiseDayChangedEvent)
                EntrySelected(this, 5);
        }
        
        #endregion Event handlers


    }
}
