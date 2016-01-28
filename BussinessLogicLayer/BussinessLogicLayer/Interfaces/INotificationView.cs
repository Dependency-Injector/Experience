using BussinessLogicLayer.Enums;

namespace BussinessLogicLayer.Interfaces
{
    public interface INotificationView
    {
        string Title { set; }
        string AdditionalText { set; }
        NotificationType Type { set; }
        int? OldProgress { set; }
        int? NewProgress { set; }
        string ProgressDescription { set; }
        bool IsVisible { set; }
    }

}
