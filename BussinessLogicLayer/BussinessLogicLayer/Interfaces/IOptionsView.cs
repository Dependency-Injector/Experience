﻿using System;
using System.Collections;

namespace BussinessLogicLayer.Interfaces
{
    public interface IOptionsView
    {
        String ShowFinishedTasks { get; set; }
        String ThemeName { get; set; }
        String StyleName { get; set; }
        bool IsDirty { set; }
        ICollection Styles { set; }

        event EventHandler<String> ChangeTheme;
        event EventHandler<String> ChangeStyle;
        event EventHandler<EventArgs> SaveChanges;
    }
}
