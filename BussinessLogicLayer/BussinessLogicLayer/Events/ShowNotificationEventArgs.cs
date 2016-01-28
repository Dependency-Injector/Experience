using System;
using BussinessLogicLayer.Enums;

namespace BussinessLogicLayer.Events
{
    public class ShowNotificationEventArgs : EventArgs
    {
        public string Title { get; }
        public string Text { get; }
        public NotificationType Type { get; }
        public int? OldProgress { get; }
        public int? NewProgress { get; }
        public string ProgressDescription { get; }

        public ShowNotificationEventArgs(string title, string text, NotificationType type = NotificationType.Text, int? oldProgress = null, int? newProgress = null, string progressDescription = null)
        {
            this.Title = title;
            this.Text = text;
            this.Type = type;
            this.OldProgress = oldProgress;
            this.NewProgress = newProgress;
            this.ProgressDescription = progressDescription;
        }
    }
}
