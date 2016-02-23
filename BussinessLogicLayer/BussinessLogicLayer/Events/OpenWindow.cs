using BussinessLogicLayer.Enums;
using Model.Enums;

namespace BussinessLogicLayer.Events
{
    public class OpenTaskCompositeWindow
    {
        public OpenTaskCompositeWindow(DisplayMode displayMode, int? taskId = null)
        {
            DisplayMode = displayMode;
            TaskId = taskId;
        }

        public DisplayMode DisplayMode;
        public int? TaskId;
    }

    public class OpenWindow
    {
        public WindowType WindowType;

        public OpenWindow(WindowType type)
        {
            WindowType = type;
        }
    }
}
