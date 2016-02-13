namespace View.Controls
{
    partial class LoginControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.userNameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.userNameTextLabel = new MetroFramework.Controls.MetroLabel();
            this.loginButton = new MetroFramework.Controls.MetroButton();
            this.loginControlsPanel = new MetroFramework.Controls.MetroPanel();
            this.availablePlayersComboBox = new MetroFramework.Controls.MetroComboBox();
            this.newUserButton = new MetroFramework.Controls.MetroButton();
            this.loginControlsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Lines = new string[0];
            this.userNameTextBox.Location = new System.Drawing.Point(4, 39);
            this.userNameTextBox.MaxLength = 32767;
            this.userNameTextBox.Multiline = true;
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.PasswordChar = '\0';
            this.userNameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.userNameTextBox.SelectedText = "";
            this.userNameTextBox.Size = new System.Drawing.Size(503, 35);
            this.userNameTextBox.TabIndex = 1;
            this.userNameTextBox.UseSelectable = true;
            // 
            // userNameTextLabel
            // 
            this.userNameTextLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userNameTextLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.userNameTextLabel.Location = new System.Drawing.Point(4, 7);
            this.userNameTextLabel.Name = "userNameTextLabel";
            this.userNameTextLabel.Size = new System.Drawing.Size(503, 29);
            this.userNameTextLabel.TabIndex = 2;
            this.userNameTextLabel.Text = "What\'s your name?";
            this.userNameTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loginButton
            // 
            this.loginButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loginButton.Location = new System.Drawing.Point(4, 80);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(503, 64);
            this.loginButton.TabIndex = 3;
            this.loginButton.Text = "Come in";
            this.loginButton.UseSelectable = true;
            this.loginButton.Click += new System.EventHandler(this.createProfileButton_Click);
            // 
            // loginControlsPanel
            // 
            this.loginControlsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.loginControlsPanel.Controls.Add(this.availablePlayersComboBox);
            this.loginControlsPanel.Controls.Add(this.newUserButton);
            this.loginControlsPanel.Controls.Add(this.loginButton);
            this.loginControlsPanel.Controls.Add(this.userNameTextLabel);
            this.loginControlsPanel.Controls.Add(this.userNameTextBox);
            this.loginControlsPanel.HorizontalScrollbarBarColor = true;
            this.loginControlsPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.loginControlsPanel.HorizontalScrollbarSize = 10;
            this.loginControlsPanel.Location = new System.Drawing.Point(4, 1);
            this.loginControlsPanel.Name = "loginControlsPanel";
            this.loginControlsPanel.Size = new System.Drawing.Size(510, 250);
            this.loginControlsPanel.TabIndex = 4;
            this.loginControlsPanel.VerticalScrollbarBarColor = true;
            this.loginControlsPanel.VerticalScrollbarHighlightOnWheel = false;
            this.loginControlsPanel.VerticalScrollbarSize = 10;
            // 
            // availablePlayersComboBox
            // 
            this.availablePlayersComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.availablePlayersComboBox.DisplayMember = "Name";
            this.availablePlayersComboBox.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.availablePlayersComboBox.FormattingEnabled = true;
            this.availablePlayersComboBox.ItemHeight = 29;
            this.availablePlayersComboBox.Location = new System.Drawing.Point(4, 39);
            this.availablePlayersComboBox.Name = "availablePlayersComboBox";
            this.availablePlayersComboBox.Size = new System.Drawing.Size(503, 35);
            this.availablePlayersComboBox.TabIndex = 5;
            this.availablePlayersComboBox.UseSelectable = true;
            this.availablePlayersComboBox.ValueMember = "Id";
            // 
            // newUserButton
            // 
            this.newUserButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.newUserButton.Location = new System.Drawing.Point(4, 212);
            this.newUserButton.Name = "newUserButton";
            this.newUserButton.Size = new System.Drawing.Size(112, 33);
            this.newUserButton.TabIndex = 3;
            this.newUserButton.Text = "New profile";
            this.newUserButton.UseSelectable = true;
            this.newUserButton.Click += new System.EventHandler(this.newUserButton_Click);
            // 
            // LoginControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.loginControlsPanel);
            this.Name = "LoginControl";
            this.Size = new System.Drawing.Size(519, 253);
            this.loginControlsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox userNameTextBox;
        private MetroFramework.Controls.MetroLabel userNameTextLabel;
        private MetroFramework.Controls.MetroButton loginButton;
        private MetroFramework.Controls.MetroPanel loginControlsPanel;
        private MetroFramework.Controls.MetroComboBox availablePlayersComboBox;
        private MetroFramework.Controls.MetroButton newUserButton;
    }
}
