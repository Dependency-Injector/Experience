using System;
using System.Collections;
using BussinessLogicLayer.Interfaces;
using MetroFramework.Controls;

namespace View.Controls
{
    public partial class LoginControl : MetroUserControl, ILoginView
    {
        public LoginControl()
        {
            InitializeComponent();
        }

        public int? UserForBeingLoggedInId
        {
            get
            {
                int userId;
                if (availablePlayersComboBox.SelectedValue != null && int.TryParse(availablePlayersComboBox.SelectedValue.ToString(), out userId))
                {
                    return userId;
                }
                else
                {
                    return null;
                }
            }
        }

        public string UserNameToRegister
        {
            get { return userNameTextBox.Text; }
        }

        public ICollection AvailableUsers
        {
            set { availablePlayersComboBox.DataSource = value; }
        }

        public bool ProfilesListVisible
        {
            set { availablePlayersComboBox.Visible = value; }
        }

        public bool NewUserNameTextBoxVisible
        {
            set { userNameTextBox.Visible = value; }
        }
        
        public bool IsNew { get; set; }
        
        public event EventHandler<EventArgs> Login;
        public event EventHandler<EventArgs> CreateNewUser;
        public event EventHandler<EventArgs> SaveUser;
        public event EventHandler<EventArgs> NewUser;

        private void createProfileButton_Click(object sender, EventArgs e)
        {
            if (Login != null)
                Login(this, e);
        }

        private void newUserButton_Click(object sender, EventArgs e)
        {
            if (NewUser != null)
                NewUser(this, e);
        }
    }
}
