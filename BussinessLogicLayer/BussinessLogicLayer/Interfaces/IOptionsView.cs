using System;
using System.Collections;

namespace BussinessLogicLayer.Interfaces
{
    public interface IOptionsView
    {
        String ThemeName { get; set; }
        String StyleName { get; set; }
        bool IsDirty { set; }
        ICollection Styles { set; }
        bool PolishLanguageButtonEnabled { set; }
        bool EnglishLanguageButtonEnabled { set; }

        event EventHandler<String> ChangeTheme;
        event EventHandler<String> ChangeStyle;
        event EventHandler<EventArgs> SaveChanges;
        event EventHandler<String> ChangeLanguage;
    }
}
