﻿using System;
using System.Linq;
using BussinessLogicLayer.Interfaces;
using DataAccessLayer.Repositories;
using DataAccessLayer.Repositories.Interfaces;
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

        public LoginPresenter(ILoginView view, IProfileRepository profilesRepository)
        {
            this.view = view;
            this.profilesRepository = profilesRepository;

            Initialize();
        }

        private void Initialize()
        {
            try
            {
                AttachEvents();
                DisplayUserProfilesList();
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
                if(userToLogin != null) 
                    LogUser(userToLogin);
            }
            else
            {
                Profile newUser = CreateNewUser(view.UserNameToRegister);
                profilesRepository.Add(newUser);
                LogUser(newUser);
            }

            view.DisplayMode = DisplayMode.View;
        }

        private Profile CreateNewUser(string userNameToRegister)
        {
            Profile newProfile = new Profile();
            newProfile.Name = userNameToRegister;
            newProfile.JoinDate = DateTime.Now;
            newProfile.BirthDate = null;
            return newProfile;
        }
    }
}
