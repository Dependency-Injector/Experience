using System;
using Model.Enums;

namespace BussinessLogicLayer.Interfaces
{
    public class SwitchDisplayModeEventArgs : EventArgs
    {
        public DisplayMode DisplayMode;
    }

    public interface IDayView : IEditableView
    {
        String Thoughts { get;  set; }
        DateTime Date { set; }
        int DayNumber { set; }
        bool ShowNextDayButton { set; }
        bool ShowPreviousDayButton { set; }
        bool ShowEditButton { set; }
        bool ShowSaveChangesButton { set; }
        bool ThoughtsTextBoxEnabled { set; }

        event EventHandler<EventArgs> SaveDay;
        event EventHandler<EventArgs> ShowPreviousDay;
        event EventHandler<EventArgs> ShowNextDay;
    }
}
