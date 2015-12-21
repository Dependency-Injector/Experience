using System;
using System.Collections.Generic;

namespace BussinessLogicLayer.Interfaces
{
    public interface IDayView
    {
        String Thoughts { get;  set; }
        DateTime Date { set; }
        DateTime DaySelectorMinDate { set; }
        DateTime DaySelectorMaxDate { set; }
        int DayNumber { set; }
        int? ChoosenEntryId { get; set; }

        Dictionary<int, string> Entries { set; }

        bool ShowNextDayButton { set; }
        bool ShowPreviousDayButton { set; }
        bool ShowEditButton { set; }
        bool ShowSaveChangesButton { set; }
        bool ThoughtsTextBoxEnabled { set; }
        bool SelectingControlsEnabled { set; }

        event EventHandler<EventArgs> SaveDayChanges;
        event EventHandler<EventArgs> EditDay;
        event EventHandler<EventArgs> ShowPreviousDay;
        event EventHandler<EventArgs> ShowNextDay;
        event EventHandler<DateTime> DateChanged;
        event EventHandler<int> EntrySelected;
    }
}
