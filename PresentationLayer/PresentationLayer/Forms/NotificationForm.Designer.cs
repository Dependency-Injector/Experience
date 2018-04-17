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
            this.progressPanel = new MetroFramework.Controls.MetroPanel();
            this.progressPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // additionalTextLabel
            // 
            this.additionalTextLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.additionalTextLabel.Location = new System.Drawing.Point(24, 64);
            this.additionalTextLabel.Name = "additionalTextLabel";
            this.additionalTextLabel.Size = new System.Drawing.Size(374, 125);
            this.additionalTextLabel.TabIndex = 0;
            this.additionalTextLabel.Text = "Notification text";
            this.additionalTextLabel.WrapToLine = true;
            // 
            // notificationProgress
            // 
            this.notificationProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.notificationProgress.Location = new System.Drawing.Point(3, 25);
            this.notificationProgress.Name = "notificationProgress";
            this.notificationProgress.Size = new System.Drawing.Size(548, 23);
            this.notificationProgress.TabIndex = 1;
            // 
            // progressBarLabel
            // 
            this.progressBarLabel.AutoSize = true;
            this.progressBarLabel.Location = new System.Drawing.Point(3, 3);
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
            this.closeButton.Location = new System.Drawing.Point(333, 195);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(65, 26);
            this.closeButton.TabIndex = 3;
            this.closeButton.Text = "Close";
            this.closeButton.UseSelectable = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // progressPanel
            // 
            this.progressPanel.Controls.Add(this.notificationProgress);
            this.progressPanel.Controls.Add(this.progressBarLabel);
            this.progressPanel.HorizontalScrollbarBarColor = true;
            this.progressPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.progressPanel.HorizontalScrollbarSize = 10;
            this.progressPanel.Location = new System.Drawing.Point(23, 140);
            this.progressPanel.Name = "progressPanel";
            this.progressPanel.Size = new System.Drawing.Size(374, 49);
            this.progressPanel.TabIndex = 4;
            this.progressPanel.VerticalScrollbarBarColor = true;
            this.progressPanel.VerticalScrollbarHighlightOnWheel = false;
            this.progressPanel.VerticalScrollbarSize = 10;
            this.progressPanel.Visible = false;
            // 
            // NotificationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 244);
            this.ControlBox = false;
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.progressPanel);
            this.Controls.Add(this.additionalTextLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NotificationForm";
            this.ShowIcon = false;
            this.Text = "Notification title";
            this.progressPanel.ResumeLayout(false);
            this.progressPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel additionalTextLabel;
        private MetroFramework.Controls.MetroProgressBar notificationProgress;
        private MetroFramework.Controls.MetroLabel progressBarLabel;
        private MetroFramework.Controls.MetroButton closeButton;
        private MetroFramework.Controls.MetroPanel progressPanel;
    }
}