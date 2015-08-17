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
using MetroFramework.Controls;

namespace PresentationLayer.Controls
{
    public partial class HistoryControl : MetroUserControl, IHistoryView
    {
        public HistoryControl()
        {
            InitializeComponent();
        }

        private void tasksEventsCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void experienceEventsCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void metroCheckBox2_CheckedChanged(object sender, EventArgs e)
        {

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
    }
}
