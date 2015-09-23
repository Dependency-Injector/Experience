using System;

namespace BussinessLogicLayer.Interfaces
{
    public interface ILoggedUserView
    {
        String LoggedUserName { get; set; }
        event EventHandler<EventArgs> Logout;
    }
}
