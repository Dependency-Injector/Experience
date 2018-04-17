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

namespace View.Forms
{
    public partial class PosthumanForm : MetroForm, ICanHandle<OpenWindowEvent>, ICanHandle<ShowNotificationEvent>
    {
        private MainPresenter mainPresenter;
        private NotificationForm notificationForm = new NotificationForm();
        private TaskCompositeForm taskCompositeForm = new TaskCompositeForm();
        private ProfileHistoryForm profileHistoryForm = new ProfileHistoryForm();

        private EventBroker broker = new EventBroker();
        private IPublisher publisher;
        private ISubscriber subscriber;

        public static IContainer Container { get; set; }

        public PosthumanForm()
        {
            InitializeComponent();
            GC.Collect();
            ApplicationSettings.Load();
            BuildAutofac();

            publisher = Container.Resolve<IPublisher>();
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

            builder.RegisterInstance(this.mainControl).As<IMainView>();
            builder.RegisterInstance(this.mainControl.JournalView).As<IJournalView>();
            builder.RegisterInstance(this.mainControl.ProfileView).As<IProfileView>();
            builder.RegisterInstance(this.mainControl.TodoListView).As<ITodoListView>();
            builder.RegisterInstance(this.mainControl.HistoryView).As<IHistoryView>();
            builder.RegisterInstance(this.mainControl.OptionsView).As<IOptionsView>();
            builder.RegisterInstance(this.mainControl.ListsView).As<IListsView>();
            builder.RegisterInstance(this.notificationForm).As<INotificationView>();
            builder.RegisterInstance(this.profileHistoryForm).As<IProfileHistoryView>();
            builder.RegisterInstance(this.taskCompositeForm).As<ITaskCompositeView>();
            builder.RegisterInstance(this.taskCompositeForm.TaskEditView).As<ITaskEditView>();
            builder.RegisterInstance(this.taskCompositeForm.TaskDisplayView).As<ITaskDisplayView>();

            builder.RegisterInstance(this.broker).As<IPublisher>();
            builder.RegisterInstance(this.broker).As<ISubscriber>();

            #endregion

            #region Type registration

            builder.RegisterType<DaysRepository>().As<IJournalRepository>();
            builder.RegisterType<ProfileRepository>().As<IProfileRepository>();
            builder.RegisterType<HistoryEventsRepository>().As<IHistoryEventsRepository>();
            builder.RegisterType<PreferencesRepository>().As<IPreferencesRepository>();
            builder.RegisterType<SkillsRepository>().As<ISkillsRepository>();
            builder.RegisterType<TasksRepository>().As<ITasksRepository>();
            builder.RegisterType<WorkUnitsRepository>().As<IWorkUnitsRepository>();
            builder.RegisterType<ImprovementsRepository>().As<IImprovementsRepository>();

            builder.RegisterType<JournalService>().As<IJournalService>();
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
                    new JournalPresenter(
                        c.Resolve<IJournalView>(),
                        c.Resolve<IJournalRepository>(),
                        c.Resolve<IProfileRepository>(),
                        c.Resolve<IJournalService>(),
                        c.Resolve<IImprovementsService>(),
                        c.Resolve<IProfileService>(),
                        c.Resolve<IHistoryService>()));

            builder.Register(
                c => new ListsPresenter(
                    c.Resolve<IListsView>()));

            builder.Register(
                c =>
                    new ProfilePresenter(
                        c.Resolve<IProfileView>(),
                        c.Resolve<IProfileRepository>(),
                        c.Resolve<IHistoryEventsRepository>(),
                        c.Resolve<ISkillsService>(),
                        c.Resolve<IImprovementsRepository>(),
                        c.Resolve<IImprovementsService>(),
                        c.Resolve<IPublisher>()));

