using BussinessLogicLayer.Enums;
using Model.Enums;

namespace BussinessLogicLayer.Events
{
    /// <summary>
    /// Event raised when new window (form) is being opened
    /// </summary>
    public class OpenWindowEvent
    {
        public WindowType WindowType;
        public DisplayMode DisplayMode;
        public int? EntityId;

        public OpenWindowEvent(WindowType windowType)
        {
            WindowType = windowType;
        }

        public OpenWindowEvent(WindowType windowType, DisplayMode displayMode, int? entityId = null)
        {
            WindowType = windowType;
            DisplayMode = displayMode;
            EntityId = entityId;
        }
    }
}
