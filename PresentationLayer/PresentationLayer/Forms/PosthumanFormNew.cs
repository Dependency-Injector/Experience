using System;
using Autofac;
using BussinessLogicLayer.Enums;
using BussinessLogicLayer.Events;
using BussinessLogicLayer.Interfaces;
using BussinessLogicLayer.Presenters;
using DataAccessLayer.Repositories;
using DataAccessLayer.Repositories.Interfaces;
using DataAccessLayer.Services;
using DataAccessLayer.Services.Interfaces;
using MetroFramework.Components;
using MetroFramework.Forms;
using Utilities;
using IContainer = Autofac.IContainer;

namespace PresentationLayer.Forms
{
    
    public partial class PosthumanFormNew : MetroForm, ICanHandle<WindowClosed>, ICanHandle<OpenTaskDetailsWindow>
    {
        private MainPresenter mainPresenter;
        private NotificationForm notificationForm = new NotificationForm();
        private TaskEditForm taskEditForm = new TaskEditForm();

        EventBroker broker = new EventBroker();
        private IPublisher Publisher;
        private ISubscriber subscriber;

        public static IContainer Container { get; set; }

        public PosthumanFormNew()
        {
            InitializeComponent();
            GC.Collect();
            ApplicationSettings.Load();
            BuildAutofac();

            subscriber = Container.Resolve<ISubscriber>();
            subscriber.Subscribe(this);

            mainPresenter = Container.Resolve<MainPresenter>();
            mainPresenter.Initialize();

            PrepareStyleManager();
        }

        private void BuildAutofac()
        {
            var builder = new ContainerBuilder();

            #region Instance (interfaces) registration

            builder.RegisterInstance(this.mainControl1).As<IMainView>();
            builder.RegisterInstance(this.mainControl1.DayView).As<IDayView>();
            builder.RegisterInstance(this.mainControl1.ProfileView).As<IProfileView>();
            builder.RegisterInstance(this.mainControl1.TasksListView).As<ITasksListView>();
            builder.RegisterInstance(this.mainControl1.HistoryView).As<IHistoryView>();
            builder.RegisterInstance(this.mainControl1.OptionsView).As<IOptionsView>();
            builder.RegisterInstance(this.notificationForm).As<INotificationView>();

            builder.RegisterInstance(this.taskEditForm).As<ITaskEditView>();

            builder.RegisterInstance(this.broker).As<IPublisher>();
            builder.RegisterInstance(this.broker).As<ISubscriber>();
            //builder.RegisterInstance()

            #endregion

            #region Type registration

            builder.RegisterType<DaysRepository>().As<IDaysRepository>();
            builder.RegisterType<ProfileRepository>().As<IProfileRepository>();
            builder.RegisterType<HistoryEventsRepository>().As<IHistoryEventsRepository>();
            builder.RegisterType<PreferencesRepository>().As<IPreferencesRepository>();
            builder.RegisterType<SkillsRepository>().As<ISkillsRepository>();
            builder.RegisterType<TasksRepository>().As<ITasksRepository>();
            builder.RegisterType<WorkUnitsRepository>().As<IWorkUnitsRepository>();
            builder.RegisterType<ImprovementsRepository>().As<IImprovementsRepository>();

            builder.RegisterType<DaysService>().As<IDaysService>();
            builder.RegisterType<TasksService>().As<ITasksService>();
            builder.RegisterType<HistoryService>().As<IHistoryService>();
            builder.RegisterType<SkillsService>().As<ISkillsService>();
            builder.RegisterType<ProfileService>().As<IProfileService>();
            builder.RegisterType<WorkUnitsService>().As<IWorkUnitsService>();
            builder.RegisterType<PreferencesService>().As<IPreferencesService>();
            builder.RegisterType<ImprovementsService>().As<IImprovementsService>();

            #endregion

            #region Presenters registration

            builder.Register(
                c =>
                    new DayPresenter(
                        c.Resolve<IDayView>(),
                        c.Resolve<IDaysRepository>(),
                        c.Resolve<IProfileRepository>(),
                        c.Resolve<IDaysService>(),
                        c.Resolve<IImprovementsService>(),
                        c.Resolve<IProfileService>(),
                        c.Resolve<IHistoryService>()));

            builder.Register(
                c =>
                    new ProfilePresenter(
                        c.Resolve<IProfileView>(),
                        c.Resolve<IProfileRepository>(),
                        c.Resolve<IHistoryEventsRepository>(),
                        c.Resolve<ISkillsService>(),
                        c.Resolve<IImprovementsRepository>(),
                        c.Resolve<IImprovementsService>()));

            builder.Register(
                c =>
                    new LoginPresenter(
                        c.Resolve<ILoginView>(),
                        c.Resolve<IProfileRepository>(),
                        c.Resolve<IProfileService>()));

            builder.Register(
                c =>
                    new TasksListPresenter(
                        c.Resolve<ITasksListView>(),
                        c.Resolve<ITasksRepository>(),
                        c.Resolve<IWorkUnitsRepository>(),
                        c.Resolve<ISkillsRepository>(),
                        c.Resolve<IProfileRepository>(),
                        c.Resolve<IHistoryService>(),
                        c.Resolve<ITasksService>(),
                        c.Resolve<IProfileService>(),
                        c.Resolve<IWorkUnitsService>(),
                        c.Resolve<IImprovementsService>(),
                        c.Resolve<IPublisher>()));

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
                        c.Resolve<IPreferencesRepository>(),
                        c.Resolve<IPreferencesService>()));

