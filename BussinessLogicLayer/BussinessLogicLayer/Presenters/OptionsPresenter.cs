using System;
using BussinessLogicLayer.Events;
using BussinessLogicLayer.Interfaces;
using DataAccessLayer.Repositories.Interfaces;
using DataAccessLayer.Services.Interfaces;
using DataAccessLayer.Utilities;
using Model.Entities;
using Model.Enums;
using Utilities;

namespace BussinessLogicLayer.Presenters
{
    public class OptionsPresenter : IPresenter
    {
        #region Private fields
        private readonly IOptionsView view;
        private readonly IPreferencesRepository preferencesRepository;
        private readonly IPreferencesService preferencesService;

        private Preferences preferences;
        public event EventHandler<ShowNotificationEvent> NotificationAppeared;

        #endregion

        public OptionsPresenter(IOptionsView view, IPreferencesRepository preferencesRepository, IPreferencesService preferencesService)
        {
            this.view = view;
            this.preferencesRepository = preferencesRepository;
            this.preferencesService = preferencesService;
        }
        

        #region Helper methods

        public void Initialize()
        {
            try
            {
                /*if (ApplicationSettings.Current.IsAnyUserLoggedIn && ApplicationSettings.Current.CurrentUserId.HasValue)
                {*/
                    AttachEvents();
                    SetAvailableStyles();

                    ObtainPreferencesForUser(Globals.DmitruUserId);

                    if (preferences != null)
                    {
                        DisplayPreferences();
                        view.IsDirty = false;
                    }
                    else
                    {
                   //     preferences = new Preferences();
                    }
                //}
            }
            catch (Exception ex)
            {
                Logger.Exception(ex);
            }
        }

        private void SetAvailableStyles()
        {
            view.Styles = Enum.GetValues(typeof (MetroFramework.MetroColorStyle));
        }

        private void DisplayPreferences()
        {
            view.StyleName = preferences.StyleName;
            view.ThemeName = preferences.ThemeName;

            SetLanguageButtonsState(preferences.Language);
        }

        private void SetLanguageButtonsState(Language currentLanguage)
        {
            if (currentLanguage == Language.English)
            {
                view.PolishLanguageButtonEnabled = true;
                view.EnglishLanguageButtonEnabled = false;
            }
            else if (currentLanguage == Language.Polish)
            {
                view.PolishLanguageButtonEnabled = false;
                view.EnglishLanguageButtonEnabled = true;
            }
        }

        private void ObtainPreferencesForUser(int userId)
        {
            preferences = preferencesRepository.First(p => p.Owner.Id == userId);
        }

        #endregion

        #region Events

        private void AttachEvents()
        {
            view.ChangeStyle += View_ChangeStyle;
            view.ChangeTheme += View_ChangeTheme;
            view.SaveChanges += View_SaveChanges;
            view.ChangeLanguage += View_ChangeLanguage;
        }

        private void View_ChangeLanguage(object sender, string language)
        {
            if (language.Equals("Polish"))
            {
                preferences.Language = Language.Polish;
            }
            else if (language.Equals("English"))
            {
                preferences.Language = Language.English;
            }

            SetLanguageButtonsState(preferences.Language);

            view.IsDirty = true;
        }

        private void View_SaveChanges(object sender, EventArgs e)
        {
            if (preferences == null)
            {
                preferences = preferencesService.CreateNewPreferences(Globals.DmitruUserId);
                preferencesRepository.Add(preferences);
            }

            preferences.StyleName = view.StyleName;
            preferences.ThemeName = view.ThemeName;

            preferencesRepository.Update(preferences);
            view.IsDirty = false;
        }

        private void View_ChangeTheme(object sender, String theme)
        {
            view.IsDirty = true;
        }

        private void View_ChangeStyle(object sender, String style)
        {
            view.IsDirty = true;
        }

        public void OnViewDisplayed()
        {

        }

        public object GetStyleManager()
        {
            return view.StyleManager;
        }
        #endregion
    }
}
