using System;
using BussinessLogicLayer.Interfaces;
using DataAccessLayer.Repositories.Interfaces;
using DataAccessLayer.Utilities;
using Model.Entities;
using Utilities;

namespace BussinessLogicLayer.Presenters
{
    public class OptionsPresenter
    {
        #region Private fields
        private readonly IOptionsView view;
        private readonly IPreferencesRepository preferencesRepository;
        private Preferences preferences;
        #endregion

        public OptionsPresenter(IOptionsView view, IPreferencesRepository preferencesRepository)
        {
            this.view = view;
            this.preferencesRepository = preferencesRepository;
            
            Initialize();
        }

        #region Events

        private void Initialize()
        {
            try
            {
                if (ApplicationSettings.Current.IsAnyUserLoggedIn && ApplicationSettings.Current.CurrentUserId.HasValue)
                {
                    AttachEvents();
                    ObtainPreferencesForUser(ApplicationSettings.Current.CurrentUserId.Value);

                    if (preferences != null)
                    {
                        DisplayPreferences();
                        view.IsDirty = false;
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Exception(ex);
            }
        }

        private void DisplayPreferences()
        {
            view.Styles = Enum.GetValues(typeof(MetroFramework.MetroColorStyle));
            view.StyleName = preferences.StyleName;
            view.ThemeName = preferences.ThemeName;
        }

        private void ObtainPreferencesForUser(int userId)
        {
            preferences = preferencesRepository.First(p => p.Owner.Id == userId);
        }

        #endregion

        #region Helper methods

        private void AttachEvents()
        {
            view.ChangeStyle += View_ChangeStyle;
            view.ChangeTheme += View_ChangeTheme;
            view.SaveChanges += View_SaveChanges;
        }

        private void View_SaveChanges(object sender, EventArgs e)
        {
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
        
        #endregion
    }
}
