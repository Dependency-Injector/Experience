namespace View.Controls
{
    partial class TaskEditControl
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
            this.taskEditPanel = new MetroFramework.Controls.MetroPanel();
            this.hardnessTextLabel = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.parentTaskTextLabel = new MetroFramework.Controls.MetroLabel();
            this.deadlineTextLabel = new MetroFramework.Controls.MetroLabel();
            this.skillToTrainTextLabel = new MetroFramework.Controls.MetroLabel();
            this.parentTaskComboBox = new MetroFramework.Controls.MetroComboBox();
            this.skillToTrainComboBox = new MetroFramework.Controls.MetroComboBox();
            this.removeButton = new MetroFramework.Controls.MetroButton();
            this.cancelButton = new MetroFramework.Controls.MetroButton();
            this.saveButton = new MetroFramework.Controls.MetroButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.hardTaskRadioButton = new MetroFramework.Controls.MetroRadioButton();
            this.normalTaskRadioButton = new MetroFramework.Controls.MetroRadioButton();
            this.easyTaskRadioButton = new MetroFramework.Controls.MetroRadioButton();
            this.descriptionTextBox = new MetroFramework.Controls.MetroTextBox();
            this.priorityPanel = new MetroFramework.Controls.MetroPanel();
            this.highPriorityRadioButton = new MetroFramework.Controls.MetroRadioButton();
            this.mediumPriorityRadioButton = new MetroFramework.Controls.MetroRadioButton();
            this.lowPriorityRadioButton = new MetroFramework.Controls.MetroRadioButton();
            this.dueDateTime = new MetroFramework.Controls.MetroDateTime();
            this.nameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.taskEditPanel.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.priorityPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // taskEditPanel
            // 
            this.taskEditPanel.Controls.Add(this.hardnessTextLabel);
            this.taskEditPanel.Controls.Add(this.metroLabel2);
            this.taskEditPanel.Controls.Add(this.parentTaskTextLabel);
            this.taskEditPanel.Controls.Add(this.deadlineTextLabel);
            this.taskEditPanel.Controls.Add(this.skillToTrainTextLabel);
            this.taskEditPanel.Controls.Add(this.parentTaskComboBox);
            this.taskEditPanel.Controls.Add(this.skillToTrainComboBox);
            this.taskEditPanel.Controls.Add(this.removeButton);
            this.taskEditPanel.Controls.Add(this.cancelButton);
            this.taskEditPanel.Controls.Add(this.saveButton);
            this.taskEditPanel.Controls.Add(this.metroPanel1);
            this.taskEditPanel.Controls.Add(this.descriptionTextBox);
            this.taskEditPanel.Controls.Add(this.priorityPanel);
            this.taskEditPanel.Controls.Add(this.dueDateTime);
            this.taskEditPanel.Controls.Add(this.nameTextBox);
            this.taskEditPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.taskEditPanel.HorizontalScrollbarBarColor = true;
            this.taskEditPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.taskEditPanel.HorizontalScrollbarSize = 10;
            this.taskEditPanel.Location = new System.Drawing.Point(0, 0);
            this.taskEditPanel.Name = "taskEditPanel";
            this.taskEditPanel.Size = new System.Drawing.Size(644, 570);
            this.taskEditPanel.TabIndex = 7;
            this.taskEditPanel.VerticalScrollbarBarColor = true;
            this.taskEditPanel.VerticalScrollbarHighlightOnWheel = false;
            this.taskEditPanel.VerticalScrollbarSize = 10;
            // 
            // hardnessTextLabel
            // 
            this.hardnessTextLabel.AutoSize = true;
            this.hardnessTextLabel.Location = new System.Drawing.Point(253, 289);
            this.hardnessTextLabel.Name = "hardnessTextLabel";
            this.hardnessTextLabel.Size = new System.Drawing.Size(62, 19);
            this.hardnessTextLabel.TabIndex = 16;
            this.hardnessTextLabel.Text = "Hardness";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(10, 289);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(51, 19);
            this.metroLabel2.TabIndex = 16;
            this.metroLabel2.Text = "Priority";
            // 
            // parentTaskTextLabel
            // 
            this.parentTaskTextLabel.AutoSize = true;
            this.parentTaskTextLabel.Location = new System.Drawing.Point(10, 247);
            this.parentTaskTextLabel.Name = "parentTaskTextLabel";
            this.parentTaskTextLabel.Size = new System.Drawing.Size(73, 19);
            this.parentTaskTextLabel.TabIndex = 16;
            this.parentTaskTextLabel.Text = "Parent task";
            // 
            // deadlineTextLabel
            // 
            this.deadlineTextLabel.AutoSize = true;
            this.deadlineTextLabel.Location = new System.Drawing.Point(10, 165);
            this.deadlineTextLabel.Name = "deadlineTextLabel";
            this.deadlineTextLabel.Size = new System.Drawing.Size(60, 19);
            this.deadlineTextLabel.TabIndex = 16;
            this.deadlineTextLabel.Text = "Deadline";
            // 
            // skillToTrainTextLabel
            // 
            this.skillToTrainTextLabel.AutoSize = true;
            this.skillToTrainTextLabel.Location = new System.Drawing.Point(10, 203);
            this.skillToTrainTextLabel.Name = "skillToTrainTextLabel";
            this.skillToTrainTextLabel.Size = new System.Drawing.Size(77, 19);
            this.skillToTrainTextLabel.TabIndex = 16;
            this.skillToTrainTextLabel.Text = "Skill to train";
            // 
            // parentTaskComboBox
            // 
            this.parentTaskComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.parentTaskComboBox.DisplayMember = "Value";
            this.parentTaskComboBox.FormattingEnabled = true;
            this.parentTaskComboBox.ItemHeight = 23;
            this.parentTaskComboBox.Location = new System.Drawing.Point(253, 245);
            this.parentTaskComboBox.Name = "parentTaskComboBox";
            this.parentTaskComboBox.Size = new System.Drawing.Size(373, 29);
            this.parentTaskComboBox.TabIndex = 15;
            this.parentTaskComboBox.UseSelectable = true;
            this.parentTaskComboBox.ValueMember = "Key";
            this.parentTaskComboBox.SelectedIndexChanged += new System.EventHandler(this.parentTaskComboBox_SelectedIndexChanged);
            // 
            // skillToTrainComboBox
            // 
            this.skillToTrainComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.skillToTrainComboBox.DisplayMember = "Value";
            this.skillToTrainComboBox.FormattingEnabled = true;
            this.skillToTrainComboBox.ItemHeight = 23;
            this.skillToTrainComboBox.Location = new System.Drawing.Point(253, 202);
            this.skillToTrainComboBox.Name = "skillToTrainComboBox";
            this.skillToTrainComboBox.Size = new System.Drawing.Size(373, 29);
            this.skillToTrainComboBox.TabIndex = 15;
            this.skillToTrainComboBox.UseSelectable = true;
            this.skillToTrainComboBox.ValueMember = "Key";
            // 
            // removeButton
            // 
            this.removeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.removeButton.Location = new System.Drawing.Point(11, 534);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(72, 29);
            this.removeButton.TabIndex = 13;
            this.removeButton.Text = "Remove";
            this.removeButton.UseSelectable = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.Location = new System.Drawing.Point(468, 534);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 29);
            this.cancelButton.TabIndex = 13;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseSelectable = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.Location = new System.Drawing.Point(549, 534);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(77, 29);
            this.saveButton.TabIndex = 13;
            this.saveButton.Text = "Save";
            this.saveButton.UseSelectable = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel1.Controls.Add(this.hardTaskRadioButton);
            this.metroPanel1.Controls.Add(this.normalTaskRadioButton);
            this.metroPanel1.Controls.Add(this.easyTaskRadioButton);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(337, 289);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(227, 69);
            this.metroPanel1.TabIndex = 11;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // hardTaskRadioButton
            // 
            this.hardTaskRadioButton.AutoSize = true;
            this.hardTaskRadioButton.Location = new System.Drawing.Point(4, 46);
            this.hardTaskRadioButton.Name = "hardTaskRadioButton";
            this.hardTaskRadioButton.Size = new System.Drawing.Size(87, 15);
            this.hardTaskRadioButton.TabIndex = 2;
            this.hardTaskRadioButton.Text = "Hard / Long";
            this.hardTaskRadioButton.UseSelectable = true;
            // 
            // normalTaskRadioButton
            // 
            this.normalTaskRadioButton.AutoSize = true;
            this.normalTaskRadioButton.Location = new System.Drawing.Point(4, 25);
            this.normalTaskRadioButton.Name = "normalTaskRadioButton";
            this.normalTaskRadioButton.Size = new System.Drawing.Size(134, 15);
            this.normalTaskRadioButton.TabIndex = 2;
            this.normalTaskRadioButton.Text = "Normal / Below hour";
            this.normalTaskRadioButton.UseSelectable = true;
            // 
            // easyTaskRadioButton
            // 
            this.easyTaskRadioButton.AutoSize = true;
            this.easyTaskRadioButton.Location = new System.Drawing.Point(4, 4);
            this.easyTaskRadioButton.Name = "easyTaskRadioButton";
            this.easyTaskRadioButton.Size = new System.Drawing.Size(89, 15);
            this.easyTaskRadioButton.TabIndex = 2;
            this.easyTaskRadioButton.Text = "Easy / Trivial";
            this.easyTaskRadioButton.UseSelectable = true;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.descriptionTextBox.CustomButton.Image = null;
            this.descriptionTextBox.CustomButton.Location = new System.Drawing.Point(530, 2);
            this.descriptionTextBox.CustomButton.Name = "";
            this.descriptionTextBox.CustomButton.Size = new System.Drawing.Size(83, 83);
            this.descriptionTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.descriptionTextBox.CustomButton.TabIndex = 1;
            this.descriptionTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.descriptionTextBox.CustomButton.UseSelectable = true;
            this.descriptionTextBox.CustomButton.Visible = false;
            this.descriptionTextBox.Lines = new string[] {
        "Description"};
            this.descriptionTextBox.Location = new System.Drawing.Point(10, 51);
            this.descriptionTextBox.MaxLength = 32767;
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.PasswordChar = '\0';
            this.descriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.descriptionTextBox.SelectedText = "";
            this.descriptionTextBox.SelectionLength = 0;
            this.descriptionTextBox.SelectionStart = 0;
            this.descriptionTextBox.Size = new System.Drawing.Size(616, 88);
            this.descriptionTextBox.TabIndex = 12;
            this.descriptionTextBox.Text = "Description";
            this.descriptionTextBox.UseSelectable = true;
            this.descriptionTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.descriptionTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // priorityPanel
            // 
            this.priorityPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.priorityPanel.Controls.Add(this.highPriorityRadioButton);
            this.priorityPanel.Controls.Add(this.mediumPriorityRadioButton);
            this.priorityPanel.Controls.Add(this.lowPriorityRadioButton);
            this.priorityPanel.HorizontalScrollbarBarColor = true;
            this.priorityPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.priorityPanel.HorizontalScrollbarSize = 10;
            this.priorityPanel.Location = new System.Drawing.Point(105, 289);
            this.priorityPanel.Name = "priorityPanel";
            this.priorityPanel.Size = new System.Drawing.Size(63, 69);
            this.priorityPanel.TabIndex = 11;
            this.priorityPanel.VerticalScrollbarBarColor = true;
            this.priorityPanel.VerticalScrollbarHighlightOnWheel = false;
            this.priorityPanel.VerticalScrollbarSize = 10;
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
            // 
            // mediumPriorityRadioButton
            // 
            this.mediumPriorityRadioButton.AutoSize = true;
            this.mediumPriorityRadioButton.Location = new System.Drawing.Point(4, 25);
            this.mediumPriorityRadioButton.Name = "mediumPriorityRadioButton";
            this.mediumPriorityRadioButton.Size = new System.Drawing.Size(68, 15);
            this.mediumPriorityRadioButton.TabIndex = 2;
            this.mediumPriorityRadioButton.Text = "Medium";
            this.mediumPriorityRadioButton.UseSelectable = true;
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
            // dueDateTime
            // 
            this.dueDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dueDateTime.Location = new System.Drawing.Point(253, 159);
            this.dueDateTime.MinimumSize = new System.Drawing.Size(0, 29);
            this.dueDateTime.Name = "dueDateTime";
            this.dueDateTime.Size = new System.Drawing.Size(230, 29);
            this.dueDateTime.TabIndex = 10;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.nameTextBox.CustomButton.Image = null;
            this.nameTextBox.CustomButton.Location = new System.Drawing.Point(595, 2);
            this.nameTextBox.CustomButton.Name = "";
            this.nameTextBox.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.nameTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.nameTextBox.CustomButton.TabIndex = 1;
            this.nameTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.nameTextBox.CustomButton.UseSelectable = true;
            this.nameTextBox.CustomButton.Visible = false;
            this.nameTextBox.Lines = new string[] {
        "Name"};
            this.nameTextBox.Location = new System.Drawing.Point(11, 11);
            this.nameTextBox.MaxLength = 32767;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.PasswordChar = '\0';
            this.nameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.nameTextBox.SelectedText = "";
            this.nameTextBox.SelectionLength = 0;
            this.nameTextBox.SelectionStart = 0;
            this.nameTextBox.Size = new System.Drawing.Size(615, 22);
            this.nameTextBox.TabIndex = 14;
            this.nameTextBox.Text = "Name";
            this.nameTextBox.UseSelectable = true;
            this.nameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.nameTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TaskEditControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.taskEditPanel);
            this.Name = "TaskEditControl";
            this.Size = new System.Drawing.Size(644, 570);
            this.taskEditPanel.ResumeLayout(false);
            this.taskEditPanel.PerformLayout();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.priorityPanel.ResumeLayout(false);
            this.priorityPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel taskEditPanel;
        private MetroFramework.Controls.MetroLabel hardnessTextLabel;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel parentTaskTextLabel;
        private MetroFramework.Controls.MetroLabel deadlineTextLabel;
        private MetroFramework.Controls.MetroLabel skillToTrainTextLabel;
        private MetroFramework.Controls.MetroComboBox parentTaskComboBox;
        private MetroFramework.Controls.MetroComboBox skillToTrainComboBox;
        private MetroFramework.Controls.MetroButton removeButton;
        private MetroFramework.Controls.MetroButton cancelButton;
        private MetroFramework.Controls.MetroButton saveButton;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroRadioButton hardTaskRadioButton;
        private MetroFramework.Controls.MetroRadioButton normalTaskRadioButton;
        private MetroFramework.Controls.MetroRadioButton easyTaskRadioButton;
        private MetroFramework.Controls.MetroTextBox descriptionTextBox;
        private MetroFramework.Controls.MetroPanel priorityPanel;
        private MetroFramework.Controls.MetroRadioButton highPriorityRadioButton;
        private MetroFramework.Controls.MetroRadioButton mediumPriorityRadioButton;
        private MetroFramework.Controls.MetroRadioButton lowPriorityRadioButton;
        private MetroFramework.Controls.MetroDateTime dueDateTime;
        private MetroFramework.Controls.MetroTextBox nameTextBox;
    }
}
