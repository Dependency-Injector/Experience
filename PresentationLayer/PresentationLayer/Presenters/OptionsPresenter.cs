using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DataAccessLayer.Model;
using DataAccessLayer.Repositories;
using MetroFramework;
using PresentationLayer.Others;
using PresentationLayer.Views;
using Utilities;

namespace PresentationLayer.Presenters
{
    public class OptionsPresenter
    {
        #region Private fields

        private readonly IOptionsView view;

        private PreferencesRepository preferencesRepository;
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
                MessageBox.Show(ex.Message);
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
