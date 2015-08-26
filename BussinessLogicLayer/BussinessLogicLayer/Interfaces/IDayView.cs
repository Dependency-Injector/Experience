﻿using System;
using System.Windows.Forms;

namespace BussinessLogicLayer.Interfaces
{
    public interface IDayView
    {
        String Thoughts { get;  set; }
        DateTime Date { set; }
        int DayNumber { set; }

        IWin32Window Window { get;  }
        
        event EventHandler<EventArgs> SaveDay;
        event EventHandler<EventArgs> PreviousDay;
        event EventHandler<EventArgs> NextDay;
    }
}
