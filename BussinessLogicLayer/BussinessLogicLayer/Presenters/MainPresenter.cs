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
        private TasksListPresenter tasksListsPresenter;
        private ProfilePresenter profilePresenter;
        private HistoryPresenter historyPresenter;
        private OptionsPresenter optionsPresenter;
        private LoginPresenter loginPresenter;
        private LoggedUserPresenter loggedUserPresenter;
        private NotificationPresenter notificationPresenter;

        private TaskEditPresenter taskEditPresenter;

        private IMainView mainView;
        
        public MainPresenter(IMainView mainView, DayPresenter dayPresenter, TasksListPresenter tasksListsPresenter, ProfilePresenter profilePresenter, HistoryPresenter historyPresenter, OptionsPresenter optionsPresenter, NotificationPresenter notificationPresenter, TaskEditPresenter taskEditPresenter)
        {
            this.mainView = mainView;
            this.dayPresenter = dayPresenter;
            this.tasksListsPresenter = tasksListsPresenter;
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
            tasksListsPresenter.Initialize();
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
            tasksListsPresenter.NotificationAppeared += NotificationAppeared;
            profilePresenter.NotificationAppeared += NotificationAppeared;
            historyPresenter.NotificationAppeared += NotificationAppeared;
            optionsPresenter.NotificationAppeared += NotificationAppeared;

            tasksListsPresenter.ViewEditTask += ViewEditTask;
        }

        private void ViewEditTask(object sender, int taskId)
        {
            taskEditPresenter.EditTask(taskId);
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
                    tasksListsPresenter.OnViewDisplayed();
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
