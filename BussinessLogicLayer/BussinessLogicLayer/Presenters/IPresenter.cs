using System;
using BussinessLogicLayer.Events;

namespace BussinessLogicLayer.Presenters
{
    /// <summary>
    /// Base class for all presenters
    /// </summary>
    public interface IPresenter
    {
        void Initialize();
        void OnViewDisplayed();
        event EventHandler<ShowNotificationEvent> NotificationAppeared;
    }
}
