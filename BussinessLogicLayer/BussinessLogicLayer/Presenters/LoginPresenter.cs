using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessLogicLayer.Interfaces;
using DataAccessLayer.Repositories;
using DataAccessLayer.Utilities;
using Model.Entities;
using Model.Enums;

namespace BussinessLogicLayer.Presenters
{
    public class LoginPresenter
    {
        private readonly ILoginView view;
        private readonly ProfileRepository profilesRepository;

        public LoginPresenter(ILoginView view)
        {
            this.view = view;
            profilesRepository = new ProfileRepository();

            Initialize();
        }

        private void Initialize()
        {
            try
            {
                AttachEvents();
                DisplayUserProfilesList();

                // User was previously logged - trying to automatically log him after program start
                if (Properties.Settings.Default.IsUserLogged)
                {
                    var currentlyLoggedUser = profilesRepository.Get(Properties.Settings.Default.CurrentlyLoggedPlayerId);
                    if (currentlyLoggedUser != null)
                    {
                        LogUser(currentlyLoggedUser);
                    }
                }
            }
            catch (Exception e)
            {
                Logger.Exception(e);
            }
        }

        private void DisplayUserProfilesList()
        {
            // Are there any users? If yes, display them in combo box, if no switch control to edit mode
            if (profilesRepository.HasProfile())
            {
                var profiles = profilesRepository.GetAll().ToList();
                view.AvailableUsers = profiles;
                view.DisplayMode = DisplayMode.View;
            }
            else
            {
                view.DisplayMode = DisplayMode.Edit;
            }
        }

        private void AttachEvents()
        {
            view.Login += LoginUser;
            view.NewUser += NewUser;
        }

        private void NewUser(object sender, EventArgs e)
        {
            view.DisplayMode = DisplayMode.Edit;
        }

        private void LogUser(Profile userToLog)
        {
            Properties.Settings.Default.IsUserLogged = true;
            Properties.Settings.Default.CurrentlyLoggedPlayerId = userToLog.Id;
            Properties.Settings.Default.Save();

            view.Hidden = true;
        }

        private void LoginUser(object sender, EventArgs e)
        {
            if (view.UserForBeingLoggedInId.HasValue)
            {
                var userToLogin = profilesRepository.Get(view.UserForBeingLoggedInId.Value);
                if(userToLogin != null) 
                    LogUser(userToLogin);
            }
            else
            {
                Profile newUser = CreateNewUser(view.UserNameToRegister);
                profilesRepository.Add(newUser);
            }

            view.DisplayMode = DisplayMode.View;
            view.Hidden = true;
        }

        private Profile CreateNewUser(string userNameToRegister)
        {
            Profile newProfile = new Profile();
            newProfile.Name = userNameToRegister;
            newProfile.JoinDate = DateTime.Now;
            newProfile.BirthDate = new DateTime(1994, 3, 2);
            return newProfile;
        }
    }
}