            builder.Register(
                c =>
                    new LoggedUserPresenter(
                        c.Resolve<ILoggedUserView>(),
                        c.Resolve<IProfileRepository>()));
            
            builder.Register(
                c => new NotificationPresenter(
                    c.Resolve<INotificationView>()));

            builder.Register(
                c => new TaskEditPresenter(
                    c.Resolve<ITaskEditView>(),
                    c.Resolve<ITasksRepository>(),
                    c.Resolve<IWorkUnitsRepository>(),
                    c.Resolve<ISkillsRepository>(),
                    c.Resolve<IHistoryService>(),
                    c.Resolve<ITasksService>(),
                    c.Resolve<IProfileService>(),
                    c.Resolve<IWorkUnitsService>(),
                    c.Resolve<IImprovementsService>(),
                    c.Resolve<IPublisher>(),
                    c.Resolve<ISubscriber>()));

            builder.Register(
                c => new MainPresenter(
                    c.Resolve<IMainView>(), 
                    c.Resolve<DayPresenter>(),
                    c.Resolve<TasksListPresenter>(),
                    c.Resolve<ProfilePresenter>(),
                    c.Resolve<HistoryPresenter>(),
                    c.Resolve<OptionsPresenter>(),
                    c.Resolve<NotificationPresenter>(),
                    c.Resolve<TaskEditPresenter>()));
            
            #endregion

            #region Services registration

            builder.Register(
                c =>
                    new TasksService(
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
                    c.Resolve<IProfileRepository>()));

            builder.Register(
                c => new SkillsService(
                    c.Resolve<ISkillsRepository>(),
                    c.Resolve<IProfileRepository>(),
                    c.Resolve<IHistoryService>()));

            builder.Register(
                c => new ProfileService(
                    c.Resolve<IProfileRepository>(),
                    c.Resolve<ISkillsRepository>(),
                    c.Resolve<IHistoryService>()));

            builder.Register(
                c => new WorkUnitsService(
                    c.Resolve<IWorkUnitsRepository>(),
                    c.Resolve<ITasksRepository>(),
                    c.Resolve<IHistoryService>()));

            builder.Register(
                c => new PreferencesService(
                    c.Resolve<IPreferencesRepository>(),
                    c.Resolve<IProfileRepository>(),
                    c.Resolve<IHistoryService>()));

            builder.Register(
                c => new ImprovementsService(
                    c.Resolve<IImprovementsRepository>(),
                    c.Resolve<IProfileRepository>(),
                    c.Resolve<IHistoryService>(),
                    c.Resolve<ITasksRepository>(),
                    c.Resolve<ISkillsRepository>()));
            #endregion

            Container = builder.Build();
        }

        private void PrepareStyleManager()
        {
            this.StyleManager = (MetroStyleManager)mainPresenter.GetStyleManager();
            this.StyleManager.Owner = this;

            notificationForm.Theme = this.Theme;
            notificationForm.Style = this.Style;
            notificationForm.StyleManager = this.StyleManager.Clone(notificationForm) as MetroStyleManager;

            taskEditForm.Theme = this.Theme;
            taskEditForm.Style = this.Style;
            taskEditForm.StyleManager = this.StyleManager.Clone(taskEditForm) as MetroStyleManager;
        }

        public void Handle(WindowClosed data)
        {
            switch (data.Type)
            {
                case WindowType.TaskViewEdit:
                    taskEditForm.Close();
                    break;
            }
        }

        public void Handle(OpenTaskDetailsWindow eventData)
        {
              taskEditForm.Show();
        }
    }
}
