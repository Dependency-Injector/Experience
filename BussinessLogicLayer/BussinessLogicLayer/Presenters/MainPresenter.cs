using System;
using BussinessLogicLayer.Events;
using BussinessLogicLayer.Interfaces;

namespace BussinessLogicLayer.Presenters
{
    public class MainPresenter : ICanHandle<ViewHidden>
    {
        private DayPresenter dayPresenter;
        private TodoListPresenter todoListsPresenter;
        private ProfilePresenter profilePresenter;
        private HistoryPresenter historyPresenter;
        private OptionsPresenter optionsPresenter;
        private LoginPresenter loginPresenter;
        private LoggedUserPresenter loggedUserPresenter;
        private NotificationPresenter notificationPresenter;
        private TaskCompositePresenter taskCompositePresenter;
        private ProfileHistoryPresenter profileHistoryPresenter;

        private IMainView mainView;

        private ISubscriber subscriber;

        public MainPresenter(IMainView mainView, DayPresenter dayPresenter, TodoListPresenter todoListsPresenter, ProfilePresenter profilePresenter, HistoryPresenter historyPresenter, OptionsPresenter optionsPresenter, NotificationPresenter notificationPresenter, TaskCompositePresenter taskCompositePresenter, ProfileHistoryPresenter profileHistoryPresenter, ISubscriber subscriber)
        {
            this.mainView = mainView;
            this.dayPresenter = dayPresenter;
            this.todoListsPresenter = todoListsPresenter;
            this.profilePresenter = profilePresenter;
            this.historyPresenter = historyPresenter;
            this.optionsPresenter = optionsPresenter;
            this.notificationPresenter = notificationPresenter;
            this.taskCompositePresenter = taskCompositePresenter;
            this.profileHistoryPresenter = profileHistoryPresenter;
            this.subscriber = subscriber;
        }
        
        public void Initialize()
        {
            AttachEvents();
            InitializeSubpresenters();

            subscriber.Subscribe(this);
        }

        private void InitializeSubpresenters()
        {
            dayPresenter.Initialize();
            todoListsPresenter.Initialize();
            profilePresenter.Initialize();
            historyPresenter.Initialize();
            optionsPresenter.Initialize();
            notificationPresenter.Initialize();
            taskCompositePresenter.Initialize();
            profileHistoryPresenter.Initialize();
        }

        private void AttachEvents()
        {
            mainView.SubViewDisplayed += SubViewDisplayed;
            /*dayPresenter.NotificationAppeared += NotificationAppeared;
            todoListsPresenter.NotificationAppeared += NotificationAppeared;
            profilePresenter.NotificationAppeared += NotificationAppeared;
            historyPresenter.NotificationAppeared += NotificationAppeared;
            optionsPresenter.NotificationAppeared += NotificationAppeared;*/
        }
        
        /*private void NotificationAppeared(object sender, ShowNotificationEventArgs eventArgs)
        {
            notificationPresenter.ShowNotification(eventArgs.Title, eventArgs.Text);
        }*/

        private void SubViewDisplayed(object sender, EventArgs e)
        {
            switch (mainView.SelectedSubView)
            {
                case SubViewType.Day:
                    dayPresenter.OnViewDisplayed();
                    break;
                case SubViewType.History:
                    historyPresenter.OnViewDisplayed();
                    break;
                case SubViewType.Options:
                    optionsPresenter.OnViewDisplayed();
                    break;
                case SubViewType.Profile:
                    profilePresenter.OnViewDisplayed();
                    break;
                case SubViewType.Tasks:
                    todoListsPresenter.OnViewDisplayed();
                    break;
                case SubViewType.Unknown:
                    break;
            }
        }
        
        public object GetStyleManager()
        {
            return this.optionsPresenter.GetStyleManager();
        }

        public void Handle(ViewHidden viewHiddenEventArgs)
        {
            switch (viewHiddenEventArgs.ViewType)
            {
                case SubViewType.Day:
                    break;
                case SubViewType.History:
                    break;
                case SubViewType.Options:
                    break;
                case SubViewType.Profile:
                    break;
                case SubViewType.Tasks:
                    break;
                case SubViewType.Unknown:
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}
