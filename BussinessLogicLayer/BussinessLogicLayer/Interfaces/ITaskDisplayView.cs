using System;
using System.Collections;

namespace BussinessLogicLayer.Interfaces
{
    public interface ITaskDisplayView : IHideable
    {
        String TaskName { set; }
        String TaskDescription { set; }
        String Deadline { set; }
        String FinishDate { set; }
        String AssociatedSkillName { set; }
        String ParentTaskName { set; }
        String Priority { set; }
        bool ChildrenTasksPresent { set; }
        ICollection ChildrenTasks { set; }

        EventHandler<EventArgs> EditTask { get; set; }
        EventHandler<EventArgs> FinishTask { get; set; }
    }
}