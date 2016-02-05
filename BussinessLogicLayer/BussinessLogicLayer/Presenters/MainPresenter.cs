using System;
using BussinessLogicLayer.Enums;
using BussinessLogicLayer.Events;
using BussinessLogicLayer.Interfaces;
using DataAccessLayer.Utilities;
using Model.Entities;

namespace BussinessLogicLayer.Presenters
{
    public class MainPresenter
    {
        private DayPresenter dayPresenter;
        private TodoListPresenter todoListsPresenter;
        private ProfilePresenter profilePresenter;
        private HistoryPresenter historyPresenter;
        private OptionsPresenter optionsPresenter;
        private LoginPresenter loginPresenter;
        private LoggedUserPresenter loggedUserPresenter;
        private NotificationPresenter notificationPresenter;

        private TaskEditPresenter taskEditPresenter;

        private IMainView mainView;
        
        public MainPresenter(IMainView mainView, DayPresenter dayPresenter, TodoListPresenter todoListsPresenter, ProfilePresenter profilePresenter, HistoryPresenter historyPresenter, OptionsPresenter optionsPresenter, NotificationPresenter notificationPresenter, TaskEditPresenter taskEditPresenter)
        {
            this.mainView = mainView;
            this.dayPresenter = dayPresenter;
            this.todoListsPresenter = todoListsPresenter;
            this.profilePresenter = profilePresenter;
            this.historyPresenter = historyPresenter;
            this.optionsPresenter = optionsPresenter;
            this.notificationPresenter = notificationPresenter;

            this.taskEditPresenter = taskEditPresenter;
        }
        
        public void Initialize()
        {
            AttachEvents();

            dayPresenter.Initialize();
            todoListsPresenter.Initialize();
            profilePresenter.Initialize();
            historyPresenter.Initialize();
            optionsPresenter.Initialize();
            notificationPresenter.Initialize();

            taskEditPresenter.Initialize();
        }

        private void AttachEvents()
        {
            mainView.SubViewDisplayed += SubViewDisplayed;
            dayPresenter.NotificationAppeared += NotificationAppeared;
            todoListsPresenter.NotificationAppeared += NotificationAppeared;
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
    }

    
}
