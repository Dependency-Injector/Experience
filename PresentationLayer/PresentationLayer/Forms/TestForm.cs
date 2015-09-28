using System;
using Autofac;
using BussinessLogicLayer.Interfaces;
using BussinessLogicLayer.Presenters;
using DataAccessLayer.Repositories;
using DataAccessLayer.Repositories.Interfaces;
using DataAccessLayer.Services;
using DataAccessLayer.Services.Interfaces;
using DataAccessLayer.Utilities;
using MetroFramework.Forms;
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
        private LoggedUserPresenter loggedUserPresenter;

        private static IContainer Container { get; set; }

        public TestForm()
        {
            InitializeComponent();

            ApplicationSettings.Load();

            PrepareStyleManager();
            BuildAutofac();
            BindLoginPresentersToControls();
            AttachEvents();

            if (ApplicationSettings.Current.IsAnyUserLoggedIn)
            {
                BindContentPresentersToControls();
                UpdateUiForLoginState(LoginState.LoggedIn);
            }
            else
            {
                UpdateUiForLoginState(LoginState.LoggedOut);
            }
        }

        #region Events

        private void TestForm_Load(object sender, EventArgs e)
        {
            this.tasksControl.SetColumnNames();
            this.contentTabControl.SelectedTab = tasksTabPage;
        }

        private void LoginControlOnLogin(object sender, EventArgs eventArgs)
        {
            UpdateUiForLoginState(LoginState.LoggedIn);
            BindContentPresentersToControls();
        }

        private void LoggedUserControl_Logout(object sender, EventArgs e)
        {
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
            loginControl.Login += LoginControlOnLogin;
            loggedUserControl.Logout += LoggedUserControl_Logout;
        }

        private void BindLoginPresentersToControls()
        {
            try
            {
                loginPresenter = Container.Resolve<LoginPresenter>();
            }
            catch (Exception e)
            {
                Logger.Exception(e);
            }
        }

        private void BindContentPresentersToControls()
        {
            try
            {
                loggedUserPresenter = Container.Resolve<LoggedUserPresenter>();
                taskPresenter = Container.Resolve<TaskPresenter>();
                profilePresenter = Container.Resolve<ProfilePresenter>();
                optionsPresenter = Container.Resolve<OptionsPresenter>();
                historyPresenter = Container.Resolve<HistoryPresenter>();
                dayPresenter = Container.Resolve<DayPresenter>();
            }
            catch (Exception e)
            {
                Logger.Exception(e);
            }
        }

        private void BuildAutofac()
        {
            var builder = new ContainerBuilder();

            #region Instance (interfaces) registration

            builder.RegisterInstance(this.dayControl).As<IDayView>();
            builder.RegisterInstance(this.profileControl).As<IProfileView>();
            builder.RegisterInstance(this.tasksControl).As<ITasksView>();
            builder.RegisterInstance(this.historyControl2).As<IHistoryView>();
            builder.RegisterInstance(this.loginControl).As<ILoginView>();
            builder.RegisterInstance(this.optionsControl).As<IOptionsView>();
            builder.RegisterInstance(this.loggedUserControl).As<ILoggedUserView>();

            #endregion

            #region Type registration

            builder.RegisterType<DaysRepository>().As<IDaysRepository>();
            builder.RegisterType<ProfileRepository>().As<IProfileRepository>();
            builder.RegisterType<HistoryEventsRepository>().As<IHistoryEventsRepository>();
            builder.RegisterType<PreferencesRepository>().As<IPreferencesRepository>();
            builder.RegisterType<SkillsRepository>().As<ISkillsRepository>();
            builder.RegisterType<TasksRepository>().As<ITasksRepository>();
            builder.RegisterType<WorkUnitsRepository>().As<IWorkUnitsRepository>();

            builder.RegisterType<DaysService>().As<IDaysService>();
            builder.RegisterType<TaskService>().As<ITaskService>();
            builder.RegisterType<HistoryService>().As<IHistoryService>();
            builder.RegisterType<SkillsService>().As<ISkillsService>();
            builder.RegisterType<ProfileService>().As<IProfileService>();
            builder.RegisterType<WorkUnitsService>().As<IWorkUnitsService>();

            #endregion

            #region Presenters registration

            builder.Register(
                c =>
                    new DayPresenter(
                        c.Resolve<IDayView>(),
                        c.Resolve<IDaysRepository>(),
                        c.Resolve<IProfileRepository>(),
                        c.Resolve<IDaysService>()));

            builder.Register(
                c =>
                    new ProfilePresenter(
                        c.Resolve<IProfileView>(),
                        c.Resolve<IProfileRepository>(),
                        c.Resolve<IHistoryEventsRepository>(),
                        c.Resolve<ISkillsService>()));

            builder.Register(
                c =>
                    new LoginPresenter(
                        c.Resolve<ILoginView>(),
                        c.Resolve<IProfileRepository>()));

            builder.Register(
                c =>
                    new TaskPresenter(
                        c.Resolve<ITasksView>(),
                        c.Resolve<ITasksRepository>(),
                        c.Resolve<IWorkUnitsRepository>(),
                        c.Resolve<ISkillsRepository>(),
                        c.Resolve<IProfileRepository>(),
                        c.Resolve<IHistoryService>(),
                        c.Resolve<ITaskService>(),
                        c.Resolve<IProfileService>(),
                        c.Resolve<IWorkUnitsService>()));

            builder.Register(
                c =>
                    new HistoryPresenter(
                        c.Resolve<IHistoryView>(),
                        c.Resolve<IHistoryEventsRepository>(),
                        c.Resolve<IProfileRepository>()));

            builder.Register(
                c =>
                    new OptionsPresenter(
                        c.Resolve<IOptionsView>(),
                        c.Resolve<IPreferencesRepository>()));

            builder.Register(
                c => 
                    new LoggedUserPresenter(
                        c.Resolve<ILoggedUserView>(),
                        c.Resolve<IProfileRepository>()));

            #endregion

            #region Services registration

            builder.Register(
                c =>
                    new TaskService(
                        c.Resolve<ITasksRepository>(),
                        c.Resolve<ISkillsRepository>(),
                        c.Resolve<IWorkUnitsRepository>(),
                        c.Resolve<IProfileRepository>(),
                        c.Resolve<IHistoryService>()));

            builder.Register(
                c =>
                    new HistoryService(
                        c.Resolve<IHistoryEventsRepository>(),
                        c.Resolve<ITasksRepository>(),
                        c.Resolve<IWorkUnitsRepository>(),
                        c.Resolve<ISkillsRepository>(),
                        c.Resolve<IDaysRepository>(),
                        c.Resolve<IProfileRepository>()));

            builder.Register(
                c => new DaysService(
                    c.Resolve<IDaysRepository>(),
                    c.Resolve<IProfileRepository>(),
                    c.Resolve<IHistoryService>()));

            builder.Register(
                c => new SkillsService(
                    c.Resolve<ISkillsRepository>(),
                    c.Resolve<IProfileRepository>(),
                    c.Resolve<IHistoryService>()));

            builder.Register(
                c => new ProfileService(
                    c.Resolve<IProfileRepository>(),
                    c.Resolve<ISkillsRepository>()));

            builder.Register(
                c => new WorkUnitsService(
                    c.Resolve<IWorkUnitsRepository>(),
                    c.Resolve<ITasksRepository>(),
                    c.Resolve<IHistoryService>()));

            #endregion

            Container = builder.Build();
        }

        private void UpdateUiForLoginState(LoginState loginState)
        {
            switch (loginState)
            {
                case LoginState.LoggedIn:
                    //FadeIn();

                    loginControl.Visible = false;
                    contentTabControl.Visible = true;
                    loggedUserControl.Visible = true;
                    loggedUserControl.LoggedUserName = ApplicationSettings.Current.CurrentUserName;
                    break;

                case LoginState.LoggedOut:
                    loginControl.Visible = true;
                    contentTabControl.Visible = false;
                    loggedUserControl.Visible = false;
                    loggedUserControl.LoggedUserName = null;
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
            timer.Interval = duration / steps;

            int currentStep = 0;
            timer.Tick += (arg1, arg2) =>
            {
                Opacity = ((double)currentStep) / steps;
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
            timer.Interval = duration / steps;

            int currentStep = 0;
            timer.Tick += (arg1, arg2) =>
            {
                Opacity = -(((double)currentStep) / steps);
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
