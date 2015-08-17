using System;

namespace Model.Entities
{
    public class Preferences
    {
        public int Id { get; set; }
        public String ThemeName { get; set; }
        public String StyleName { get; set; }
        public bool ShowFinishedTasks { get; set; }
    }
}
