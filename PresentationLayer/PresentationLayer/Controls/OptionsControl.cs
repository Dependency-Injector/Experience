using System;
using System.Collections;
using System.Runtime.CompilerServices;
using BussinessLogicLayer.Interfaces;
using MetroFramework;
using MetroFramework.Components;
using MetroFramework.Controls;

namespace PresentationLayer.Controls
{
    public partial class OptionsControl : MetroUserControl, IOptionsView
    {
        public OptionsControl()
        {
            InitializeComponent();

            styleManager.Owner = ParentForm;
        }

        public string ShowFinishedTasks { get; set; }

        public string ThemeName
        {
            get
            {
                if (themeToggle.Checked)
                    return "Dark";
                else
                    return "Light";
            }
            set
            {
                MetroThemeStyle theme;
                if (Enum.TryParse<MetroThemeStyle>(value, out theme))
                {
                    if (theme == MetroThemeStyle.Dark)
                        themeToggle.Checked = true;
                    else
                        themeToggle.Checked = false;
                }
            }
        }

        public string StyleName
        {
            get
            {
                if (styleComboBox.SelectedItem != null)
                    return styleComboBox.SelectedItem.ToString();
                else
                    return null;
            }
            set
            {
                MetroColorStyle style;
                if (Enum.TryParse<MetroColorStyle>(value, out style))
                {
                    styleComboBox.SelectedItem = style;
                }
            }
        }

        public bool IsDirty
        {
            set
            {
                if (value)
                    saveOptionsButton.Enabled = true;
                else
                    saveOptionsButton.Enabled = false;
            }
        }

        public ICollection Styles
        {
            set
            {
                if (value != null && value.Count > 0)
                {
                    styleComboBox.DataSource = value;
                }
            }
        }

        public bool PolishLanguageButtonEnabled
        {
            set { polishLanguageButton.Enabled = value; }
        }

        public bool EnglishLanguageButtonEnabled
        {
            set { englishLanguageButton.Enabled = value; }
        }

        public object StyleManager { get { return styleManager; } }

        public event EventHandler<String> ChangeTheme;
        public event EventHandler<String> ChangeStyle;
        public event EventHandler<EventArgs> SaveChanges;
        public event EventHandler<string> ChangeLanguage;

        
        public MetroStyleManager GetStyleManager()
        {
            return styleManager;
        }

        private void styleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MetroColorStyle style;
            if (Enum.TryParse<MetroColorStyle>(StyleName, out style))
            {
                styleManager.Style = style;
            }
            
            if (ChangeStyle != null)
                ChangeStyle(this, StyleName);
        }

        private void themeToggle_CheckedChanged(object sender, EventArgs e)
        {
            MetroThemeStyle theme;
            if (Enum.TryParse<MetroThemeStyle>(ThemeName, out theme))
            {
                styleManager.Theme = theme;
            }

            if (ChangeTheme != null)
                ChangeTheme(this, ThemeName);
        }

        private void saveOptionsButton_Click(object sender, EventArgs e)
        {
            if (SaveChanges != null)
                SaveChanges(this, e);
        }

        private void polishLanguageButton_Click(object sender, EventArgs e)
        {
            if (ChangeLanguage != null)
                ChangeLanguage(this, "Polish");
        }

        private void englishLanguageButton_Click(object sender, EventArgs e)
        {
            if (ChangeLanguage != null)
                ChangeLanguage(this, "English");
        }
    }
}
