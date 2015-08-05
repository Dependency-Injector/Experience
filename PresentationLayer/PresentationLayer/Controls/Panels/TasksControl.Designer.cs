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
            this.taskViewPanel = new MetroFramework.Controls.MetroPanel();
            this.editButton = new MetroFramework.Controls.MetroButton();
            this.finishedButton = new MetroFramework.Controls.MetroButton();
            this.priorityLabel = new MetroFramework.Controls.MetroLabel();
            this.nameLabel = new MetroFramework.Controls.MetroLabel();
            this.startAndDueDate = new MetroFramework.Controls.MetroLabel();
            this.descriptionLabel = new MetroFramework.Controls.MetroLabel();
            this.workUnitsPanel = new MetroFramework.Controls.MetroPanel();
            this.taskEditPanel = new MetroFramework.Controls.MetroPanel();
            this.nameTextBox = new MetroFramework.Controls.MetroTextBox();
<<<<<<< HEAD
            this.saveButton = new MetroFramework.Controls.MetroButton();
            this.cancelButton = new MetroFramework.Controls.MetroButton();
            this.dueDateTime = new MetroFramework.Controls.MetroDateTime();
            this.descriptionTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.lowPriorityRadioButton = new MetroFramework.Controls.MetroRadioButton();
            this.mediumPriorityRadioButton = new MetroFramework.Controls.MetroRadioButton();
            this.highPriorityRadioButton = new MetroFramework.Controls.MetroRadioButton();
            this.metroPanel1.SuspendLayout();
            this.taskViewPanel.SuspendLayout();
            this.taskEditPanel.SuspendLayout();
            this.metroPanel2.SuspendLayout();
=======
            this.dueDateTime = new MetroFramework.Controls.MetroDateTime();
            this.priorityPanel = new MetroFramework.Controls.MetroPanel();
            this.descriptionTextBox = new MetroFramework.Controls.MetroTextBox();
            this.saveButton = new MetroFramework.Controls.MetroButton();
            this.cancelButton = new MetroFramework.Controls.MetroButton();
            this.metroPanel1.SuspendLayout();
            this.taskViewPanel.SuspendLayout();
            this.taskEditPanel.SuspendLayout();
>>>>>>> 6d0414dffd381edcb30463b5e75ea1347cea98b9
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
<<<<<<< HEAD
            this.metroPanel1.Location = new System.Drawing.Point(141, 336);
=======
            this.metroPanel1.Location = new System.Drawing.Point(158, 401);
>>>>>>> 6d0414dffd381edcb30463b5e75ea1347cea98b9
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
            // taskViewPanel
            // 
            this.taskViewPanel.Controls.Add(this.editButton);
            this.taskViewPanel.Controls.Add(this.finishedButton);
            this.taskViewPanel.Controls.Add(this.priorityLabel);
            this.taskViewPanel.Controls.Add(this.nameLabel);
            this.taskViewPanel.Controls.Add(this.startAndDueDate);
            this.taskViewPanel.Controls.Add(this.descriptionLabel);
            this.taskViewPanel.Controls.Add(this.workUnitsPanel);
            this.taskViewPanel.HorizontalScrollbarBarColor = true;
            this.taskViewPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.taskViewPanel.HorizontalScrollbarSize = 10;
            this.taskViewPanel.Location = new System.Drawing.Point(21, 20);
            this.taskViewPanel.Name = "taskViewPanel";
<<<<<<< HEAD
            this.taskViewPanel.Size = new System.Drawing.Size(251, 298);
=======
            this.taskViewPanel.Size = new System.Drawing.Size(240, 360);
>>>>>>> 6d0414dffd381edcb30463b5e75ea1347cea98b9
            this.taskViewPanel.TabIndex = 4;
            this.taskViewPanel.VerticalScrollbarBarColor = true;
            this.taskViewPanel.VerticalScrollbarHighlightOnWheel = false;
            this.taskViewPanel.VerticalScrollbarSize = 10;
            // 
            // editButton
            // 
            this.editButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
<<<<<<< HEAD
            this.editButton.Location = new System.Drawing.Point(170, 11);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(78, 26);
=======
            this.editButton.Location = new System.Drawing.Point(153, 11);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(84, 26);
