using System.Collections.Generic;
using System.Windows.Forms;
using BussinessLogicLayer.GridRowTemplates;
using BussinessLogicLayer.Interfaces;
using MetroFramework.Forms;

namespace View.Forms
{
    public partial class ProfileHistoryForm : MetroForm, IProfileHistoryView
    {
        public ProfileHistoryForm()
        {
            InitializeComponent();
        }
        
        public IList<ImprovementGridItem> ProfileEventsGridItems
        {
            set
            {
                profileRelatedEventsGrid.DataSource = null;
                profileRelatedEventsGrid.DataSource = value;
            }
        }
    }
}
