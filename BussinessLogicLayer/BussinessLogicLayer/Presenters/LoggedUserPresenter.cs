using System;
using BussinessLogicLayer.Interfaces;
using DataAccessLayer.Repositories.Interfaces;
using DataAccessLayer.Utilities;
using Model.Entities;
using Utilities;

namespace BussinessLogicLayer.Presenters
{
    public class LoggedUserPresenter
    {
        private readonly ILoggedUserView view;
        private readonly IProfileRepository profilesRepository;

        public LoggedUserPresenter(ILoggedUserView view, IProfileRepository profilesRepository)
        {
            this.view = view;
            this.profilesRepository = profilesRepository;

            //Initialize();
        }

        public void Initialize()
        {
            try
            {
                AttachEvents();
                
                if (ApplicationSettings.Current.IsAnyUserLoggedIn && ApplicationSettings.Current.CurrentUserId.HasValue)
                {
                    Profile currentUserProfile = profilesRepository.Get(ApplicationSettings.Current.CurrentUserId.Value);
                    if (currentUserProfile != null)
                        DisplayLoggedUserName(currentUserProfile);
                }
            }
            catch (Exception e)
            {
                Logger.Exception(e);
            }
        }

        private void DisplayLoggedUserName(Profile loggedUser)
        {
            view.LoggedUserName = loggedUser.Name;
        }

        private void AttachEvents()
        {
            view.Logout += LogoutUser;
        }

        private void LogoutUser(object sender, EventArgs e)
        {
            ApplicationSettings.Current.IsAnyUserLoggedIn = false;
            ApplicationSettings.Current.CurrentUserId = null;
            ApplicationSettings.Current.CurrentUserName = null;
            ApplicationSettings.Save();
        }
    }
}
