using System;
using System.Linq;
using BussinessLogicLayer.Interfaces;
using DataAccessLayer.Repositories;
using Model.Entities;

namespace BussinessLogicLayer.Presenters
{
    public class OptionsPresenter
    {
        #region Private fields
        private readonly IOptionsView view;
        private readonly PreferencesRepository preferencesRepository;
        private Preferences preferences;
        #endregion

        public OptionsPresenter(IOptionsView view)
        {
            this.view = view;
            preferencesRepository = new PreferencesRepository();

            Initialize();
        }

        #region Events

        private void Initialize()
        {
            try
            {
                AttachEvents();
                ObtainPreferences();

                if (preferences != null)
                {
                    DisplayPreferences();
                    view.IsDirty = false;
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                //MetroMessageBox.Show(null, ex.Message);
            }
        }

        private void DisplayPreferences()
        {
            view.Styles = Enum.GetValues(typeof(MetroFramework.MetroColorStyle));
            view.StyleName = preferences.StyleName;
            view.ThemeName = preferences.ThemeName;
        }

        private void ObtainPreferences()
        {
            preferences = preferencesRepository.GetAll().First();
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
            //view.ThemeName = theme;
            view.IsDirty = true;
        }

        private void View_ChangeStyle(object sender, String style)
        {
            //view.StyleName = style;
            view.IsDirty = true;
        }
        
        #endregion
    }
}
