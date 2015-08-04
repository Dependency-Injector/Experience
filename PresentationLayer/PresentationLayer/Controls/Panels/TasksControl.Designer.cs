using System.ComponentModel;
using MetroFramework.Controls;
using PresentationLayer.Controls.Editors;
using PresentationLayer.Controls.Viewers;

namespace PresentationLayer.Controls.Panels
{
    partial class TasksControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.taskEditor1 = new PresentationLayer.Controls.Editors.TaskEditor();
            this.taskViewer1 = new PresentationLayer.Controls.Viewers.TaskViewer();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.previousTaskButton = new MetroFramework.Controls.MetroButton();
            this.nextTaskButton = new MetroFramework.Controls.MetroButton();
            this.newTaskButton = new MetroFramework.Controls.MetroButton();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // taskEditor1
            // 
            this.taskEditor1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.taskEditor1.DueDate = new System.DateTime(2015, 8, 11, 22, 48, 26, 284);
            this.taskEditor1.FinishDate = null;
            this.taskEditor1.IsDirty = false;
            this.taskEditor1.IsFinished = false;
            this.taskEditor1.Location = new System.Drawing.Point(259, 3);
            this.taskEditor1.Name = "taskEditor1";
            this.taskEditor1.Priority = 0;
            this.taskEditor1.Size = new System.Drawing.Size(250, 300);
            this.taskEditor1.StartDate = null;
            this.taskEditor1.TabIndex = 1;
            this.taskEditor1.TaskName = "";
            this.taskEditor1.UseCustomBackColor = true;
            this.taskEditor1.UseSelectable = true;
            // 
            // taskViewer1
            // 
            this.taskViewer1.DueDate = null;
            this.taskViewer1.FinishDate = null;
            this.taskViewer1.IsFinished = false;
            this.taskViewer1.Location = new System.Drawing.Point(3, 3);
            this.taskViewer1.Name = "taskViewer1";
            this.taskViewer1.Priority = 0;
            this.taskViewer1.Size = new System.Drawing.Size(250, 300);
            this.taskViewer1.StartDate = null;
            this.taskViewer1.TabIndex = 0;
            this.taskViewer1.TaskName = null;
            this.taskViewer1.UseSelectable = true;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.newTaskButton);
            this.metroPanel1.Controls.Add(this.nextTaskButton);
            this.metroPanel1.Controls.Add(this.previousTaskButton);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(141, 329);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(250, 30);
            this.metroPanel1.TabIndex = 3;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // previousTaskButton
            // 
            this.previousTaskButton.Location = new System.Drawing.Point(91, 3);
            this.previousTaskButton.Name = "previousTaskButton";
            this.previousTaskButton.Size = new System.Drawing.Size(75, 23);
            this.previousTaskButton.TabIndex = 2;
            this.previousTaskButton.Text = "<-";
            this.previousTaskButton.UseSelectable = true;
            this.previousTaskButton.Click += new System.EventHandler(this.previousTaskButton_Click);
            // 
            // nextTaskButton
            // 
            this.nextTaskButton.Location = new System.Drawing.Point(172, 3);
            this.nextTaskButton.Name = "nextTaskButton";
            this.nextTaskButton.Size = new System.Drawing.Size(75, 23);
            this.nextTaskButton.TabIndex = 2;
            this.nextTaskButton.Text = "->";
            this.nextTaskButton.UseSelectable = true;
            this.nextTaskButton.Click += new System.EventHandler(this.nextTaskButton_Click);
            // 
            // newTaskButton
            // 
            this.newTaskButton.Location = new System.Drawing.Point(3, 3);
            this.newTaskButton.Name = "newTaskButton";
            this.newTaskButton.Size = new System.Drawing.Size(82, 23);
            this.newTaskButton.TabIndex = 2;
            this.newTaskButton.Text = "New task";
            this.newTaskButton.UseSelectable = true;
            this.newTaskButton.Click += new System.EventHandler(this.newTaskButton_Click);
            // 
            // TasksControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.taskEditor1);
            this.Controls.Add(this.taskViewer1);
            this.Name = "TasksControl";
            this.Size = new System.Drawing.Size(514, 363);
            this.Load += new System.EventHandler(this.TasksControl_Load);
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TaskViewer taskViewer1;
        private TaskEditor taskEditor1;
        private MetroPanel metroPanel1;
        private MetroButton newTaskButton;
        private MetroButton nextTaskButton;
        private MetroButton previousTaskButton;
    }
}
