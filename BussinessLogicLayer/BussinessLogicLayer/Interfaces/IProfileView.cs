using System;
using System.Collections;

namespace BussinessLogicLayer.Interfaces
{
    public interface IProfileView
    {
        String PlayerName { get; set; }
        String History { get; set; }
        int Age { get; set; }
        DateTime BirthDate { get; set; }
        int Level { get; set; }
        int Experience { get; set; }
        int LevelProgress { get; set; }
        ICollection Skills { set; } 
        DateTime Joined { set; }
        ICollection ExperienceEventData { set; }
    }
}
