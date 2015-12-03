using System;
using System.Collections;

namespace BussinessLogicLayer.Interfaces
{
    public interface ILoginView
    {
        int? UserForBeingLoggedInId { get;  }
        String UserNameToRegister { get; }
        ICollection AvailableUsers { set; }

        bool ProfilesListVisible { set; }
        bool NewUserNameTextBoxVisible { set; }

        event EventHandler<EventArgs> Login;
        event EventHandler<EventArgs> SaveUser;
        event EventHandler<EventArgs> NewUser;
    }
}
