﻿using System;
using Model.Enums;

namespace Model.Entities
{
    public class Preferences
    {
        public int Id { get; set; }
        public String ThemeName { get; set; }
        public String StyleName { get; set; }
        public bool ShowFinishedTasks { get; set; }
        public Language Language { get; set; }
        public virtual Profile Owner { get; set; }
    }
}
