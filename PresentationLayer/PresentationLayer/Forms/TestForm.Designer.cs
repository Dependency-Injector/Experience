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
            this.profileControl.Experience = 0;
            this.profileControl.Level = 0;
            this.profileControl.Location = new System.Drawing.Point(493, 63);
            this.profileControl.PlayerName = "profileControl";
            this.profileControl.Size = new System.Drawing.Size(368, 418);
            this.profileControl.TabIndex = 1;
            this.profileControl.UseSelectable = true;
            // 
            // tasksControl1
            // 
            this.tasksControl1.DueDate = new System.DateTime(2015, 8, 11, 6, 25, 43, 330);
            this.tasksControl1.FinishDate = null;
            this.tasksControl1.IsDirty = true;
            this.tasksControl1.Location = new System.Drawing.Point(23, 63);
            this.tasksControl1.Name = "tasksControl1";
            this.tasksControl1.Priority = 0;
            this.tasksControl1.Size = new System.Drawing.Size(464, 579);
            this.tasksControl1.TabIndex = 0;
            this.tasksControl1.TaskDescription = "Description";
            this.tasksControl1.TaskName = "Name";
            this.tasksControl1.UseSelectable = true;
            // 
            // profileControl1
            // 
            this.profileControl1.Experience = 0;
            this.profileControl1.Level = 0;
            this.profileControl1.Location = new System.Drawing.Point(493, 63);
            this.profileControl1.PlayerName = "profileControl1";
            this.profileControl1.Size = new System.Drawing.Size(368, 418);
            this.profileControl1.TabIndex = 1;
            this.profileControl1.UseSelectable = true;
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 650);
            this.Controls.Add(this.profileControl);
            this.Controls.Add(this.tasksControl1);
            this.Name = "TestForm";
            this.Text = "TestForm";
            this.Load += new System.EventHandler(this.TestForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private TasksControl tasksControl1;
        private ProfileControl profileControl;
        private ProfileControl profileControl1;
    }
}