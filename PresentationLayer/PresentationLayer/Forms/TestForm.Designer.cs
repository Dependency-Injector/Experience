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
            this.tasksControl1 = new TasksControl();
            this.SuspendLayout();
            // 
            // tasksControl1
            // 
            this.tasksControl1.DueDate = new System.DateTime(2015, 8, 11, 5, 17, 30, 302);
            this.tasksControl1.FinishDate = null;
            this.tasksControl1.IsDirty = true;
            this.tasksControl1.Location = new System.Drawing.Point(20, 60);
            this.tasksControl1.Name = "tasksControl1";
            this.tasksControl1.Priority = 0;
            this.tasksControl1.Size = new System.Drawing.Size(937, 561);
            this.tasksControl1.TabIndex = 0;
            this.tasksControl1.TaskDescription = "Description";
            this.tasksControl1.TaskName = "Name";
            this.tasksControl1.UseSelectable = true;
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.tasksControl1);
            this.MinimumSize = new System.Drawing.Size(1000, 650);
            this.Name = "TestForm";
            this.Text = "TestForm";
            this.ResumeLayout(false);

        }

        #endregion

        private TasksControl tasksControl1;
    }
}