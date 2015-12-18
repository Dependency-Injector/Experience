using System;

namespace BussinessLogicLayer.Interfaces
{
    public interface IDayView
    {
        String Thoughts { get;  set; }
        DateTime Date { set; }
        DateTime DaySelectorMinDate { set; }
        DateTime DaySelectorMaxDate { set; }
        int DayNumber { set; }

        bool ShowNextDayButton { set; }
        bool ShowPreviousDayButton { set; }
        bool ShowEditButton { set; }
        bool ShowSaveChangesButton { set; }
        bool ThoughtsTextBoxEnabled { set; }

        event EventHandler<EventArgs> SaveDayChanges;
        event EventHandler<EventArgs> EditDay;
        event EventHandler<EventArgs> ShowPreviousDay;
        event EventHandler<EventArgs> ShowNextDay;
        event EventHandler<DateTime> DateChanged;
    }
}
