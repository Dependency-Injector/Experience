using System;
using BussinessLogicLayer.Enums;
using BussinessLogicLayer.Interfaces;
using MetroFramework.Controls;

namespace View.Controls
{
    public partial class MainControl : MetroUserControl, IMainView
    {
        public IJournalView JournalView { get { return journalControl; } }
        public ITodoListView TodoListView { get { return todoListControl; } }
        public IProfileView ProfileView { get { return profileControl; } }
        public IHistoryView HistoryView { get { return historyControl; } }
        public IOptionsView OptionsView { get { return optionsControl; } }
        public IListsView ListsView { get { return listsControl; } }

        public MainControl()
        {
            InitializeComponent();

            subViewsTabControl.SelectedTab = journalTabPage;
            subViewsTabControl.TabPages.Remove(listsTabPage);
            subViewsTabControl.TabPages.Remove(historyTabPage);
        }
        
        public SubViewType SelectedSubView
        {
            get
            {
                if (subViewsTabControl.SelectedTab == journalTabPage)
                    return SubViewType.Journal;
                else if (subViewsTabControl.SelectedTab == tasksTabPage)
                    return SubViewType.Tasks;
                else if (subViewsTabControl.SelectedTab == profileTabPage)
                    return SubViewType.Profile;
                else if (subViewsTabControl.SelectedTab == optionsTabPage)
                    return SubViewType.Options;
                else if (subViewsTabControl.SelectedTab == historyTabPage)
                    return SubViewType.History;
                else if (subViewsTabControl.SelectedTab == listsTabPage)
                    return SubViewType.Lists;
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
