using System.Windows.Forms;
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

        public BindingSource ProfileRelatedEvents
        {
            set
            {
                profileRelatedEventsGrid.DataSource = null;
                profileRelatedEventsGrid.DataSource = value;
            }
        }
    }
}