>>>>>>> 6d0414dffd381edcb30463b5e75ea1347cea98b9
            this.editButton.TabIndex = 9;
            this.editButton.Text = "Edit";
            this.editButton.UseSelectable = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // finishedButton
            // 
            this.finishedButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
<<<<<<< HEAD
            this.finishedButton.Location = new System.Drawing.Point(170, 217);
            this.finishedButton.Name = "finishedButton";
            this.finishedButton.Size = new System.Drawing.Size(78, 26);
=======
            this.finishedButton.Location = new System.Drawing.Point(153, 279);
            this.finishedButton.Name = "finishedButton";
            this.finishedButton.Size = new System.Drawing.Size(84, 26);
>>>>>>> 6d0414dffd381edcb30463b5e75ea1347cea98b9
            this.finishedButton.TabIndex = 10;
            this.finishedButton.Text = "Finished!";
            this.finishedButton.UseSelectable = true;
            this.finishedButton.Click += new System.EventHandler(this.finishedButton_Click);
            // 
            // priorityLabel
            // 
            this.priorityLabel.AutoSize = true;
            this.priorityLabel.Location = new System.Drawing.Point(3, 52);
            this.priorityLabel.Name = "priorityLabel";
            this.priorityLabel.Size = new System.Drawing.Size(51, 19);
            this.priorityLabel.TabIndex = 8;
            this.priorityLabel.Text = "Priority";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.nameLabel.Location = new System.Drawing.Point(3, 8);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(58, 25);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "Name";
            // 
            // startAndDueDate
            // 
            this.startAndDueDate.AutoSize = true;
            this.startAndDueDate.Location = new System.Drawing.Point(3, 33);
            this.startAndDueDate.Name = "startAndDueDate";
            this.startAndDueDate.Size = new System.Drawing.Size(132, 19);
            this.startAndDueDate.TabIndex = 5;
            this.startAndDueDate.Text = "Start date - due date";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(3, 71);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(74, 19);
            this.descriptionLabel.TabIndex = 6;
            this.descriptionLabel.Text = "Description";
            // 
            // workUnitsPanel
            // 
            this.workUnitsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.workUnitsPanel.HorizontalScrollbarBarColor = true;
            this.workUnitsPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.workUnitsPanel.HorizontalScrollbarSize = 10;
            this.workUnitsPanel.Location = new System.Drawing.Point(3, 93);
            this.workUnitsPanel.Name = "workUnitsPanel";
<<<<<<< HEAD
            this.workUnitsPanel.Size = new System.Drawing.Size(243, 118);
=======
            this.workUnitsPanel.Size = new System.Drawing.Size(232, 180);
>>>>>>> 6d0414dffd381edcb30463b5e75ea1347cea98b9
            this.workUnitsPanel.TabIndex = 7;
            this.workUnitsPanel.VerticalScrollbarBarColor = true;
            this.workUnitsPanel.VerticalScrollbarHighlightOnWheel = false;
            this.workUnitsPanel.VerticalScrollbarSize = 10;
            // 
            // taskEditPanel
            // 
<<<<<<< HEAD
            this.taskEditPanel.Controls.Add(this.metroPanel2);
            this.taskEditPanel.Controls.Add(this.descriptionTextBox);
            this.taskEditPanel.Controls.Add(this.dueDateTime);
            this.taskEditPanel.Controls.Add(this.cancelButton);
            this.taskEditPanel.Controls.Add(this.saveButton);
=======
            this.taskEditPanel.Controls.Add(this.cancelButton);
            this.taskEditPanel.Controls.Add(this.saveButton);
            this.taskEditPanel.Controls.Add(this.descriptionTextBox);
            this.taskEditPanel.Controls.Add(this.priorityPanel);
            this.taskEditPanel.Controls.Add(this.dueDateTime);
>>>>>>> 6d0414dffd381edcb30463b5e75ea1347cea98b9
            this.taskEditPanel.Controls.Add(this.nameTextBox);
            this.taskEditPanel.HorizontalScrollbarBarColor = true;
            this.taskEditPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.taskEditPanel.HorizontalScrollbarSize = 10;
<<<<<<< HEAD
            this.taskEditPanel.Location = new System.Drawing.Point(278, 20);
            this.taskEditPanel.Name = "taskEditPanel";
            this.taskEditPanel.Size = new System.Drawing.Size(213, 298);
