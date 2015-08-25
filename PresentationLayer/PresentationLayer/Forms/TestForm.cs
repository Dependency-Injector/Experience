using System;
using Autofac;
using BussinessLogicLayer.Presenters;
using DataAccessLayer.Repositories;
using DataAccessLayer.Repositories.Interfaces;
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

        public enum LoginState
        {
            LoggedIn,
            LoggedOut
        }
        public TestForm()
        {
            InitializeComponent();

            this.StyleManager = optionsControl.GetStyleManager();
            this.StyleManager.Owner = this;

            UpdateUiForLoginState(LoginState.LoggedOut);

            BuildAutofac();

            loginPresenter = new LoginPresenter(this.loginControl1);
            taskPresenter = new TaskPresenter(this.tasksControl1);
            profilePresenter = new ProfilePresenter(this.profileControl);
            optionsPresenter = new OptionsPresenter(this.optionsControl);
            historyPresenter = new HistoryPresenter(this.historyControl2);
            dayPresenter = new DayPresenter(this.dayControl, new DaysRepository());

            loginControl1.Login += LoginControl1OnLogin;
            loggedUserControl1.Logout += LoggedUserControl1_Logout;
        }

        private static IContainer Container { get; set; }
        private void BuildAutofac()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<DayPresenter>().As<IDaysRepository>();
        }

        private void LoginControl1OnLogin(object sender, EventArgs eventArgs)
        {
            UpdateUiForLoginState(LoginState.LoggedIn);
            loggedUserControl1.LoggedUserName = loginControl1.UserNameToRegister;
        }

        private void LoggedUserControl1_Logout(object sender, EventArgs e)
        {
            UpdateUiForLoginState(LoginState.LoggedOut);
        }

        private void UpdateUiForLoginState(LoginState loginState)
        {
            switch (loginState)
            {
                case LoginState.LoggedIn:
                    loginControl1.Visible = false;
                    contentTabControl.Visible = true;
                    break;

                case LoginState.LoggedOut:
                    loginControl1.Visible = true;
                    contentTabControl.Visible = false;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(loginState), loginState, null);
            }
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
