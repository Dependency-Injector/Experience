using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussinessLogicLayer.Interfaces;
using DataAccessLayer.Services;
using MetroFramework.Controls;

namespace PresentationLayer.Controls
{
    public partial class HistoryControl : MetroUserControl, IHistoryView
    {
        private HistoryService historyService;

        public HistoryControl()
        {
            InitializeComponent();

            historyService = new HistoryService();
        }

        private void tasksEventsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowHideTaskEvents != null)
                ShowHideTaskEvents(this, e);
        }

        private void experienceEventsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowHideWorkUnitEvents != null)
                ShowHideWorkUnitEvents(this, e);
        }

        private void metroCheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowHideExperienceEvents != null)
                ShowHideExperienceEvents(this, e);
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

        public ICollection HistoryItems
        {
            set
            {
                
            }
        }
        public ICollection HistoryEventsRows
        {
            set
            {
                ClearHistoryGrid();
                FillHistoryGrid(value);
            }
        }

        public event EventHandler<EventArgs> ShowHideTaskEvents;
        public event EventHandler<EventArgs> ShowHideWorkUnitEvents;
        public event EventHandler<EventArgs> ShowHideExperienceEvents;

        private void ClearHistoryGrid()
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
