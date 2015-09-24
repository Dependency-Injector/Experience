using System;
using System.Collections;
using BussinessLogicLayer.Interfaces;
using MetroFramework.Controls;

namespace PresentationLayer.Controls
{
    public partial class HistoryControl : MetroUserControl, IHistoryView
    {
        #region Properties

        public ICollection HistoryEventsRows
        {
            set
            {
                ClearHistoryEventsGrid();
                FillHistoryGrid(value);
            }
        }

        public bool DisplayTaskEvents
        {
            get { return tasksEventsCheckBox.Checked; }
            set { tasksEventsCheckBox.Checked = value; }
        }

        public bool DisplayWorkUnitEvents
        {
            get { return workUnitsEventsCheckBox.Checked; }
            set { workUnitsEventsCheckBox.Checked = value; }
        }

        public bool DisplayExperienceEvents
        {
            get { return experienceEventsCheckBox.Checked; }
            set { experienceEventsCheckBox.Checked = value; }
        }

        public bool DisplayProfileAndSkillsEvents
        {
            get { return profileAndSkillsEventsCheckBox.Checked; }
            set { profileAndSkillsEventsCheckBox.Checked = value; }
        }
        
        public event EventHandler<EventArgs> ShowHideTaskEvents;
        public event EventHandler<EventArgs> ShowHideWorkUnitEvents;
        public event EventHandler<EventArgs> ShowHideExperienceEvents;
        public event EventHandler<EventArgs> ShowHideProfileAndSkillEvents;

        #endregion

        #region Event handlers

        private void tasksEventsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowHideTaskEvents != null)
                ShowHideTaskEvents(this, e);
        }

        private void experienceEventsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowHideExperienceEvents != null)
                ShowHideExperienceEvents(this, e);
        }

        private void workUnitsEventsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowHideWorkUnitEvents != null)
                ShowHideWorkUnitEvents(this, e);
        }

        private void profileAndSkillsEventsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowHideProfileAndSkillEvents != null)
                ShowHideProfileAndSkillEvents(this, e);
        }

        #endregion

        public HistoryControl()
        {
            InitializeComponent();
        }

        private void ClearHistoryEventsGrid()
        {
            historyEventsGrid.Rows.Clear();
        }

        private void FillHistoryGrid(ICollection historyEventsData)
        {
            if (historyEventsData != null && historyEventsData.Count > 0)
            {
                foreach (var row in historyEventsData)
                {
                    if (row is string[])
                    {
                        string[] rowCells = (string[])row;
                        historyEventsGrid.Rows.Add(rowCells[0], rowCells[1], rowCells[2]);
                    }
                }
            }
        }
    }
}
