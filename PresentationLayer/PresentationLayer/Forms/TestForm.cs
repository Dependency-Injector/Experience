using System;
using BussinessLogicLayer.Presenters;
using MetroFramework;
using MetroFramework.Forms;

namespace PresentationLayer.Forms
{
    public partial class TestForm : MetroForm
    {
        private TaskPresenter taskPresenter;
        private ProfilePresenter profilePresenter;
        private OptionsPresenter optionsPresenter;
        private HistoryPresenter historyPresenter;
        private DayPresenter dayPresenter;

        public TestForm()
        {
            InitializeComponent();

            this.StyleManager = optionsControl.GetStyleManager();
            this.StyleManager.Owner = this;

            taskPresenter = new TaskPresenter(this.tasksControl1);
            profilePresenter = new ProfilePresenter(this.profileControl);
            optionsPresenter = new OptionsPresenter(this.optionsControl);
            historyPresenter = new HistoryPresenter(this.historyControl2);
            dayPresenter = new DayPresenter(this.dayControl);
        }

        private void TestForm_Load(object sender, EventArgs e)
        {
            this.tasksControl1.SetColumnNames();
            this.contentTabControl.SelectedTab = tasksTabPage;
        }
    }
}
