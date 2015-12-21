using System;
using System.Collections.Generic;
using BussinessLogicLayer.GridRowTemplates;

namespace BussinessLogicLayer.Interfaces
{
    public interface IHistoryView
    {
        IList<HistoryEventGridItem> HistoryEventsGridItems { set; }

        bool DisplayTaskEvents { get; set; }
        bool DisplayWorkUnitEvents { get; set; }
        bool DisplayExperienceEvents { get; set; }
        bool DisplayProfileAndSkillsEvents { get; set; }

        event EventHandler<EventArgs> ShowHideTaskEvents;
        event EventHandler<EventArgs> ShowHideWorkUnitEvents;
        event EventHandler<EventArgs> ShowHideExperienceEvents;
        event EventHandler<EventArgs> ShowHideProfileAndSkillEvents;
    }

}