=======
            this.taskEditPanel.Location = new System.Drawing.Point(274, 20);
            this.taskEditPanel.Name = "taskEditPanel";
            this.taskEditPanel.Size = new System.Drawing.Size(240, 360);
>>>>>>> 6d0414dffd381edcb30463b5e75ea1347cea98b9
            this.taskEditPanel.TabIndex = 5;
            this.taskEditPanel.VerticalScrollbarBarColor = true;
            this.taskEditPanel.VerticalScrollbarHighlightOnWheel = false;
            this.taskEditPanel.VerticalScrollbarSize = 10;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Lines = new string[] {
        "Name"};
<<<<<<< HEAD
            this.nameTextBox.Location = new System.Drawing.Point(19, 8);
=======
            this.nameTextBox.Location = new System.Drawing.Point(3, 11);
>>>>>>> 6d0414dffd381edcb30463b5e75ea1347cea98b9
            this.nameTextBox.MaxLength = 32767;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.PasswordChar = '\0';
            this.nameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.nameTextBox.SelectedText = "";
<<<<<<< HEAD
            this.nameTextBox.Size = new System.Drawing.Size(174, 23);
            this.nameTextBox.TabIndex = 11;
            this.nameTextBox.Text = "Name";
            this.nameTextBox.UseSelectable = true;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(119, 260);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 26);
            this.saveButton.TabIndex = 12;
            this.saveButton.Text = "Save";
            this.saveButton.UseSelectable = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(38, 260);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 26);
            this.cancelButton.TabIndex = 13;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseSelectable = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // dueDateTime
            // 
            this.dueDateTime.Location = new System.Drawing.Point(19, 38);
            this.dueDateTime.MinimumSize = new System.Drawing.Size(0, 29);
            this.dueDateTime.Name = "dueDateTime";
            this.dueDateTime.Size = new System.Drawing.Size(174, 29);
            this.dueDateTime.TabIndex = 14;
=======
            this.nameTextBox.Size = new System.Drawing.Size(201, 23);
            this.nameTextBox.TabIndex = 9;
            this.nameTextBox.Text = "Name";
            this.nameTextBox.UseSelectable = true;
            // 
            // dueDateTime
            // 
            this.dueDateTime.Location = new System.Drawing.Point(3, 40);
            this.dueDateTime.MinimumSize = new System.Drawing.Size(0, 29);
            this.dueDateTime.Name = "dueDateTime";
            this.dueDateTime.Size = new System.Drawing.Size(200, 29);
            this.dueDateTime.TabIndex = 10;
            // 
            // priorityPanel
            // 
            this.priorityPanel.HorizontalScrollbarBarColor = true;
            this.priorityPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.priorityPanel.HorizontalScrollbarSize = 10;
            this.priorityPanel.Location = new System.Drawing.Point(4, 76);
            this.priorityPanel.Name = "priorityPanel";
            this.priorityPanel.Size = new System.Drawing.Size(200, 100);
            this.priorityPanel.TabIndex = 11;
            this.priorityPanel.VerticalScrollbarBarColor = true;
            this.priorityPanel.VerticalScrollbarHighlightOnWheel = false;
            this.priorityPanel.VerticalScrollbarSize = 10;
>>>>>>> 6d0414dffd381edcb30463b5e75ea1347cea98b9
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Lines = new string[] {
        "Description"};
<<<<<<< HEAD
            this.descriptionTextBox.Location = new System.Drawing.Point(19, 173);
=======
            this.descriptionTextBox.Location = new System.Drawing.Point(4, 183);
>>>>>>> 6d0414dffd381edcb30463b5e75ea1347cea98b9
            this.descriptionTextBox.MaxLength = 32767;
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.PasswordChar = '\0';
            this.descriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.descriptionTextBox.SelectedText = "";
