using BussinessLogicLayer.Enums;

namespace BussinessLogicLayer.Events
{
    public class WindowClosed
    {
        public WindowClosed(WindowType type)
        {
            Type = type;
        }

        public WindowType Type;
    }
}
