using System;
using System.Windows.Forms;
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

        IWin32Window Window { get;  }
        bool ShowNextDayButton { set; }
        bool ShowPreviousDayButton { set; }

        event EventHandler<EventArgs> SaveDay;
        event EventHandler<EventArgs> ShowPreviousDay;
        event EventHandler<EventArgs> ShowNextDay;
    }
}
