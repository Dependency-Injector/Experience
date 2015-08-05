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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.newTaskButton = new MetroFramework.Controls.MetroButton();
            this.nextTaskButton = new MetroFramework.Controls.MetroButton();
            this.previousTaskButton = new MetroFramework.Controls.MetroButton();
            this.taskViewer = new PresentationLayer.Controls.Viewers.TaskViewer();
            this.taskEditor = new PresentationLayer.Controls.Editors.TaskEditor();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
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
            // taskViewer
            // 
            //this.taskViewer.DueDate = null;
            //this.taskViewer.FinishDate = null;
            //this.taskViewer.IsFinished = false;
            this.taskViewer.Location = new System.Drawing.Point(3, 3);
            this.taskViewer.Name = "taskViewer";
            //this.taskViewer.Priority = 0;
            this.taskViewer.Size = new System.Drawing.Size(250, 300);
            //this.taskViewer.StartDate = null;
            this.taskViewer.TabIndex = 0;
            //this.taskViewer.TaskName = null;
            this.taskViewer.UseSelectable = true;
            // 
            // taskEditor
            // 
            this.taskEditor.DueDate = new System.DateTime(2015, 8, 5, 0, 48, 48, 237);
            this.taskEditor.FinishDate = null;
            this.taskEditor.IsDirty = false;
            this.taskEditor.IsFinished = false;
            this.taskEditor.Location = new System.Drawing.Point(264, 3);
            this.taskEditor.Name = "taskEditor";
            this.taskEditor.Priority = 0;
            this.taskEditor.Size = new System.Drawing.Size(250, 300);
            this.taskEditor.StartDate = new System.DateTime(2015, 8, 5, 1, 5, 7, 202);
            this.taskEditor.TabIndex = 4;
            this.taskEditor.TaskName = "Name";
            this.taskEditor.UseSelectable = true;
            // 
            // TasksControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.taskEditor);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.taskViewer);
            this.Name = "TasksControl";
            this.Size = new System.Drawing.Size(514, 363);
            this.Load += new System.EventHandler(this.TasksControl_Load);
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TaskViewer taskViewer;
        private MetroPanel metroPanel1;
        private MetroButton newTaskButton;
        private MetroButton nextTaskButton;
        private MetroButton previousTaskButton;
        private TaskEditor taskEditor;
    }
}
