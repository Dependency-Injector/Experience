using System.ComponentModel;
using PresentationLayer.Controls;

namespace PresentationLayer.Forms
{
    partial class TestForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.profileControl = new PresentationLayer.Controls.ProfileControl();
            this.tasksControl1 = new PresentationLayer.Controls.TasksControl();
            this.profileControl1 = new PresentationLayer.Controls.ProfileControl();
            this.SuspendLayout();
            // 
            // profileControl
            // 
            this.profileControl.Age = 0;
            this.profileControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.profileControl.BirthDate = new System.DateTime(2015, 8, 13, 9, 15, 7, 709);
            this.profileControl.Experience = 0;
            this.profileControl.History = "(History Value)";
            this.profileControl.Level = 0;
            this.profileControl.LevelProgress = 0;
            this.profileControl.Location = new System.Drawing.Point(647, 63);
            this.profileControl.Name = "profileControl";
            this.profileControl.PlayerName = "profileControl";
            this.profileControl.Size = new System.Drawing.Size(487, 620);
            this.profileControl.TabIndex = 1;
            this.profileControl.UseSelectable = true;
            // 
            // tasksControl1
            // 
            this.tasksControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tasksControl1.DueDate = new System.DateTime(2015, 8, 11, 6, 25, 43, 330);
            this.tasksControl1.FinishDate = null;
            this.tasksControl1.IsDirty = true;
            this.tasksControl1.Location = new System.Drawing.Point(23, 63);
            this.tasksControl1.Name = "tasksControl1";
            this.tasksControl1.Priority = 0;
            this.tasksControl1.Size = new System.Drawing.Size(618, 620);
            this.tasksControl1.TabIndex = 0;
            this.tasksControl1.TaskDescription = "Description";
            this.tasksControl1.TaskName = "Name";
            this.tasksControl1.UseSelectable = true;
            // 
            // profileControl1
            // 
            this.profileControl1.Age = 0;
            this.profileControl1.BirthDate = new System.DateTime(2015, 8, 13, 9, 12, 55, 152);
            this.profileControl1.Experience = 0;
            this.profileControl1.History = "(History Value)";
            this.profileControl1.Level = 0;
            this.profileControl1.LevelProgress = 0;
            this.profileControl1.Location = new System.Drawing.Point(493, 63);
            this.profileControl1.Name = "profileControl1";
            this.profileControl1.PlayerName = "profileControl1";
            this.profileControl1.Size = new System.Drawing.Size(368, 418);
            this.profileControl1.TabIndex = 1;
            this.profileControl1.UseSelectable = true;
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 706);
            this.Controls.Add(this.profileControl);
            this.Controls.Add(this.tasksControl1);
            this.Name = "TestForm";
            this.Text = "JESTEM OGARNIĘTY";
            this.Load += new System.EventHandler(this.TestForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private TasksControl tasksControl1;
        private ProfileControl profileControl;
        private ProfileControl profileControl1;
    }
}