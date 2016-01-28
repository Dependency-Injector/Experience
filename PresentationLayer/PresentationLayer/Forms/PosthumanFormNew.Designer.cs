namespace PresentationLayer.Forms
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
            this.mainControl1 = new PresentationLayer.Controls.MainControl();
            this.loggedUserControl = new PresentationLayer.Controls.LoggedUserControl();
            this.SuspendLayout();
            // 
            // mainControl1
            // 
            this.mainControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainControl1.Location = new System.Drawing.Point(20, 60);
            this.mainControl1.Name = "mainControl1";
            this.mainControl1.Size = new System.Drawing.Size(1184, 475);
            this.mainControl1.TabIndex = 0;
            this.mainControl1.UseSelectable = true;
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 555);
            this.Controls.Add(this.mainControl1);
            this.Name = "PosthumanFormNew";
            this.Text = "Posthuman";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.MainControl mainControl1;
        private Controls.LoggedUserControl loggedUserControl;
    }
}