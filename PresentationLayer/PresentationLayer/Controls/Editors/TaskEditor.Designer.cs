using System;
using System.ComponentModel;
using MetroFramework.Controls;

namespace PresentationLayer.Controls.Editors
{
    partial class TaskEditor
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
            this.saveChangesButton = new MetroFramework.Controls.MetroButton();
            this.descriptionLabel = new MetroFramework.Controls.MetroLabel();
            this.workUnitsPanel = new MetroFramework.Controls.MetroPanel();
            this.taskNameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.dueDateLabel = new MetroFramework.Controls.MetroLabel();
            this.nameLabel = new MetroFramework.Controls.MetroLabel();
            this.dueDateTime = new MetroFramework.Controls.MetroDateTime();
            this.descriptionTextBox = new MetroFramework.Controls.MetroTextBox();
            this.cancelChanges = new MetroFramework.Controls.MetroButton();
            this.priorityLabel = new MetroFramework.Controls.MetroLabel();
            this.priorityRadioButtonsPanel = new MetroFramework.Controls.MetroPanel();
            this.lowPriorityRadioButton = new MetroFramework.Controls.MetroRadioButton();
            this.mediumPriorityButton = new MetroFramework.Controls.MetroRadioButton();
            this.highPriorityButton = new MetroFramework.Controls.MetroRadioButton();
            this.priorityRadioButtonsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // saveChangesButton
            // 
            this.saveChangesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveChangesButton.Location = new System.Drawing.Point(164, 273);
            this.saveChangesButton.Name = "saveChangesButton";
            this.saveChangesButton.Size = new System.Drawing.Size(83, 26);
            this.saveChangesButton.TabIndex = 9;
            this.saveChangesButton.Text = "Save changes";
            this.saveChangesButton.UseSelectable = true;
            this.saveChangesButton.Click += new System.EventHandler(this.saveChangesButton_Click);
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.descriptionLabel.Location = new System.Drawing.Point(3, 145);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(97, 25);
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
            this.workUnitsPanel.Location = new System.Drawing.Point(3, 216);
            this.workUnitsPanel.Name = "workUnitsPanel";
            this.workUnitsPanel.Size = new System.Drawing.Size(244, 51);
            this.workUnitsPanel.TabIndex = 7;
            this.workUnitsPanel.VerticalScrollbarBarColor = true;
            this.workUnitsPanel.VerticalScrollbarHighlightOnWheel = false;
            this.workUnitsPanel.VerticalScrollbarSize = 10;
            // 
            // taskNameTextBox
            // 
            this.taskNameTextBox.Lines = new string[] {
        "Name"};
            this.taskNameTextBox.Location = new System.Drawing.Point(106, 4);
            this.taskNameTextBox.MaxLength = 32767;
            this.taskNameTextBox.Name = "taskNameTextBox";
            this.taskNameTextBox.PasswordChar = '\0';
            this.taskNameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.taskNameTextBox.SelectedText = "";
            this.taskNameTextBox.Size = new System.Drawing.Size(141, 23);
            this.taskNameTextBox.TabIndex = 10;
            this.taskNameTextBox.Text = "Name";
            this.taskNameTextBox.UseSelectable = true;
            // 
            // dueDateLabel
            // 
            this.dueDateLabel.AutoSize = true;
            this.dueDateLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.dueDateLabel.Location = new System.Drawing.Point(3, 34);
            this.dueDateLabel.Name = "dueDateLabel";
            this.dueDateLabel.Size = new System.Drawing.Size(81, 25);
            this.dueDateLabel.TabIndex = 5;
            this.dueDateLabel.Text = "Due date";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.nameLabel.Location = new System.Drawing.Point(3, 2);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(58, 25);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "Name";
            // 
            // dueDateTime
            // 
            this.dueDateTime.Location = new System.Drawing.Point(106, 33);
            this.dueDateTime.MinimumSize = new System.Drawing.Size(0, 29);
            this.dueDateTime.Name = "dueDateTime";
            this.dueDateTime.Size = new System.Drawing.Size(141, 29);
            this.dueDateTime.TabIndex = 11;
            this.dueDateTime.Value = DateTime.Now;

            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Lines = new string[] {
        "Description"};
            this.descriptionTextBox.Location = new System.Drawing.Point(106, 145);
            this.descriptionTextBox.MaxLength = 32767;
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.PasswordChar = '\0';
            this.descriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.descriptionTextBox.SelectedText = "";
            this.descriptionTextBox.Size = new System.Drawing.Size(141, 65);
            this.descriptionTextBox.TabIndex = 12;
            this.descriptionTextBox.Text = "Description";
            this.descriptionTextBox.UseSelectable = true;
            this.descriptionTextBox.Click += new System.EventHandler(this.descriptionTextBox_Click);
            // 
            // cancelChanges
            // 
            this.cancelChanges.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelChanges.Location = new System.Drawing.Point(75, 274);
            this.cancelChanges.Name = "cancelChanges";
            this.cancelChanges.Size = new System.Drawing.Size(83, 26);
            this.cancelChanges.TabIndex = 9;
            this.cancelChanges.Text = "Cancel";
            this.cancelChanges.UseSelectable = true;
            this.cancelChanges.Click += new System.EventHandler(this.cancelChanges_Click);
            // 
            // priorityLabel
            // 
            this.priorityLabel.AutoSize = true;
            this.priorityLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.priorityLabel.Location = new System.Drawing.Point(3, 69);
            this.priorityLabel.Name = "priorityLabel";
            this.priorityLabel.Size = new System.Drawing.Size(65, 25);
            this.priorityLabel.TabIndex = 6;
            this.priorityLabel.Text = "Priority";
            // 
            // priorityRadioButtonsPanel
            // 
            this.priorityRadioButtonsPanel.Controls.Add(this.highPriorityButton);
            this.priorityRadioButtonsPanel.Controls.Add(this.mediumPriorityButton);
            this.priorityRadioButtonsPanel.Controls.Add(this.lowPriorityRadioButton);
            this.priorityRadioButtonsPanel.HorizontalScrollbarBarColor = true;
            this.priorityRadioButtonsPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.priorityRadioButtonsPanel.HorizontalScrollbarSize = 10;
            this.priorityRadioButtonsPanel.Location = new System.Drawing.Point(106, 69);
            this.priorityRadioButtonsPanel.Name = "priorityRadioButtonsPanel";
            this.priorityRadioButtonsPanel.Size = new System.Drawing.Size(141, 70);
            this.priorityRadioButtonsPanel.TabIndex = 13;
            this.priorityRadioButtonsPanel.VerticalScrollbarBarColor = true;
            this.priorityRadioButtonsPanel.VerticalScrollbarHighlightOnWheel = false;
            this.priorityRadioButtonsPanel.VerticalScrollbarSize = 10;
            // 
            // lowPriorityRadioButton
            // 
            this.lowPriorityRadioButton.AutoSize = true;
            this.lowPriorityRadioButton.Location = new System.Drawing.Point(4, 9);
            this.lowPriorityRadioButton.Name = "lowPriorityRadioButton";
            this.lowPriorityRadioButton.Size = new System.Drawing.Size(45, 15);
            this.lowPriorityRadioButton.TabIndex = 2;
            this.lowPriorityRadioButton.Text = "Low";
            this.lowPriorityRadioButton.UseSelectable = true;
            // 
            // mediumPriorityButton
            // 
            this.mediumPriorityButton.AutoSize = true;
            this.mediumPriorityButton.Location = new System.Drawing.Point(4, 30);
            this.mediumPriorityButton.Name = "mediumPriorityButton";
            this.mediumPriorityButton.Size = new System.Drawing.Size(68, 15);
            this.mediumPriorityButton.TabIndex = 2;
            this.mediumPriorityButton.Text = "Medium";
            this.mediumPriorityButton.UseSelectable = true;
            // 
            // highPriorityButton
            // 
            this.highPriorityButton.AutoSize = true;
            this.highPriorityButton.Location = new System.Drawing.Point(4, 51);
            this.highPriorityButton.Name = "highPriorityButton";
            this.highPriorityButton.Size = new System.Drawing.Size(49, 15);
            this.highPriorityButton.TabIndex = 2;
            this.highPriorityButton.Text = "High";
            this.highPriorityButton.UseSelectable = true;
            // 
            // TaskEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.priorityRadioButtonsPanel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.dueDateTime);
            this.Controls.Add(this.taskNameTextBox);
            this.Controls.Add(this.cancelChanges);
            this.Controls.Add(this.saveChangesButton);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.dueDateLabel);
            this.Controls.Add(this.priorityLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.workUnitsPanel);
            this.Name = "TaskEditor";
            this.Size = new System.Drawing.Size(250, 300);
            this.UseCustomBackColor = true;
            this.Load += new System.EventHandler(this.TaskEditor_Load);
            this.priorityRadioButtonsPanel.ResumeLayout(false);
            this.priorityRadioButtonsPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroButton saveChangesButton;
        private MetroLabel descriptionLabel;
        private MetroPanel workUnitsPanel;
        private MetroTextBox taskNameTextBox;
        private MetroLabel dueDateLabel;
        private MetroLabel nameLabel;
        private MetroDateTime dueDateTime;
        private MetroTextBox descriptionTextBox;
        private MetroButton cancelChanges;
        private MetroLabel priorityLabel;
        private MetroPanel priorityRadioButtonsPanel;
        private MetroRadioButton highPriorityButton;
        private MetroRadioButton mediumPriorityButton;
        private MetroRadioButton lowPriorityRadioButton;
    }
}
