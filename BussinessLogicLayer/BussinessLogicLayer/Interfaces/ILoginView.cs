using System;
using System.Collections;
//using Model.Enums;

namespace BussinessLogicLayer.Interfaces
{
    public interface ILoginView
    {
        int? UserForBeingLoggedInId { get;  }
        String UserNameToRegister { get; }
        ICollection AvailableUsers { set; }

        bool ProfilesListVisible { set; }
        bool NewUserNameTextBoxVisible { set; }
        //bool Hidden { set; }
        //bool IsNew { get; set; }

        event EventHandler<EventArgs> Login;
        event EventHandler<EventArgs> SaveUser;
        event EventHandler<EventArgs> NewUser;

        // DisplayMode DisplayMode { set; }
    }
}
