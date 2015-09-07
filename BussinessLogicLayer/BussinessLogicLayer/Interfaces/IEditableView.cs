using System;

namespace BussinessLogicLayer.Interfaces
{
    public interface IEditableView
    {
        event EventHandler<SwitchDisplayModeEventArgs> SwitchDisplayMode;
    }
}
