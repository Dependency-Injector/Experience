using System;

namespace BussinessLogicLayer.Interfaces
{
    public interface IAppView
    {
        IDayView DayView { get; set; }
        IProfileView ProfileView { get; set; }

    }
}
