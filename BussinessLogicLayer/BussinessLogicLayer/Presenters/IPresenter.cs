using System;
using BussinessLogicLayer.Events;

namespace BussinessLogicLayer.Presenters
{
    public interface IPresenter
    {
        void OnViewDisplayed();
        event EventHandler<ShowNotificationEventArgs> NotificationAppeared;
    }
}
