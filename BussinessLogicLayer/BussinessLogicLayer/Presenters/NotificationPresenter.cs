using System;
using BussinessLogicLayer.Enums;
using BussinessLogicLayer.Events;
using BussinessLogicLayer.Interfaces;
using DataAccessLayer.Repositories.Interfaces;
using DataAccessLayer.Services.Interfaces;
using DataAccessLayer.Utilities;
using Model.Entities;
using Model.Enums;
using Utilities;

namespace BussinessLogicLayer.Presenters
{
    public class NotificationPresenter : IPresenter, ICanHandle<OpenWindowEvent>
    {
        private readonly INotificationView view;
        private readonly IPublisher publisher;
        public event EventHandler<ShowNotificationEvent> NotificationAppeared;
        
        public NotificationPresenter(INotificationView view, IPublisher publisher)
        {
            this.view = view;
            this.publisher = publisher;
        }
        
        public void Initialize()
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                Logger.Exception(ex);
            }
        }

        public void ShowNotification(string title, string text, NotificationType type = NotificationType.Text, int? oldProgress = null, int? newProgress = null, string progressDescription = null)
        {
            view.Title = title;
            view.AdditionalText = text;

            if (oldProgress.HasValue)
                view.OldProgress = oldProgress.Value;
            if (newProgress.HasValue)
                view.NewProgress = newProgress.Value;
            if (!String.IsNullOrEmpty(progressDescription))
                view.ProgressDescription = progressDescription;

            view.Type = type;
            view.IsVisible = true;

            //publisher.Publish(new OpenWindowEvent(WindowType.NotificationWindow, notification))
        }
        
        public void OnViewDisplayed()
        {
        }

        public void Handle(OpenWindowEvent openNotificationEventArgs)
        {
            if (openNotificationEventArgs.WindowType != WindowType.NotificationWindow)
                return;

            
        }
    }
}