<<<<<<< HEAD
            this.descriptionTextBox.Size = new System.Drawing.Size(174, 81);
            this.descriptionTextBox.TabIndex = 15;
            this.descriptionTextBox.Text = "Description";
            this.descriptionTextBox.UseSelectable = true;
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.highPriorityRadioButton);
            this.metroPanel2.Controls.Add(this.mediumPriorityRadioButton);
            this.metroPanel2.Controls.Add(this.lowPriorityRadioButton);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(19, 74);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(174, 93);
            this.metroPanel2.TabIndex = 16;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // lowPriorityRadioButton
            // 
            this.lowPriorityRadioButton.AutoSize = true;
            this.lowPriorityRadioButton.Location = new System.Drawing.Point(4, 4);
            this.lowPriorityRadioButton.Name = "lowPriorityRadioButton";
            this.lowPriorityRadioButton.Size = new System.Drawing.Size(45, 15);
            this.lowPriorityRadioButton.TabIndex = 2;
            this.lowPriorityRadioButton.Text = "Low";
            this.lowPriorityRadioButton.UseSelectable = true;
            // 
            // mediumPriorityRadioButton
            // 
            this.mediumPriorityRadioButton.AutoSize = true;
            this.mediumPriorityRadioButton.Location = new System.Drawing.Point(3, 25);
            this.mediumPriorityRadioButton.Name = "mediumPriorityRadioButton";
            this.mediumPriorityRadioButton.Size = new System.Drawing.Size(68, 15);
            this.mediumPriorityRadioButton.TabIndex = 2;
            this.mediumPriorityRadioButton.Text = "Medium";
            this.mediumPriorityRadioButton.UseSelectable = true;
            // 
            // highPriorityRadioButton
            // 
            this.highPriorityRadioButton.AutoSize = true;
            this.highPriorityRadioButton.Location = new System.Drawing.Point(4, 46);
            this.highPriorityRadioButton.Name = "highPriorityRadioButton";
            this.highPriorityRadioButton.Size = new System.Drawing.Size(49, 15);
            this.highPriorityRadioButton.TabIndex = 2;
            this.highPriorityRadioButton.Text = "High";
            this.highPriorityRadioButton.UseSelectable = true;
=======
            this.descriptionTextBox.Size = new System.Drawing.Size(199, 90);
            this.descriptionTextBox.TabIndex = 12;
            this.descriptionTextBox.Text = "Description";
            this.descriptionTextBox.UseSelectable = true;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(128, 279);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 13;
            this.saveButton.Text = "Save";
            this.saveButton.UseSelectable = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(47, 279);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 13;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseSelectable = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
>>>>>>> 6d0414dffd381edcb30463b5e75ea1347cea98b9
            // 
            // TasksControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.taskEditPanel);
            this.Controls.Add(this.taskViewPanel);
            this.Controls.Add(this.metroPanel1);
            this.Name = "TasksControl";
<<<<<<< HEAD
            this.Size = new System.Drawing.Size(500, 376);
=======
            this.Size = new System.Drawing.Size(522, 443);
>>>>>>> 6d0414dffd381edcb30463b5e75ea1347cea98b9
            this.Load += new System.EventHandler(this.TasksControl_Load);
            this.metroPanel1.ResumeLayout(false);
            this.taskViewPanel.ResumeLayout(false);
            this.taskViewPanel.PerformLayout();
            this.taskEditPanel.ResumeLayout(false);
<<<<<<< HEAD
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
=======
>>>>>>> 6d0414dffd381edcb30463b5e75ea1347cea98b9
            this.ResumeLayout(false);

        }

        #endregion
        private MetroPanel metroPanel1;
        private MetroButton newTaskButton;
        private MetroButton nextTaskButton;
        private MetroButton previousTaskButton;
        private MetroPanel taskViewPanel;
        private MetroButton editButton;
        private MetroButton finishedButton;
        private MetroLabel priorityLabel;
        private MetroLabel nameLabel;
        private MetroLabel startAndDueDate;
        private MetroLabel descriptionLabel;
        private MetroPanel workUnitsPanel;
        private MetroPanel taskEditPanel;
        private MetroButton cancelButton;
        private MetroButton saveButton;
<<<<<<< HEAD
        private MetroTextBox nameTextBox;
        private MetroTextBox descriptionTextBox;
        private MetroDateTime dueDateTime;
        private MetroPanel metroPanel2;
        private MetroRadioButton highPriorityRadioButton;
        private MetroRadioButton mediumPriorityRadioButton;
        private MetroRadioButton lowPriorityRadioButton;
=======
        private MetroTextBox descriptionTextBox;
        private MetroPanel priorityPanel;
        private MetroDateTime dueDateTime;
        private MetroTextBox nameTextBox;
>>>>>>> 6d0414dffd381edcb30463b5e75ea1347cea98b9
    }
}
