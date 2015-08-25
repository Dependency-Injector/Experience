namespace PresentationLayer.Controls
{
    partial class LoggedUserControl
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
            this.userNameLabel = new MetroFramework.Controls.MetroLabel();
            this.logoutLink = new MetroFramework.Controls.MetroLink();
            this.SuspendLayout();
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Location = new System.Drawing.Point(3, 3);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(80, 19);
            this.userNameLabel.TabIndex = 0;
            this.userNameLabel.Text = "[User name]";
            // 
            // logoutLink
            // 
            this.logoutLink.Location = new System.Drawing.Point(106, 3);
            this.logoutLink.Name = "logoutLink";
            this.logoutLink.Size = new System.Drawing.Size(75, 23);
            this.logoutLink.TabIndex = 1;
            this.logoutLink.Text = "(Log out)";
            this.logoutLink.UseSelectable = true;
            this.logoutLink.Click += new System.EventHandler(this.logoutLink_Click);
            // 
            // LoggedUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.logoutLink);
            this.Controls.Add(this.userNameLabel);
            this.Name = "LoggedUserControl";
            this.Size = new System.Drawing.Size(189, 30);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel userNameLabel;
        private MetroFramework.Controls.MetroLink logoutLink;
    }
}
