using System;
using System.Collections;

namespace BussinessLogicLayer.Interfaces
{
    public interface ITaskDisplayView : IHideable
    {
        String TaskName { set; }
        String TaskDescription { set; }
        DateTime Deadline { set; }
        DateTime? FinishDate { set; }
        String AssociatedSkillName { set; }
        String ParentTaskName { set; }
        String Priority { set; }
        ICollection ChildrenTasks { set; }
        EventHandler<EventArgs> EditTask { get; set; }

    }
}