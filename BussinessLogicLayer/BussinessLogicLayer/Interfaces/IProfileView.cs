using System;
using System.Windows.Forms;

namespace BussinessLogicLayer.Interfaces
{
    public interface IProfileView
    {
        String PlayerName { get; set; }
        String History { get; set; }
        String Age { set; }
        String NewSkillName { get; set; }
        int Level { get; set; }
        String Experience { get; set; }
        int LevelProgress { get; set; }
        int? SelectedSkill { get; set; }
        BindingSource Skills { set; }
        BindingSource ProfileRelatedEvents { set; }
        bool AddNewSkillPanelVisible { set; }
        bool EditProfileButtonVisible { set; }
        bool CancelChangesButtonVisible { set; }
        bool SaveChangesButtonVisible { set; }

        bool ProfileDisplayed { set; }

        event EventHandler<EventArgs> AddNewSkill;
        event EventHandler<int> RemoveSkill;
        event EventHandler<EventArgs> EditProfile;
        event EventHandler<EventArgs> SaveChanges;
        event EventHandler<EventArgs> CancelChanges;
        event EventHandler<EventArgs> ShowProfileHistory;
        event Action SkillSelected;
    }

}
