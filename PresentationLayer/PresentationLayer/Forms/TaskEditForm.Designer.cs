namespace PresentationLayer.Forms
{
    partial class TaskEditForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.taskDetailsPanel = new MetroFramework.Controls.MetroPanel();
            this.taskInfoPanel = new MetroFramework.Controls.MetroPanel();
            this.childrenTasksPanel = new MetroFramework.Controls.MetroPanel();
            this.descriptionLabel = new MetroFramework.Controls.MetroLabel();
            this.totalExpGainedLabel = new MetroFramework.Controls.MetroLabel();
            this.totalWorkloadLabel = new MetroFramework.Controls.MetroLabel();
            this.attachedSkillNameLabel = new MetroFramework.Controls.MetroLabel();
            this.totalExpGainedTextLabel = new MetroFramework.Controls.MetroLabel();
            this.totalWorkloadTextLabel = new MetroFramework.Controls.MetroLabel();
            this.attachedSkillTextLabel = new MetroFramework.Controls.MetroLabel();
            this.nameLabel = new MetroFramework.Controls.MetroLabel();
            this.dueDateTextLabel = new MetroFramework.Controls.MetroLabel();
            this.descriptionTextLabel = new MetroFramework.Controls.MetroLabel();
            this.startAndDueDate = new MetroFramework.Controls.MetroLabel();
            this.parentTaskLabel = new MetroFramework.Controls.MetroLabel();
            this.childTasksLabel = new MetroFramework.Controls.MetroLabel();
            this.priorityLabel = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.priorityTextLabel = new MetroFramework.Controls.MetroLabel();
            this.workUnitsPanel = new MetroFramework.Controls.MetroPanel();
            this.reportedWorkTextLabel = new MetroFramework.Controls.MetroLabel();
            this.workUnitsGrid = new MetroFramework.Controls.MetroGrid();
            this.workStartTimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workEndedTimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workDurationColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taskActionButtonsPanel = new MetroFramework.Controls.MetroPanel();
            this.finishedButton = new MetroFramework.Controls.MetroButton();
            this.editButton = new MetroFramework.Controls.MetroButton();
            this.stopWorkingButton = new MetroFramework.Controls.MetroButton();
            this.startWorkButton = new MetroFramework.Controls.MetroButton();
            this.closeEditFormButton = new MetroFramework.Controls.MetroButton();
            this.taskEditPanel.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.priorityPanel.SuspendLayout();
            this.taskDetailsPanel.SuspendLayout();
            this.taskInfoPanel.SuspendLayout();
            this.workUnitsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workUnitsGrid)).BeginInit();
            this.taskActionButtonsPanel.SuspendLayout();
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
            this.taskEditPanel.Location = new System.Drawing.Point(20, 60);
            this.taskEditPanel.Name = "taskEditPanel";
            this.taskEditPanel.Size = new System.Drawing.Size(723, 588);
            this.taskEditPanel.TabIndex = 6;
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
            this.parentTaskComboBox.Size = new System.Drawing.Size(452, 29);
            this.parentTaskComboBox.TabIndex = 15;
            this.parentTaskComboBox.UseSelectable = true;
            this.parentTaskComboBox.ValueMember = "Key";
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
            this.skillToTrainComboBox.Size = new System.Drawing.Size(452, 29);
            this.skillToTrainComboBox.TabIndex = 15;
            this.skillToTrainComboBox.UseSelectable = true;
            this.skillToTrainComboBox.ValueMember = "Key";
            // 
            // removeButton
            // 
            this.removeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.removeButton.Location = new System.Drawing.Point(5, 552);
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
            this.cancelButton.Location = new System.Drawing.Point(542, 552);
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
            this.saveButton.Location = new System.Drawing.Point(623, 552);
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
            this.metroPanel1.Size = new System.Drawing.Size(306, 69);
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
            this.descriptionTextBox.CustomButton.Location = new System.Drawing.Point(609, 2);
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
            this.descriptionTextBox.Size = new System.Drawing.Size(695, 88);
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
            this.priorityPanel.Size = new System.Drawing.Size(142, 69);
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
            this.dueDateTime.Size = new System.Drawing.Size(309, 29);
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
            this.nameTextBox.CustomButton.Location = new System.Drawing.Point(674, 2);
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
            this.nameTextBox.Size = new System.Drawing.Size(694, 22);
            this.nameTextBox.TabIndex = 14;
            this.nameTextBox.Text = "Name";
            this.nameTextBox.UseSelectable = true;
            this.nameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.nameTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // taskDetailsPanel
            // 
            this.taskDetailsPanel.Controls.Add(this.taskInfoPanel);
            this.taskDetailsPanel.Controls.Add(this.workUnitsPanel);
            this.taskDetailsPanel.Controls.Add(this.taskActionButtonsPanel);
            this.taskDetailsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.taskDetailsPanel.HorizontalScrollbarBarColor = true;
            this.taskDetailsPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.taskDetailsPanel.HorizontalScrollbarSize = 10;
            this.taskDetailsPanel.Location = new System.Drawing.Point(20, 60);
            this.taskDetailsPanel.Name = "taskDetailsPanel";
            this.taskDetailsPanel.Size = new System.Drawing.Size(723, 588);
            this.taskDetailsPanel.TabIndex = 7;
            this.taskDetailsPanel.VerticalScrollbarBarColor = true;
            this.taskDetailsPanel.VerticalScrollbarHighlightOnWheel = false;
            this.taskDetailsPanel.VerticalScrollbarSize = 10;
            // 
            // taskInfoPanel
            // 
            this.taskInfoPanel.Controls.Add(this.childrenTasksPanel);
            this.taskInfoPanel.Controls.Add(this.descriptionLabel);
            this.taskInfoPanel.Controls.Add(this.totalExpGainedLabel);
            this.taskInfoPanel.Controls.Add(this.totalWorkloadLabel);
            this.taskInfoPanel.Controls.Add(this.attachedSkillNameLabel);
            this.taskInfoPanel.Controls.Add(this.totalExpGainedTextLabel);
            this.taskInfoPanel.Controls.Add(this.totalWorkloadTextLabel);
            this.taskInfoPanel.Controls.Add(this.attachedSkillTextLabel);
            this.taskInfoPanel.Controls.Add(this.nameLabel);
            this.taskInfoPanel.Controls.Add(this.dueDateTextLabel);
            this.taskInfoPanel.Controls.Add(this.descriptionTextLabel);
            this.taskInfoPanel.Controls.Add(this.startAndDueDate);
            this.taskInfoPanel.Controls.Add(this.parentTaskLabel);
            this.taskInfoPanel.Controls.Add(this.childTasksLabel);
            this.taskInfoPanel.Controls.Add(this.priorityLabel);
            this.taskInfoPanel.Controls.Add(this.metroLabel1);
            this.taskInfoPanel.Controls.Add(this.priorityTextLabel);
            this.taskInfoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.taskInfoPanel.HorizontalScrollbarBarColor = true;
            this.taskInfoPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.taskInfoPanel.HorizontalScrollbarSize = 10;
            this.taskInfoPanel.Location = new System.Drawing.Point(0, 0);
            this.taskInfoPanel.Name = "taskInfoPanel";
            this.taskInfoPanel.Size = new System.Drawing.Size(723, 235);
            this.taskInfoPanel.TabIndex = 13;
            this.taskInfoPanel.VerticalScrollbarBarColor = true;
            this.taskInfoPanel.VerticalScrollbarHighlightOnWheel = false;
            this.taskInfoPanel.VerticalScrollbarSize = 10;
            // 
            // childrenTasksPanel
            // 
            this.childrenTasksPanel.AutoScroll = true;
            this.childrenTasksPanel.HorizontalScrollbar = true;
            this.childrenTasksPanel.HorizontalScrollbarBarColor = true;
            this.childrenTasksPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.childrenTasksPanel.HorizontalScrollbarSize = 10;
            this.childrenTasksPanel.Location = new System.Drawing.Point(391, 133);
            this.childrenTasksPanel.Name = "childrenTasksPanel";
            this.childrenTasksPanel.Size = new System.Drawing.Size(181, 99);
            this.childrenTasksPanel.TabIndex = 17;
            this.childrenTasksPanel.VerticalScrollbar = true;
            this.childrenTasksPanel.VerticalScrollbarBarColor = true;
            this.childrenTasksPanel.VerticalScrollbarHighlightOnWheel = false;
            this.childrenTasksPanel.VerticalScrollbarSize = 10;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Location = new System.Drawing.Point(85, 85);
            this.descriptionLabel.Margin = new System.Windows.Forms.Padding(3);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(192, 137);
            this.descriptionLabel.TabIndex = 6;
            this.descriptionLabel.Text = "[Task description]";
            this.descriptionLabel.WrapToLine = true;
            // 
            // totalExpGainedLabel
            // 
            this.totalExpGainedLabel.AutoSize = true;
            this.totalExpGainedLabel.Location = new System.Drawing.Point(391, 87);
            this.totalExpGainedLabel.Name = "totalExpGainedLabel";
            this.totalExpGainedLabel.Size = new System.Drawing.Size(177, 19);
            this.totalExpGainedLabel.TabIndex = 13;
            this.totalExpGainedLabel.Text = "[Experience gained with task]";
            // 
            // totalWorkloadLabel
            // 
            this.totalWorkloadLabel.AutoSize = true;
            this.totalWorkloadLabel.Location = new System.Drawing.Point(391, 64);
            this.totalWorkloadLabel.Name = "totalWorkloadLabel";
            this.totalWorkloadLabel.Size = new System.Drawing.Size(130, 19);
            this.totalWorkloadLabel.TabIndex = 13;
            this.totalWorkloadLabel.Text = "[Time spend on task]";
            // 
            // attachedSkillNameLabel
            // 
            this.attachedSkillNameLabel.AutoSize = true;
            this.attachedSkillNameLabel.Location = new System.Drawing.Point(391, 41);
            this.attachedSkillNameLabel.Name = "attachedSkillNameLabel";
            this.attachedSkillNameLabel.Size = new System.Drawing.Size(130, 19);
            this.attachedSkillNameLabel.TabIndex = 13;
            this.attachedSkillNameLabel.Text = "[Attached skill name]";
            // 
            // totalExpGainedTextLabel
            // 
            this.totalExpGainedTextLabel.AutoSize = true;
            this.totalExpGainedTextLabel.Location = new System.Drawing.Point(289, 87);
            this.totalExpGainedTextLabel.Name = "totalExpGainedTextLabel";
            this.totalExpGainedTextLabel.Size = new System.Drawing.Size(105, 19);
            this.totalExpGainedTextLabel.TabIndex = 13;
            this.totalExpGainedTextLabel.Text = "Total experience";
            // 
            // totalWorkloadTextLabel
            // 
            this.totalWorkloadTextLabel.AutoSize = true;
            this.totalWorkloadTextLabel.Location = new System.Drawing.Point(289, 64);
            this.totalWorkloadTextLabel.Name = "totalWorkloadTextLabel";
            this.totalWorkloadTextLabel.Size = new System.Drawing.Size(96, 19);
            this.totalWorkloadTextLabel.TabIndex = 13;
            this.totalWorkloadTextLabel.Text = "Total workload";
            // 
            // attachedSkillTextLabel
            // 
            this.attachedSkillTextLabel.AutoSize = true;
            this.attachedSkillTextLabel.Location = new System.Drawing.Point(289, 41);
            this.attachedSkillTextLabel.Name = "attachedSkillTextLabel";
            this.attachedSkillTextLabel.Size = new System.Drawing.Size(85, 19);
            this.attachedSkillTextLabel.TabIndex = 13;
            this.attachedSkillTextLabel.Text = "Attached skill";
            // 
            // nameLabel
            // 
            this.nameLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.nameLabel.Location = new System.Drawing.Point(5, 5);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(593, 25);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "Name";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dueDateTextLabel
            // 
            this.dueDateTextLabel.AutoSize = true;
            this.dueDateTextLabel.Location = new System.Drawing.Point(6, 43);
            this.dueDateTextLabel.Name = "dueDateTextLabel";
            this.dueDateTextLabel.Size = new System.Drawing.Size(60, 19);
            this.dueDateTextLabel.TabIndex = 12;
            this.dueDateTextLabel.Text = "Deadline";
            // 
            // descriptionTextLabel
            // 
            this.descriptionTextLabel.AutoSize = true;
            this.descriptionTextLabel.Location = new System.Drawing.Point(6, 85);
            this.descriptionTextLabel.Name = "descriptionTextLabel";
            this.descriptionTextLabel.Size = new System.Drawing.Size(74, 19);
            this.descriptionTextLabel.TabIndex = 6;
            this.descriptionTextLabel.Text = "Description";
            // 
            // startAndDueDate
            // 
            this.startAndDueDate.AutoSize = true;
            this.startAndDueDate.Location = new System.Drawing.Point(85, 43);
            this.startAndDueDate.Name = "startAndDueDate";
            this.startAndDueDate.Size = new System.Drawing.Size(70, 19);
            this.startAndDueDate.TabIndex = 5;
            this.startAndDueDate.Text = "[Due date]";
            // 
            // parentTaskLabel
            // 
            this.parentTaskLabel.AutoSize = true;
            this.parentTaskLabel.Location = new System.Drawing.Point(391, 110);
            this.parentTaskLabel.Name = "parentTaskLabel";
            this.parentTaskLabel.Size = new System.Drawing.Size(118, 19);
            this.parentTaskLabel.TabIndex = 8;
            this.parentTaskLabel.Text = "[Parent task name]";
            this.parentTaskLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // childTasksLabel
            // 
            this.childTasksLabel.AutoSize = true;
            this.childTasksLabel.Location = new System.Drawing.Point(289, 133);
            this.childTasksLabel.Name = "childTasksLabel";
            this.childTasksLabel.Size = new System.Drawing.Size(93, 19);
            this.childTasksLabel.TabIndex = 8;
            this.childTasksLabel.Text = "Required tasks";
            this.childTasksLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // priorityLabel
            // 
            this.priorityLabel.AutoSize = true;
            this.priorityLabel.Location = new System.Drawing.Point(85, 64);
            this.priorityLabel.Name = "priorityLabel";
            this.priorityLabel.Size = new System.Drawing.Size(122, 19);
            this.priorityLabel.TabIndex = 8;
            this.priorityLabel.Text = "[Task priority value]";
            this.priorityLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(289, 110);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(73, 19);
            this.metroLabel1.TabIndex = 8;
            this.metroLabel1.Text = "Parent task";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // priorityTextLabel
            // 
            this.priorityTextLabel.AutoSize = true;
            this.priorityTextLabel.Location = new System.Drawing.Point(6, 64);
            this.priorityTextLabel.Name = "priorityTextLabel";
            this.priorityTextLabel.Size = new System.Drawing.Size(51, 19);
            this.priorityTextLabel.TabIndex = 8;
            this.priorityTextLabel.Text = "Priority";
            this.priorityTextLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // workUnitsPanel
            // 
            this.workUnitsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.workUnitsPanel.Controls.Add(this.reportedWorkTextLabel);
            this.workUnitsPanel.Controls.Add(this.workUnitsGrid);
            this.workUnitsPanel.HorizontalScrollbarBarColor = true;
            this.workUnitsPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.workUnitsPanel.HorizontalScrollbarSize = 10;
            this.workUnitsPanel.Location = new System.Drawing.Point(0, 238);
            this.workUnitsPanel.Name = "workUnitsPanel";
            this.workUnitsPanel.Size = new System.Drawing.Size(723, 312);
            this.workUnitsPanel.TabIndex = 7;
            this.workUnitsPanel.VerticalScrollbarBarColor = true;
            this.workUnitsPanel.VerticalScrollbarHighlightOnWheel = false;
            this.workUnitsPanel.VerticalScrollbarSize = 10;
            // 
            // reportedWorkTextLabel
            // 
            this.reportedWorkTextLabel.AutoSize = true;
            this.reportedWorkTextLabel.Location = new System.Drawing.Point(8, 6);
            this.reportedWorkTextLabel.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.reportedWorkTextLabel.Name = "reportedWorkTextLabel";
            this.reportedWorkTextLabel.Size = new System.Drawing.Size(96, 19);
            this.reportedWorkTextLabel.TabIndex = 3;
            this.reportedWorkTextLabel.Text = "Reported work";
            // 
            // workUnitsGrid
            // 
            this.workUnitsGrid.AllowUserToAddRows = false;
            this.workUnitsGrid.AllowUserToDeleteRows = false;
            this.workUnitsGrid.AllowUserToResizeRows = false;
            this.workUnitsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.workUnitsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.workUnitsGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.workUnitsGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.workUnitsGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.workUnitsGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.workUnitsGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.workUnitsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.workUnitsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.workStartTimeColumn,
            this.workEndedTimeColumn,
            this.workDurationColumn});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.workUnitsGrid.DefaultCellStyle = dataGridViewCellStyle5;
            this.workUnitsGrid.EnableHeadersVisualStyles = false;
            this.workUnitsGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.workUnitsGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.workUnitsGrid.Location = new System.Drawing.Point(6, 31);
            this.workUnitsGrid.Name = "workUnitsGrid";
            this.workUnitsGrid.ReadOnly = true;
            this.workUnitsGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.workUnitsGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.workUnitsGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.workUnitsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.workUnitsGrid.Size = new System.Drawing.Size(706, 277);
            this.workUnitsGrid.TabIndex = 2;
            // 
            // workStartTimeColumn
            // 
            this.workStartTimeColumn.HeaderText = "Started";
            this.workStartTimeColumn.Name = "workStartTimeColumn";
            this.workStartTimeColumn.ReadOnly = true;
            // 
            // workEndedTimeColumn
            // 
            this.workEndedTimeColumn.HeaderText = "Ended";
            this.workEndedTimeColumn.Name = "workEndedTimeColumn";
            this.workEndedTimeColumn.ReadOnly = true;
            // 
            // workDurationColumn
            // 
            this.workDurationColumn.HeaderText = "Duration";
            this.workDurationColumn.Name = "workDurationColumn";
            this.workDurationColumn.ReadOnly = true;
            // 
            // taskActionButtonsPanel
            // 
            this.taskActionButtonsPanel.Controls.Add(this.closeEditFormButton);
            this.taskActionButtonsPanel.Controls.Add(this.finishedButton);
            this.taskActionButtonsPanel.Controls.Add(this.editButton);
            this.taskActionButtonsPanel.Controls.Add(this.stopWorkingButton);
            this.taskActionButtonsPanel.Controls.Add(this.startWorkButton);
            this.taskActionButtonsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.taskActionButtonsPanel.HorizontalScrollbarBarColor = true;
            this.taskActionButtonsPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.taskActionButtonsPanel.HorizontalScrollbarSize = 10;
            this.taskActionButtonsPanel.Location = new System.Drawing.Point(0, 556);
            this.taskActionButtonsPanel.Name = "taskActionButtonsPanel";
            this.taskActionButtonsPanel.Size = new System.Drawing.Size(723, 32);
            this.taskActionButtonsPanel.TabIndex = 13;
            this.taskActionButtonsPanel.VerticalScrollbarBarColor = true;
            this.taskActionButtonsPanel.VerticalScrollbarHighlightOnWheel = false;
            this.taskActionButtonsPanel.VerticalScrollbarSize = 10;
            // 
            // finishedButton
            // 
            this.finishedButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.finishedButton.Highlight = true;
            this.finishedButton.Location = new System.Drawing.Point(633, 3);
            this.finishedButton.Name = "finishedButton";
            this.finishedButton.Size = new System.Drawing.Size(84, 26);
            this.finishedButton.TabIndex = 10;
            this.finishedButton.Text = "Finished!";
            this.finishedButton.UseSelectable = true;
            this.finishedButton.Click += new System.EventHandler(this.finishedButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(3, 3);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(99, 26);
            this.editButton.TabIndex = 9;
            this.editButton.Text = "Edit";
            this.editButton.UseSelectable = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // stopWorkingButton
            // 
            this.stopWorkingButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.stopWorkingButton.Location = new System.Drawing.Point(451, 3);
            this.stopWorkingButton.Name = "stopWorkingButton";
            this.stopWorkingButton.Size = new System.Drawing.Size(85, 26);
            this.stopWorkingButton.TabIndex = 11;
            this.stopWorkingButton.Text = "Stop working";
            this.stopWorkingButton.UseSelectable = true;
            this.stopWorkingButton.Click += new System.EventHandler(this.stopWorkingButton_Click);
            // 
            // startWorkButton
            // 
            this.startWorkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.startWorkButton.Location = new System.Drawing.Point(542, 3);
            this.startWorkButton.Name = "startWorkButton";
            this.startWorkButton.Size = new System.Drawing.Size(85, 26);
            this.startWorkButton.TabIndex = 11;
            this.startWorkButton.Text = "Start working";
            this.startWorkButton.UseSelectable = true;
            this.startWorkButton.Click += new System.EventHandler(this.startWorkButton_Click);
            // 
            // closeEditFormButton
            // 
            this.closeEditFormButton.Location = new System.Drawing.Point(105, 3);
            this.closeEditFormButton.Name = "closeEditFormButton";
            this.closeEditFormButton.Size = new System.Drawing.Size(102, 26);
            this.closeEditFormButton.TabIndex = 8;
            this.closeEditFormButton.Text = "Close";
            this.closeEditFormButton.UseSelectable = true;
            this.closeEditFormButton.Click += new System.EventHandler(this.closeEditFormButton_Click);
            // 
            // TaskEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 668);
            this.Controls.Add(this.taskDetailsPanel);
            this.Controls.Add(this.taskEditPanel);
            this.Name = "TaskEditForm";
            this.Text = "TaskEditForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TaskEditForm_FormClosing);
            this.taskEditPanel.ResumeLayout(false);
            this.taskEditPanel.PerformLayout();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.priorityPanel.ResumeLayout(false);
            this.priorityPanel.PerformLayout();
            this.taskDetailsPanel.ResumeLayout(false);
            this.taskInfoPanel.ResumeLayout(false);
            this.taskInfoPanel.PerformLayout();
            this.workUnitsPanel.ResumeLayout(false);
            this.workUnitsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workUnitsGrid)).EndInit();
            this.taskActionButtonsPanel.ResumeLayout(false);
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
        private MetroFramework.Controls.MetroPanel taskDetailsPanel;
        private MetroFramework.Controls.MetroPanel taskInfoPanel;
        private MetroFramework.Controls.MetroPanel childrenTasksPanel;
        private MetroFramework.Controls.MetroLabel descriptionLabel;
        private MetroFramework.Controls.MetroLabel totalExpGainedLabel;
        private MetroFramework.Controls.MetroLabel totalWorkloadLabel;
        private MetroFramework.Controls.MetroLabel attachedSkillNameLabel;
        private MetroFramework.Controls.MetroLabel totalExpGainedTextLabel;
        private MetroFramework.Controls.MetroLabel totalWorkloadTextLabel;
        private MetroFramework.Controls.MetroLabel attachedSkillTextLabel;
        private MetroFramework.Controls.MetroLabel nameLabel;
        private MetroFramework.Controls.MetroLabel dueDateTextLabel;
        private MetroFramework.Controls.MetroLabel descriptionTextLabel;
        private MetroFramework.Controls.MetroLabel startAndDueDate;
        private MetroFramework.Controls.MetroLabel parentTaskLabel;
        private MetroFramework.Controls.MetroLabel childTasksLabel;
        private MetroFramework.Controls.MetroLabel priorityLabel;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel priorityTextLabel;
        private MetroFramework.Controls.MetroPanel workUnitsPanel;
        private MetroFramework.Controls.MetroLabel reportedWorkTextLabel;
        private MetroFramework.Controls.MetroGrid workUnitsGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn workStartTimeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workEndedTimeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workDurationColumn;
        private MetroFramework.Controls.MetroPanel taskActionButtonsPanel;
        private MetroFramework.Controls.MetroButton finishedButton;
        private MetroFramework.Controls.MetroButton editButton;
        private MetroFramework.Controls.MetroButton stopWorkingButton;
        private MetroFramework.Controls.MetroButton startWorkButton;
        private MetroFramework.Controls.MetroButton closeEditFormButton;
    }
}