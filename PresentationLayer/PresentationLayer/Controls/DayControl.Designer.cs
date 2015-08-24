﻿namespace PresentationLayer.Controls
{
    partial class DayControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dayNumberLabel = new MetroFramework.Controls.MetroLabel();
            this.dateLabel = new MetroFramework.Controls.MetroLabel();
            this.thoughtsTextBox = new MetroFramework.Controls.MetroTextBox();
            this.saveChangesButton = new MetroFramework.Controls.MetroButton();
            this.editButton = new MetroFramework.Controls.MetroButton();
            this.nextDayButton = new MetroFramework.Controls.MetroButton();
            this.previousDayButton = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // dayNumberLabel
            // 
            this.dayNumberLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.dayNumberLabel.Location = new System.Drawing.Point(3, 10);
            this.dayNumberLabel.Name = "dayNumberLabel";
            this.dayNumberLabel.Size = new System.Drawing.Size(359, 28);
            this.dayNumberLabel.TabIndex = 0;
            this.dayNumberLabel.Text = "Day [Number]";
            this.dayNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateLabel
            // 
            this.dateLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.dateLabel.Location = new System.Drawing.Point(3, 38);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(359, 26);
            this.dateLabel.TabIndex = 0;
            this.dateLabel.Text = "[Day date]";
            this.dateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // thoughtsTextBox
            // 
            this.thoughtsTextBox.Enabled = false;
            this.thoughtsTextBox.Lines = new string[] {
        "[Thoughts]"};
            this.thoughtsTextBox.Location = new System.Drawing.Point(3, 67);
            this.thoughtsTextBox.MaxLength = 32767;
            this.thoughtsTextBox.Multiline = true;
            this.thoughtsTextBox.Name = "thoughtsTextBox";
            //this.thoughtsTextBox.PasswordChar = '\0';
            this.thoughtsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.thoughtsTextBox.SelectedText = "";
            this.thoughtsTextBox.Size = new System.Drawing.Size(359, 151);
            this.thoughtsTextBox.TabIndex = 1;
            this.thoughtsTextBox.Text = "[Thoughts]";
            this.thoughtsTextBox.UseSelectable = true;
            // 
            // saveChangesButton
            // 
            this.saveChangesButton.Location = new System.Drawing.Point(287, 224);
            this.saveChangesButton.Name = "saveChangesButton";
            this.saveChangesButton.Size = new System.Drawing.Size(75, 23);
            this.saveChangesButton.TabIndex = 2;
            this.saveChangesButton.Text = "Save";
            this.saveChangesButton.UseSelectable = true;
            this.saveChangesButton.Click += new System.EventHandler(this.saveChangesButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(206, 224);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 23);
            this.editButton.TabIndex = 2;
            this.editButton.Text = "Edit";
            this.editButton.UseSelectable = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // nextDayButton
            // 
            this.nextDayButton.Location = new System.Drawing.Point(49, 224);
            this.nextDayButton.Name = "nextDayButton";
            this.nextDayButton.Size = new System.Drawing.Size(39, 23);
            this.nextDayButton.TabIndex = 3;
            this.nextDayButton.Text = "->";
            this.nextDayButton.UseSelectable = true;
            this.nextDayButton.Click += new System.EventHandler(this.nextDayButton_Click);
            // 
            // previousDayButton
            // 
            this.previousDayButton.Location = new System.Drawing.Point(3, 224);
            this.previousDayButton.Name = "previousDayButton";
            this.previousDayButton.Size = new System.Drawing.Size(40, 23);
            this.previousDayButton.TabIndex = 3;
            this.previousDayButton.Text = "<-";
            this.previousDayButton.UseSelectable = true;
            this.previousDayButton.Click += new System.EventHandler(this.previousDayButton_Click);
            // 
            // DayControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.previousDayButton);
            this.Controls.Add(this.nextDayButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.saveChangesButton);
            this.Controls.Add(this.thoughtsTextBox);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.dayNumberLabel);
            this.Name = "DayControl";
            this.Size = new System.Drawing.Size(365, 439);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel dayNumberLabel;
        private MetroFramework.Controls.MetroLabel dateLabel;
        private MetroFramework.Controls.MetroTextBox thoughtsTextBox;
        private MetroFramework.Controls.MetroButton saveChangesButton;
        private MetroFramework.Controls.MetroButton editButton;
        private MetroFramework.Controls.MetroButton nextDayButton;
        private MetroFramework.Controls.MetroButton previousDayButton;
    }
}
