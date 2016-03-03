using View.Controls;

namespace View.Forms
{
    partial class TaskCompositeForm
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
            this.contentPanel = new MetroFramework.Controls.MetroPanel();
            this.taskDisplayControl = new View.Controls.TaskDisplayControl();
            this.taskEditControl = new View.Controls.TaskEditControl();
            this.contentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // contentPanel
            // 
            this.contentPanel.Controls.Add(this.taskDisplayControl);
            this.contentPanel.Controls.Add(this.taskEditControl);
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.HorizontalScrollbarBarColor = true;
            this.contentPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.contentPanel.HorizontalScrollbarSize = 10;
            this.contentPanel.Location = new System.Drawing.Point(20, 60);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(539, 430);
            this.contentPanel.TabIndex = 4;
            this.contentPanel.VerticalScrollbarBarColor = true;
            this.contentPanel.VerticalScrollbarHighlightOnWheel = false;
            this.contentPanel.VerticalScrollbarSize = 10;
            // 
            // taskDisplayControl
            // 
            this.taskDisplayControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.taskDisplayControl.EditTask = null;
            this.taskDisplayControl.FinishDate = null;
            this.taskDisplayControl.FinishTask = null;
            this.taskDisplayControl.Location = new System.Drawing.Point(0, 0);
            this.taskDisplayControl.Name = "taskDisplayControl";
            this.taskDisplayControl.Size = new System.Drawing.Size(539, 430);
            this.taskDisplayControl.TabIndex = 2;
            this.taskDisplayControl.UseSelectable = true;
            // 
            // taskEditControl
            // 
            this.taskEditControl.CanBeFinished = false;
            this.taskEditControl.Difficulty = 0;
            this.taskEditControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.taskEditControl.DueDate = new System.DateTime(2016, 2, 5, 19, 31, 5, 984);
            this.taskEditControl.Location = new System.Drawing.Point(0, 0);
            this.taskEditControl.MinDueDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.taskEditControl.Name = "taskEditControl";
            this.taskEditControl.ParentTaskId = null;
            this.taskEditControl.Priority = 0;
            this.taskEditControl.Size = new System.Drawing.Size(539, 430);
            this.taskEditControl.SkillToTrainId = null;
            this.taskEditControl.TabIndex = 3;
            this.taskEditControl.TaskDescription = "Description";
            this.taskEditControl.TaskId = 0;
            this.taskEditControl.TaskName = "Name";
            this.taskEditControl.UseSelectable = true;
            // 
            // TaskCompositeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(579, 510);
            this.Controls.Add(this.contentPanel);
            this.KeyPreview = true;
            this.Name = "TaskCompositeForm";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Text = "TaskEditForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TaskCompositeForm_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TaskCompositeForm_KeyDown);
            this.contentPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroPanel contentPanel;
        private Controls.TaskEditControl taskEditControl;
        private Controls.TaskDisplayControl taskDisplayControl;
    }
}