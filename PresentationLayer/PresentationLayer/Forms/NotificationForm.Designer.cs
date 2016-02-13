namespace View.Forms
{
    partial class NotificationForm
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
            this.additionalTextLabel = new MetroFramework.Controls.MetroLabel();
            this.notificationProgress = new MetroFramework.Controls.MetroProgressBar();
            this.progressBarLabel = new MetroFramework.Controls.MetroLabel();
            this.closeButton = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // additionalTextLabel
            // 
            this.additionalTextLabel.AutoSize = true;
            this.additionalTextLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.additionalTextLabel.Location = new System.Drawing.Point(24, 64);
            this.additionalTextLabel.Name = "additionalTextLabel";
            this.additionalTextLabel.Size = new System.Drawing.Size(121, 25);
            this.additionalTextLabel.TabIndex = 0;
            this.additionalTextLabel.Text = "Additional text";
            // 
            // notificationProgress
            // 
            this.notificationProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.notificationProgress.Location = new System.Drawing.Point(24, 145);
            this.notificationProgress.Name = "notificationProgress";
            this.notificationProgress.Size = new System.Drawing.Size(374, 23);
            this.notificationProgress.TabIndex = 1;
            // 
            // progressBarLabel
            // 
            this.progressBarLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.progressBarLabel.AutoSize = true;
            this.progressBarLabel.Location = new System.Drawing.Point(24, 118);
            this.progressBarLabel.Name = "progressBarLabel";
            this.progressBarLabel.Size = new System.Drawing.Size(109, 19);
            this.progressBarLabel.TabIndex = 2;
            this.progressBarLabel.Text = "Progress bar text";
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.closeButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.closeButton.Highlight = true;
            this.closeButton.Location = new System.Drawing.Point(333, 32);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(65, 57);
            this.closeButton.TabIndex = 3;
            this.closeButton.Text = "Close";
            this.closeButton.UseSelectable = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // NotificationViewWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 195);
            this.ControlBox = false;
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.progressBarLabel);
            this.Controls.Add(this.notificationProgress);
            this.Controls.Add(this.additionalTextLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NotificationForm";
            this.ShowIcon = false;
            this.Text = "Notification title";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel additionalTextLabel;
        private MetroFramework.Controls.MetroProgressBar notificationProgress;
        private MetroFramework.Controls.MetroLabel progressBarLabel;
        private MetroFramework.Controls.MetroButton closeButton;
    }
}