            builder.Register(
                c =>
                    new ProfileHistoryPresenter(
                        c.Resolve<IProfileHistoryView>(),
                        c.Resolve<IProfileRepository>(),
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
                    new TodoListPresenter(
                        c.Resolve<ITodoListView>(),
                        c.Resolve<ITasksRepository>(),
                        c.Resolve<IPublisher>(),
                        c.Resolve<ISubscriber>()));

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
                    c.Resolve<INotificationView>(),
                    c.Resolve<IPublisher>()));

            builder.Register(
                c => new TaskDisplayPresenter(
                    c.Resolve<ITaskDisplayView>(),
                    c.Resolve<ITasksRepository>(),
                    c.Resolve<IHistoryService>(),
                    c.Resolve<ITasksService>(),
                    c.Resolve<IProfileService>(),
                    c.Resolve<IImprovementsService>(),
                    c.Resolve<IPublisher>()));

            builder.Register(
                c => new TaskEditPresenter(
                    c.Resolve<ITaskEditView>(),
                    c.Resolve<ITasksRepository>(),
                    c.Resolve<ISkillsRepository>(),
                    c.Resolve<IHistoryService>(),
                    c.Resolve<ITasksService>(), 
                    c.Resolve<IPublisher>()));

            builder.Register(
                c => new TaskCompositePresenter(
                    c.Resolve<ITaskCompositeView>(),
                    c.Resolve<ITaskDisplayView>(),
                    c.Resolve<ITaskEditView>(),
                    c.Resolve<ITasksRepository>(),
                    c.Resolve<IPublisher>(),
                    c.Resolve<ISubscriber>(),
                    c.Resolve<TaskDisplayPresenter>(),
                    c.Resolve<TaskEditPresenter>()));

            builder.Register(
                c => new MainPresenter(
                    c.Resolve<IMainView>(),
                    c.Resolve<JournalPresenter>(),
                    c.Resolve<TodoListPresenter>(),
                    c.Resolve<ProfilePresenter>(),
                    c.Resolve<HistoryPresenter>(),
                    c.Resolve<OptionsPresenter>(),
                    c.Resolve<NotificationPresenter>(),
                    c.Resolve<TaskCompositePresenter>(),
                    c.Resolve<ProfileHistoryPresenter>(),
                    c.Resolve<ListsPresenter>(),
                    c.Resolve<ISubscriber>()));

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
                        c.Resolve<IJournalRepository>(),
                        c.Resolve<IProfileRepository>()));

            builder.Register(
                c => new JournalService(
                    c.Resolve<IJournalRepository>(),
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

            taskCompositeForm.Theme = this.Theme;
            taskCompositeForm.Style = this.Style;
            taskCompositeForm.StyleManager = this.StyleManager.Clone(taskCompositeForm) as MetroStyleManager;

            profileHistoryForm.Theme = this.Theme;
            profileHistoryForm.Style = this.Style;
            profileHistoryForm.StyleManager = this.StyleManager.Clone(profileHistoryForm) as MetroStyleManager;
        }

        void ICanHandle<OpenWindowEvent>.Handle(OpenWindowEvent openWindowEvent)
        {
            switch (openWindowEvent.WindowType)
            {
                case WindowType.HistoryWindow:
                    if (profileHistoryForm.IsDisposed)
                        profileHistoryForm = new ProfileHistoryForm();
                    profileHistoryForm.Show();
                    break;

                case WindowType.TaskWindow:
                    if (taskCompositeForm.IsDisposed)
                        taskCompositeForm = new TaskCompositeForm();
                    taskCompositeForm.Show();
                    break;

                case WindowType.NotificationWindow:
                    if (notificationForm.IsDisposed)
                        notificationForm = new NotificationForm();
                    notificationForm.Show();
                    break;

                case WindowType.Undefined:
                    break;
            }
        }

        void ICanHandle<ShowNotificationEvent>.Handle(ShowNotificationEvent showNotificationEvent)
        {
            notificationForm.Title = showNotificationEvent.Title;
            notificationForm.AdditionalText = showNotificationEvent.Text;
            publisher.Publish<OpenWindowEvent>(new OpenWindowEvent(WindowType.NotificationWindow));
        }
    }
}
