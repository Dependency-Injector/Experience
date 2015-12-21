﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using BussinessLogicLayer.GridRowTemplates;
using BussinessLogicLayer.Interfaces;
using MetroFramework.Controls;

namespace PresentationLayer.Controls
{
    public partial class HistoryControl : MetroUserControl, IHistoryView
    {
        #region Properties

        public IList<HistoryEventGridItem> HistoryEventsGridItems
        {
            set
            {
                historyEventsGrid.DataSource = null;
                historyEventsGrid.DataSource = value;
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

        public HistoryControl()
        {
            InitializeComponent();
        }

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

        private void historyEventsGrid_DataBindingComplete(object sender, System.Windows.Forms.DataGridViewBindingCompleteEventArgs e)
        {
            this.historyEventsGrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.historyEventsGrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.historyEventsGrid.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}
