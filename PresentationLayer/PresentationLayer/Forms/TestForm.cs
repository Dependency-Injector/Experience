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
        private LoginPresenter loginPresenter;

        public TestForm()
        {
            InitializeComponent();

            this.StyleManager = optionsControl.GetStyleManager();
            this.StyleManager.Owner = this;

            loggedUserControl1.Logout += LoggedUserControl1_Logout;
            loginPresenter = new LoginPresenter(this.loginControl1);
            taskPresenter = new TaskPresenter(this.tasksControl1);
            profilePresenter = new ProfilePresenter(this.profileControl);
            optionsPresenter = new OptionsPresenter(this.optionsControl);
            historyPresenter = new HistoryPresenter(this.historyControl2);
            dayPresenter = new DayPresenter(this.dayControl);
        }

        private void LoggedUserControl1_Logout(object sender, EventArgs e)
        {
            
            //contentTabControl.Visible = false;
            loginControl1.Visible = true;
        }

        private void TestForm_Load(object sender, EventArgs e)
        {
            this.tasksControl1.SetColumnNames();
            this.contentTabControl.SelectedTab = tasksTabPage;
        }

        private void loginControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
