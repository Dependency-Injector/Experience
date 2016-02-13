using Model.Enums;

namespace BussinessLogicLayer.Events
{
    public class OpenTaskCompositeWindow
    {
        public OpenTaskCompositeWindow(DisplayMode displayMode, int? entityId = null)
        {
            DisplayMode = displayMode;
            EntityId = entityId;
        }

        public DisplayMode DisplayMode;
        public int? EntityId;
    }
}
