using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;

namespace PresentationLayer.Controls
{
    public partial class LoggedUserControl : MetroUserControl
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
                Logout(this, new EventArgs());
        }
    }
}
