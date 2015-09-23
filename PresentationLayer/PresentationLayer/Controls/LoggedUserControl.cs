using System;
using BussinessLogicLayer.Interfaces;
using MetroFramework.Controls;

namespace PresentationLayer.Controls
{
    public partial class LoggedUserControl : MetroUserControl, ILoggedUserView
    {
        public String LoggedUserName
        {
            get { return userNameLabel.Text; }
            set { userNameLabel.Text = value; }
        }

        public event EventHandler<EventArgs> Logout;

        public LoggedUserControl()
        {
            InitializeComponent();
        }

        private void logoutLink_Click(object sender, EventArgs e)
        {
            if (Logout != null)
                Logout(this, e);
        }
    }
}
