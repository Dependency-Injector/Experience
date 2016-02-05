using System;
using System.Collections;

namespace BussinessLogicLayer.Interfaces
{
    public interface IHideable
    {
        bool IsVisible { set; }
    }

    public interface ITaskDisplayView : IHideable
    {
        String TaskName { set; }
        String TaskDescription { set; }
        
        DateTime? FinishDate { set; }
        String TotalWorkload { set; }
        String TotalExperienceGained { set; }
        String AssociatedSkillName { set; }
        String ParentTaskName { set; }

        ICollection WorkUnits { set; }
        ICollection ChildrenTasks { set; }
    }
}