using BussinessLogicLayer.Enums;
using BussinessLogicLayer.Interfaces;
using MetroFramework.Forms;

namespace PresentationLayer.Forms
{
    public partial class NotificationForm : MetroForm, INotificationView
    {
        public NotificationForm()
        {
            InitializeComponent();
        }

        public string Title
        {
            set { this.Text = value; }
        }

        public string AdditionalText
        {
            set { additionalTextLabel.Text = value; }
        }

        public string ProgressDescription
        {
            set { progressBarLabel.Text = value; }
        }

        public bool IsVisible
        {
            set
            {
                if (value)
                    Show();
                else
                    Hide();
            }
        }

        public NotificationType Type
        {
            set
            {
                if (value == NotificationType.TextAndProgress)
                {
                    progressBarLabel.Visible = true;
                    notificationProgress.Visible = true;
                }
                else if (value == NotificationType.Text)
                {
                    progressBarLabel.Visible = false;
                    notificationProgress.Visible = false;
                }
            }
        }

        public int? OldProgress
        {
            set
            {
                // TODO
            }
        }

        public int? NewProgress
        {
            set
            {
                if(value.HasValue)
                    notificationProgress.Value = value.Value;
            }
        }

        private void closeButton_Click(object sender, System.EventArgs e)
        {
            this.Hide();
        }
    }
}
