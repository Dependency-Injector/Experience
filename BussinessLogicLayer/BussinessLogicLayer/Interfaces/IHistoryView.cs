using System;
using System.Collections;

namespace BussinessLogicLayer.Interfaces
{
    public interface IHistoryView
    {
        bool DisplayTaskEvents { get; set; }
        bool DisplayWorkUnitEvents { get; set; }
        bool DisplayExperienceEvents { get; set; }
        ICollection HistoryItems { set; }
        ICollection HistoryEventsRows { set; }

        event EventHandler<EventArgs> ShowHideTaskEvents;
        event EventHandler<EventArgs> ShowHideWorkUnitEvents;
        event EventHandler<EventArgs> ShowHideExperienceEvents;
        event EventHandler<EventArgs> ShowHideProfileAndSkillEvents;
    }
}
