﻿using System;
using System.Collections;

namespace BussinessLogicLayer.Interfaces
{
    public interface IProfileView
    {
        String PlayerName { get; set; }
        String History { get; set; }
        String Age { set; }
        String NewSkillName { get; set; }
        DateTime BirthDate { get; set; }
        DateTime Joined { set; }
        int Level { get; set; }
        int Experience { get; set; }
        int LevelProgress { get; set; }
        ICollection Skills { set; } 
        ICollection ExperienceEventData { set; }

        bool RemoveSkillColumnVisible { set; }
        bool AddNewSkillPanelVisible { set; }
        bool EditProfileButtonVisible { set; }
        bool CancelChangesButtonVisible { set; }
        bool SaveChangesButtonVisible { set; }

        event EventHandler<EventArgs> AddNewSkill;
        event EventHandler<int> RemoveSkill;
        event EventHandler<EventArgs> EditProfile;
        event EventHandler<EventArgs> SaveChanges;
        event EventHandler<EventArgs> CancelChanges;
        
    }
}
