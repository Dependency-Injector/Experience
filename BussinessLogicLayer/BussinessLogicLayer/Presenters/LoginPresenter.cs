using System;
using System.Linq;
using BussinessLogicLayer.Interfaces;
using DataAccessLayer.Repositories.Interfaces;
using DataAccessLayer.Services.Interfaces;
using DataAccessLayer.Utilities;
using Model.Entities;
using Model.Enums;
using Utilities;

namespace BussinessLogicLayer.Presenters
{
    public class LoginPresenter
    {
        private readonly ILoginView view;
        private readonly IProfileRepository profilesRepository;
        private readonly IProfileService profilesService;

        public LoginPresenter(ILoginView view, IProfileRepository profilesRepository, IProfileService profilesService)
        {
            this.view = view;
            this.profilesRepository = profilesRepository;
            this.profilesService = profilesService;
        }

        public void Initialize()
        {
            try
            {
                AttachEvents();

                // Are there any users? If yes, display them in combo box, if no switch control to edit mode
                if (profilesRepository.HasProfile())
                {
                     DisplayUserProfilesList();
                     SetDisplayMode(DisplayMode.View);
                }
                else
                {
                    SetDisplayMode(DisplayMode.Edit);
                }
                
                /*// Last time user did not logged out - he is still logged in, here is code that lets him in
                if (ApplicationSettings.Current.IsAnyUserLoggedIn && ApplicationSettings.Current.CurrentUserId.HasValue)
                {
                    Profile currentUserProfile = profilesRepository.Get(ApplicationSettings.Current.CurrentUserId.Value);
                    if (currentUserProfile != null)
                        SaveLoggedUserInfoToApplicationSettings(currentUserProfile);
                }
                // No user is currently logged in - display list of profiles to select one of them
                else
                {
                    DisplayUserProfilesList();
                }*/
            }
            catch (Exception e)
            {
                Logger.Exception(e);
            }
        }

        private void DisplayUserProfilesList()
        {
            var profiles = profilesRepository.GetAll().ToList();
            view.AvailableUsers = profiles;
        }

        private void AttachEvents()
        {
            view.Login += LoginUser;
            view.NewUser += NewUser;
        }

        private void NewUser(object sender, EventArgs e)
        {
            SetDisplayMode(DisplayMode.Edit);
        }

        private void SaveLoggedUserInfoToApplicationSettings(Profile userToLog)
        {
            ApplicationSettings.Current.IsAnyUserLoggedIn = true;
            ApplicationSettings.Current.CurrentUserId = userToLog.Id;
            ApplicationSettings.Current.CurrentUserName = userToLog.Name;
            ApplicationSettings.Save();
        }

        private void LoginUser(object sender, EventArgs e)
        {
            if (view.UserForBeingLoggedInId.HasValue)
            {
                var userToLogin = profilesRepository.Get(view.UserForBeingLoggedInId.Value);
                if (userToLogin != null)
                    SaveLoggedUserInfoToApplicationSettings(userToLogin);
            }
            else
            {
                Profile newUser = profilesService.CreateNewProfile(view.UserNameToRegister);
                profilesRepository.Add(newUser);
                SaveLoggedUserInfoToApplicationSettings(newUser);
            }

            SetDisplayMode(DisplayMode.View);
        }
        
        private void SetDisplayMode(DisplayMode displayMode)
        {
            if (displayMode == DisplayMode.Edit)
            {
                view.ProfilesListVisible = false;
                view.NewUserNameTextBoxVisible = true;
            }
            else if (displayMode == DisplayMode.View)
            {
                view.ProfilesListVisible = true;
                view.NewUserNameTextBoxVisible = false;
            }
        }
    }
}
