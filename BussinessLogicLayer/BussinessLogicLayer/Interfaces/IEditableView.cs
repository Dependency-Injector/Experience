using System;
using Model.Enums;

namespace BussinessLogicLayer.Interfaces
{
    public interface IEditableView
    {
        DisplayMode DisplayMode { set; }
        event EventHandler<SwitchDisplayModeEventArgs> SwitchDisplayMode;
    }
}
