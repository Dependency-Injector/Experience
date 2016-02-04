using System;
using System.CodeDom;
using BussinessLogicLayer.Interfaces;
using MetroFramework.Controls;

namespace PresentationLayer.Controls
{
    public partial class MainControl : MetroUserControl, IMainView
    {
        public MainControl()
        {
            InitializeComponent();
        }

        private void AttachEvents()
        {
        }

        public IDayView DayView { get { return dayControl; } }
        public ITasksListView TasksListView { get { return tasksListControl; } }
        public IProfileView ProfileView { get { return profileControl; } }
        public IHistoryView HistoryView { get { return historyControl; } }
        public IOptionsView OptionsView { get { return optionsControl; } }

        public SubViewType SelectedSubView
        {
            get
            {
                if (subViewsTabControl.SelectedTab == dayTabPage)
                    return SubViewType.Day;
                else if (subViewsTabControl.SelectedTab == tasksTabPage)
                    return SubViewType.Tasks;
                else if (subViewsTabControl.SelectedTab == profileTabPage)
                    return SubViewType.Profile;
                else if (subViewsTabControl.SelectedTab == optionsTabPage)
                    return SubViewType.Options;
                else if (subViewsTabControl.SelectedTab == historyTabPage)
                    return SubViewType.History;
                else return SubViewType.Unknown;
            }
        }

        public event EventHandler<EventArgs> SubViewDisplayed;

        private void contentTabControl_Selected(object sender, System.Windows.Forms.TabControlEventArgs e)
        {
            if (SubViewDisplayed != null)
                SubViewDisplayed(this, e);
        }
    }

}
