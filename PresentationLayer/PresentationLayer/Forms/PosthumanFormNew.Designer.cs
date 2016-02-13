using View.Controls;

namespace View.Forms
{
    partial class PosthumanFormNew
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainControl = new View.Controls.MainControl();
            this.loggedUserControl = new View.Controls.LoggedUserControl();
            this.SuspendLayout();
            // 
            // mainControl
            // 
            this.mainControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainControl.Location = new System.Drawing.Point(20, 60);
            this.mainControl.Name = "mainControl";
            this.mainControl.Size = new System.Drawing.Size(613, 582);
            this.mainControl.TabIndex = 0;
            this.mainControl.UseSelectable = true;
            // 
            // loggedUserControl
            // 
            this.loggedUserControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.loggedUserControl.Location = new System.Drawing.Point(974, 24);
            this.loggedUserControl.LoggedUserName = "[User name]";
            this.loggedUserControl.Name = "loggedUserControl";
            this.loggedUserControl.Size = new System.Drawing.Size(189, 30);
            this.loggedUserControl.TabIndex = 4;
            this.loggedUserControl.UseSelectable = true;
            // 
            // PosthumanFormNew
            // 
            this.ApplyImageInvert = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackImage = global::View.Properties.Resources.GitHub_Mark;
            this.BackImagePadding = new System.Windows.Forms.Padding(210, 10, 0, 0);
            this.BackMaxSize = 50;
            this.ClientSize = new System.Drawing.Size(653, 662);
            this.Controls.Add(this.mainControl);
            this.Name = "PosthumanFormNew";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.Text = "Posthuman";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.MainControl mainControl;
        private Controls.LoggedUserControl loggedUserControl;
    }
}