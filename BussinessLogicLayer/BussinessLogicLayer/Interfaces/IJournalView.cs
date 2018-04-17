using System;
using System.Collections.Generic;

namespace BussinessLogicLayer.Interfaces
{
    public interface IJournalView
    {
        String Thoughts { get;  set; }
        DateTime Date { set; }
        DateTime DaySelectorMinDate { set; }
        DateTime DaySelectorMaxDate { set; }
        int DayNumber { set; }
        int? ChoosenEntryId { get; set; }

        Dictionary<int, string> Entries { set; }
        
        bool ShowEditButton { set; }
        bool ShowSaveChangesButton { set; }
        bool ShowCancelChangesButton { set; }
        bool ThoughtsTextBoxEnabled { set; }

        bool ShowNavigation { set; }
        bool EnableNextDayButton { set; }
        bool EnablePreviousDayButton { set; }

        event EventHandler<EventArgs> SaveDayChanges;
        event EventHandler<EventArgs> EditDay;
        event EventHandler<EventArgs> ShowPreviousDay;
        event EventHandler<EventArgs> ShowNextDay;
        event EventHandler<EventArgs> CancelChanges;
        event EventHandler<DateTime> DateChanged;
        event EventHandler<int> EntrySelected;
    }
}
