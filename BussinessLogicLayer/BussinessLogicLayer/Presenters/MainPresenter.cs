using System;
using BussinessLogicLayer.Events;
using BussinessLogicLayer.Interfaces;

namespace BussinessLogicLayer.Presenters
{
    public class MainPresenter
    {
        private DayPresenter dayPresenter;
        private TaskPresenter tasksPresenter;
        private ProfilePresenter profilePresenter;
        private HistoryPresenter historyPresenter;
        private OptionsPresenter optionsPresenter;
        private LoginPresenter loginPresenter;
        private LoggedUserPresenter loggedUserPresenter;
        private NotificationPresenter notificationPresenter;

        private IMainView mainView;
        
        public MainPresenter(IMainView mainView, DayPresenter dayPresenter, TaskPresenter tasksPresenter, ProfilePresenter profilePresenter, HistoryPresenter historyPresenter, OptionsPresenter optionsPresenter, NotificationPresenter notificationPresenter)
        {
            this.mainView = mainView;
            this.dayPresenter = dayPresenter;
            this.tasksPresenter = tasksPresenter;
            this.profilePresenter = profilePresenter;
            this.historyPresenter = historyPresenter;
            this.optionsPresenter = optionsPresenter;
            this.notificationPresenter = notificationPresenter;
        }
        
        public void Initialize()
        {
            AttachEvents();

            dayPresenter.Initialize();
            tasksPresenter.Initialize();
            profilePresenter.Initialize();
            historyPresenter.Initialize();
            optionsPresenter.Initialize();
            notificationPresenter.Initialize();
        }

        private void AttachEvents()
        {
            mainView.SubViewDisplayed += SubViewDisplayed;
            dayPresenter.NotificationAppeared += NotificationAppeared;
            tasksPresenter.NotificationAppeared += NotificationAppeared;
            profilePresenter.NotificationAppeared += NotificationAppeared;
            historyPresenter.NotificationAppeared += NotificationAppeared;
            optionsPresenter.NotificationAppeared += NotificationAppeared;
        }

        

        private void NotificationAppeared(object sender, ShowNotificationEventArgs eventArgs)
        {
            notificationPresenter.ShowNotification(eventArgs.Title, eventArgs.Text);
        }

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
                    tasksPresenter.OnViewDisplayed();
                    break;
                case SubViewType.Unknown:
                    break;
            }
        }
        
        public object GetStyleManager()
        {
            return this.optionsPresenter.GetStyleManager();
        }
    }
}
