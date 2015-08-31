using System;
using System.Timers;
using System.Windows.Forms;
using Autofac;
using BussinessLogicLayer.Interfaces;
using BussinessLogicLayer.Presenters;
using DataAccessLayer.Repositories;
using DataAccessLayer.Repositories.Interfaces;
using DataAccessLayer.Utilities;
using MetroFramework;
using MetroFramework.Forms;
using Model.Entities;
using Model.Migrations;
using Utilities;
using Utilities.Enums;
using Timer = System.Windows.Forms.Timer;

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

        private static IContainer Container { get; set; }

        public TestForm()
        {
            InitializeComponent();

            ApplicationSettings.Load();

            PrepareStyleManager();
            UpdateUiForLoginState(LoginState.LoggedOut);
            BuildAutofac();
            AttachEvents();


            BindPresentersToControls();

            if (ApplicationSettings.Current.IsAnyUserLoggedIn)
            {
                UpdateUiForLoginState(LoginState.LoggedIn);
                loggedUserControl1.LoggedUserName = ApplicationSettings.Current.CurrentUserName;

            }
            else
            {
                UpdateUiForLoginState(LoginState.LoggedOut);
            }
        }

        #region Events

        private void TestForm_Load(object sender, EventArgs e)
        {
            this.tasksControl1.SetColumnNames();
            this.contentTabControl.SelectedTab = tasksTabPage;
        }

        private void LoginControl1OnLogin(object sender, EventArgs eventArgs)
        {
            UpdateUiForLoginState(LoginState.LoggedIn);
        }

        private void LoggedUserControl1_Logout(object sender, EventArgs e)
        {
            ApplicationSettings.Current.IsAnyUserLoggedIn = false;
            ApplicationSettings.Current.CurrentUserId = null;
            ApplicationSettings.Current.CurrentUserName = null;
            ApplicationSettings.Save();

            UpdateUiForLoginState(LoginState.LoggedOut);
        }

        #endregion

        #region Private methods

        private void PrepareStyleManager()
        {
            this.StyleManager = optionsControl.GetStyleManager();
            this.StyleManager.Owner = this;
        }

        private void AttachEvents()
        {
            loginControl1.Login += LoginControl1OnLogin;
            loggedUserControl1.Logout += LoggedUserControl1_Logout;
        }

        private void BindPresentersToControls()
        {
            try
            {

                loginPresenter = Container.Resolve<LoginPresenter>();
                taskPresenter = Container.Resolve<TaskPresenter>();
                profilePresenter = Container.Resolve<ProfilePresenter>();
                optionsPresenter = Container.Resolve<OptionsPresenter>();
                historyPresenter = Container.Resolve<HistoryPresenter>(); //new HistoryPresenter(this.historyControl2));
                dayPresenter = Container.Resolve<DayPresenter>();
                    //new DayPresenter(this.dayControl, new DaysRepository());

            }
            catch (Exception e)
            {
                Logger.Exception(e);

            }
        }

        private void BuildAutofac()
        {
            var builder = new ContainerBuilder();
            builder.RegisterInstance(this.dayControl).As<IDayView>();
            builder.RegisterInstance(this.profileControl).As<IProfileView>();
            builder.RegisterInstance(this.tasksControl1).As<ITasksView>();
            builder.RegisterInstance(this.historyControl2).As<IHistoryView>();
            builder.RegisterInstance(this.loginControl1).As<ILoginView>();
            builder.RegisterInstance(this.optionsControl).As<IOptionsView>();

            builder.RegisterType<DaysRepository>().As<IDaysRepository>();
            builder.RegisterType<ProfileRepository>().As<IProfileRepository>();
            builder.RegisterType<HistoryEventsRepository>().As<IHistoryEventsRepository>();
            builder.RegisterType<PreferencesRepository>().As<IPreferencesRepository>();
            builder.RegisterType<SkillsRepository>().As<ISkillsRepository>();
            builder.RegisterType<TasksRepository>().As<ITasksRepository>();
            builder.RegisterType<WorkUnitsRepository>().As<IWorkUnitsRepository>();

            builder.Register(
                c =>
                    new DayPresenter(c.Resolve<IDayView>(), c.Resolve<IDaysRepository>(),
                        c.Resolve<IProfileRepository>()));
            builder.Register(
                c =>
                    new ProfilePresenter(c.Resolve<IProfileView>(), c.Resolve<IProfileRepository>(),
                        c.Resolve<IHistoryEventsRepository>()));
            builder.Register(c => new LoginPresenter(c.Resolve<ILoginView>(), c.Resolve<IProfileRepository>()));
            builder.Register(
                c =>
                    new TaskPresenter(c.Resolve<ITasksView>(), c.Resolve<ITasksRepository>(),
                        c.Resolve<IWorkUnitsRepository>(), c.Resolve<ISkillsRepository>(),
                        c.Resolve<IProfileRepository>()));
            builder.Register(c => new HistoryPresenter(c.Resolve<IHistoryView>(), c.Resolve<IHistoryEventsRepository>()));
            builder.Register(c => new OptionsPresenter(c.Resolve<IOptionsView>(), c.Resolve<IPreferencesRepository>()));

            Container = builder.Build();
        }

        private void UpdateUiForLoginState(LoginState loginState)
        {
            switch (loginState)
            {
                case LoginState.LoggedIn:
                    FadeIn();

                    loginControl1.Visible = false;
                    contentTabControl.Visible = true;
                    loggedUserControl1.Visible = true;
                    loggedUserControl1.LoggedUserName = ApplicationSettings.Current.CurrentUserName;
                    break;

                case LoginState.LoggedOut:
                    loginControl1.Visible = true;
                    contentTabControl.Visible = false;
                    loggedUserControl1.Visible = false;
                    break;

                default:
                    throw new ArgumentOutOfRangeException(nameof(loginState), loginState, null);
            }
        }

        private void FadeIn()
        {
            int duration = DisplaySettings.FadeInTimeInMiliseconds;
            int steps = 100;
            Timer timer = new Timer();
            timer.Interval = duration/steps;

            int currentStep = 0;
            timer.Tick += (arg1, arg2) =>
            {
                Opacity = ((double) currentStep)/steps;
                currentStep++;

                if (currentStep >= steps)
                {
                    timer.Stop();
                    timer.Dispose();
                }
            };

            timer.Start();
        }

        private void FadeOut()
        {
            int duration = 500; //in milliseconds
            int steps = 100;
            Timer timer = new Timer();
            timer.Interval = duration/steps;

            int currentStep = 0;
            timer.Tick += (arg1, arg2) =>
            {
                Opacity = -(((double) currentStep)/steps);
                currentStep++;

                if (currentStep >= steps)
                {
                    timer.Stop();
                    timer.Dispose();
                }
            };

            timer.Start();
        }

        #endregion
    }
}
