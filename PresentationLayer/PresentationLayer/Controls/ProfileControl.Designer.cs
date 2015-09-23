namespace PresentationLayer.Controls
{
    partial class ProfileControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.nameLabel = new MetroFramework.Controls.MetroLabel();
            this.ageTextLabel = new MetroFramework.Controls.MetroLabel();
            this.historyTextLabel = new MetroFramework.Controls.MetroLabel();
            this.ageLabel = new MetroFramework.Controls.MetroLabel();
            this.experienceTextLabel = new MetroFramework.Controls.MetroLabel();
            this.levelLabel = new MetroFramework.Controls.MetroLabel();
            this.experienceProgressBar = new MetroFramework.Controls.MetroProgressBar();
            this.historyLabel = new MetroFramework.Controls.MetroLabel();
            this.skillsTextLabel = new MetroFramework.Controls.MetroLabel();
            this.levelTextLabel = new MetroFramework.Controls.MetroLabel();
            this.experienceLabel = new MetroFramework.Controls.MetroLabel();
            this.skillsPanel = new MetroFramework.Controls.MetroPanel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.skillsGrid = new MetroFramework.Controls.MetroGrid();
            this.editProfileButton = new MetroFramework.Controls.MetroButton();
            this.saveChangesButton = new MetroFramework.Controls.MetroButton();
            this.workUnitsGrid = new MetroFramework.Controls.MetroGrid();
            this.workStartTimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workEndedTimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newSkillNameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.addNewSkillButton = new MetroFramework.Controls.MetroButton();
            this.addNewSkillPanel = new MetroFramework.Controls.MetroPanel();
            this.cancelChangesButton = new MetroFramework.Controls.MetroButton();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skillNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skillLevelColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skillExperienceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skillNewLevelProgressColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RemoveSkillButtonColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.skillsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skillsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workUnitsGrid)).BeginInit();
            this.addNewSkillPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.nameLabel.Location = new System.Drawing.Point(155, 9);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(58, 25);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name";
            // 
            // ageTextLabel
            // 
            this.ageTextLabel.AutoSize = true;
            this.ageTextLabel.Location = new System.Drawing.Point(3, 44);
            this.ageTextLabel.Name = "ageTextLabel";
            this.ageTextLabel.Size = new System.Drawing.Size(33, 19);
            this.ageTextLabel.TabIndex = 0;
            this.ageTextLabel.Text = "Age";
            // 
            // historyTextLabel
            // 
            this.historyTextLabel.AutoSize = true;
            this.historyTextLabel.Location = new System.Drawing.Point(3, 74);
            this.historyTextLabel.Name = "historyTextLabel";
            this.historyTextLabel.Size = new System.Drawing.Size(49, 19);
            this.historyTextLabel.TabIndex = 0;
            this.historyTextLabel.Text = "History";
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Location = new System.Drawing.Point(109, 44);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(77, 19);
            this.ageLabel.TabIndex = 0;
            this.ageLabel.Text = "(Age Value)";
            // 
            // experienceTextLabel
            // 
            this.experienceTextLabel.AutoSize = true;
            this.experienceTextLabel.Location = new System.Drawing.Point(3, 141);
            this.experienceTextLabel.Name = "experienceTextLabel";
            this.experienceTextLabel.Size = new System.Drawing.Size(72, 19);
            this.experienceTextLabel.TabIndex = 0;
            this.experienceTextLabel.Text = "Experience";
            // 
            // levelLabel
            // 
            this.levelLabel.AutoSize = true;
            this.levelLabel.Location = new System.Drawing.Point(109, 104);
            this.levelLabel.Name = "levelLabel";
            this.levelLabel.Size = new System.Drawing.Size(82, 19);
            this.levelLabel.TabIndex = 0;
            this.levelLabel.Text = "(Level Value)";
            // 
            // experienceProgressBar
            // 
            this.experienceProgressBar.Location = new System.Drawing.Point(3, 173);
            this.experienceProgressBar.Name = "experienceProgressBar";
            this.experienceProgressBar.Size = new System.Drawing.Size(479, 23);
            this.experienceProgressBar.TabIndex = 1;
            // 
            // historyLabel
            // 
            this.historyLabel.AutoSize = true;
            this.historyLabel.Location = new System.Drawing.Point(109, 74);
            this.historyLabel.Name = "historyLabel";
            this.historyLabel.Size = new System.Drawing.Size(93, 19);
            this.historyLabel.TabIndex = 0;
            this.historyLabel.Text = "(History Value)";
            // 
            // skillsTextLabel
            // 
            this.skillsTextLabel.AutoSize = true;
            this.skillsTextLabel.Location = new System.Drawing.Point(3, 225);
            this.skillsTextLabel.Name = "skillsTextLabel";
            this.skillsTextLabel.Size = new System.Drawing.Size(36, 19);
            this.skillsTextLabel.TabIndex = 0;
            this.skillsTextLabel.Text = "Skills";
            // 
            // levelTextLabel
            // 
            this.levelTextLabel.AutoSize = true;
            this.levelTextLabel.Location = new System.Drawing.Point(3, 104);
            this.levelTextLabel.Name = "levelTextLabel";
            this.levelTextLabel.Size = new System.Drawing.Size(38, 19);
            this.levelTextLabel.TabIndex = 0;
            this.levelTextLabel.Text = "Level";
            // 
            // experienceLabel
            // 
            this.experienceLabel.AutoSize = true;
            this.experienceLabel.Location = new System.Drawing.Point(109, 141);
            this.experienceLabel.Name = "experienceLabel";
            this.experienceLabel.Size = new System.Drawing.Size(116, 19);
            this.experienceLabel.TabIndex = 0;
            this.experienceLabel.Text = "(Experience Value)";
            // 
            // skillsPanel
            // 
            this.skillsPanel.Controls.Add(this.metroPanel1);
            this.skillsPanel.Controls.Add(this.skillsGrid);
            this.skillsPanel.HorizontalScrollbarBarColor = true;
            this.skillsPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.skillsPanel.HorizontalScrollbarSize = 10;
            this.skillsPanel.Location = new System.Drawing.Point(3, 247);
            this.skillsPanel.Name = "skillsPanel";
            this.skillsPanel.Size = new System.Drawing.Size(479, 86);
            this.skillsPanel.TabIndex = 2;
            this.skillsPanel.VerticalScrollbarBarColor = true;
            this.skillsPanel.VerticalScrollbarHighlightOnWheel = false;
            this.skillsPanel.VerticalScrollbarSize = 10;
            // 
            // metroPanel1
            // 
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 132);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(479, 36);
            this.metroPanel1.TabIndex = 3;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // skillsGrid
            // 
            this.skillsGrid.AllowUserToAddRows = false;
            this.skillsGrid.AllowUserToDeleteRows = false;
            this.skillsGrid.AllowUserToResizeRows = false;
            this.skillsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.skillsGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.skillsGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skillsGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.skillsGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.skillsGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.skillsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.skillsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.skillNameColumn,
            this.skillLevelColumn,
            this.skillExperienceColumn,
            this.skillNewLevelProgressColumn,
            this.RemoveSkillButtonColumn});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.skillsGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.skillsGrid.EnableHeadersVisualStyles = false;
            this.skillsGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.skillsGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.skillsGrid.Location = new System.Drawing.Point(0, 0);
            this.skillsGrid.Name = "skillsGrid";
            this.skillsGrid.ReadOnly = true;
            this.skillsGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.skillsGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.skillsGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.skillsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.skillsGrid.Size = new System.Drawing.Size(479, 129);
            this.skillsGrid.TabIndex = 2;
            this.skillsGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.skillsGrid_CellContentClick);
            // 
            // editProfileButton
            // 
            this.editProfileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.editProfileButton.Location = new System.Drawing.Point(6, 419);
            this.editProfileButton.Name = "editProfileButton";
            this.editProfileButton.Size = new System.Drawing.Size(106, 30);
            this.editProfileButton.TabIndex = 2;
            this.editProfileButton.Text = "Edit";
            this.editProfileButton.UseSelectable = true;
            this.editProfileButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // saveChangesButton
            // 
            this.saveChangesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.saveChangesButton.Location = new System.Drawing.Point(376, 419);
            this.saveChangesButton.Name = "saveChangesButton";
            this.saveChangesButton.Size = new System.Drawing.Size(106, 30);
            this.saveChangesButton.TabIndex = 2;
            this.saveChangesButton.Text = "Save";
            this.saveChangesButton.UseSelectable = true;
            this.saveChangesButton.Click += new System.EventHandler(this.saveButton_Click);
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
            this.workEndedTimeColumn});
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
            this.workUnitsGrid.Location = new System.Drawing.Point(488, 9);
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
            this.workUnitsGrid.Size = new System.Drawing.Size(471, 440);
            this.workUnitsGrid.TabIndex = 3;
            // 
            // workStartTimeColumn
            // 
            this.workStartTimeColumn.HeaderText = "Occured";
            this.workStartTimeColumn.Name = "workStartTimeColumn";
            this.workStartTimeColumn.ReadOnly = true;
            // 
            // workEndedTimeColumn
            // 
            this.workEndedTimeColumn.HeaderText = "Type";
            this.workEndedTimeColumn.Name = "workEndedTimeColumn";
            this.workEndedTimeColumn.ReadOnly = true;
            // 
            // newSkillNameTextBox
            // 
            this.newSkillNameTextBox.Lines = new string[] {
        "(New skil name)"};
            this.newSkillNameTextBox.Location = new System.Drawing.Point(3, 3);
            this.newSkillNameTextBox.MaxLength = 32767;
            this.newSkillNameTextBox.Name = "newSkillNameTextBox";
            this.newSkillNameTextBox.PasswordChar = '\0';
            this.newSkillNameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.newSkillNameTextBox.SelectedText = "";
            this.newSkillNameTextBox.Size = new System.Drawing.Size(349, 23);
            this.newSkillNameTextBox.TabIndex = 4;
            this.newSkillNameTextBox.Text = "(New skil name)";
            this.newSkillNameTextBox.UseSelectable = true;
            // 
            // addNewSkillButton
            // 
            this.addNewSkillButton.Location = new System.Drawing.Point(353, 3);
            this.addNewSkillButton.Name = "addNewSkillButton";
            this.addNewSkillButton.Size = new System.Drawing.Size(120, 23);
            this.addNewSkillButton.TabIndex = 5;
            this.addNewSkillButton.Text = "Add";
            this.addNewSkillButton.UseSelectable = true;
            this.addNewSkillButton.Click += new System.EventHandler(this.addNewSkillButton_Click);
            // 
            // addNewSkillPanel
            // 
            this.addNewSkillPanel.Controls.Add(this.addNewSkillButton);
            this.addNewSkillPanel.Controls.Add(this.newSkillNameTextBox);
            this.addNewSkillPanel.HorizontalScrollbarBarColor = true;
            this.addNewSkillPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.addNewSkillPanel.HorizontalScrollbarSize = 10;
            this.addNewSkillPanel.Location = new System.Drawing.Point(6, 384);
            this.addNewSkillPanel.Name = "addNewSkillPanel";
            this.addNewSkillPanel.Size = new System.Drawing.Size(476, 29);
            this.addNewSkillPanel.TabIndex = 6;
            this.addNewSkillPanel.VerticalScrollbarBarColor = true;
            this.addNewSkillPanel.VerticalScrollbarHighlightOnWheel = false;
            this.addNewSkillPanel.VerticalScrollbarSize = 10;
            // 
            // cancelChangesButton
            // 
            this.cancelChangesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cancelChangesButton.Location = new System.Drawing.Point(264, 419);
            this.cancelChangesButton.Name = "cancelChangesButton";
            this.cancelChangesButton.Size = new System.Drawing.Size(106, 30);
            this.cancelChangesButton.TabIndex = 2;
            this.cancelChangesButton.Text = "Cancel";
            this.cancelChangesButton.UseSelectable = true;
            this.cancelChangesButton.Click += new System.EventHandler(this.cancelChangesButton_Click);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // skillNameColumn
            // 
            this.skillNameColumn.HeaderText = "Name";
            this.skillNameColumn.Name = "skillNameColumn";
            this.skillNameColumn.ReadOnly = true;
            // 
            // skillLevelColumn
            // 
            this.skillLevelColumn.HeaderText = "Level";
            this.skillLevelColumn.Name = "skillLevelColumn";
            this.skillLevelColumn.ReadOnly = true;
            // 
            // skillExperienceColumn
            // 
            this.skillExperienceColumn.HeaderText = "Exp";
            this.skillExperienceColumn.Name = "skillExperienceColumn";
            this.skillExperienceColumn.ReadOnly = true;
            // 
            // skillNewLevelProgressColumn
            // 
            this.skillNewLevelProgressColumn.HeaderText = "New level";
            this.skillNewLevelProgressColumn.Name = "skillNewLevelProgressColumn";
            this.skillNewLevelProgressColumn.ReadOnly = true;
            // 
            // RemoveSkillButtonColumn
            // 
            this.RemoveSkillButtonColumn.HeaderText = "Remove";
            this.RemoveSkillButtonColumn.Name = "RemoveSkillButtonColumn";
            this.RemoveSkillButtonColumn.ReadOnly = true;
            this.RemoveSkillButtonColumn.Text = "X";
            // 
            // ProfileControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.addNewSkillPanel);
            this.Controls.Add(this.workUnitsGrid);
            this.Controls.Add(this.cancelChangesButton);
            this.Controls.Add(this.saveChangesButton);
            this.Controls.Add(this.editProfileButton);
            this.Controls.Add(this.skillsPanel);
            this.Controls.Add(this.experienceProgressBar);
            this.Controls.Add(this.levelTextLabel);
            this.Controls.Add(this.levelLabel);
            this.Controls.Add(this.skillsTextLabel);
            this.Controls.Add(this.experienceLabel);
            this.Controls.Add(this.experienceTextLabel);
            this.Controls.Add(this.historyLabel);
            this.Controls.Add(this.historyTextLabel);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.ageTextLabel);
            this.Controls.Add(this.nameLabel);
            this.Name = "ProfileControl";
            this.Size = new System.Drawing.Size(962, 455);
            this.skillsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.skillsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workUnitsGrid)).EndInit();
            this.addNewSkillPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel nameLabel;
        private MetroFramework.Controls.MetroLabel ageTextLabel;
        private MetroFramework.Controls.MetroLabel historyTextLabel;
        private MetroFramework.Controls.MetroLabel ageLabel;
        private MetroFramework.Controls.MetroLabel experienceTextLabel;
        private MetroFramework.Controls.MetroLabel levelLabel;
        private MetroFramework.Controls.MetroProgressBar experienceProgressBar;
        private MetroFramework.Controls.MetroLabel historyLabel;
        private MetroFramework.Controls.MetroLabel skillsTextLabel;
        private MetroFramework.Controls.MetroLabel levelTextLabel;
        private MetroFramework.Controls.MetroLabel experienceLabel;
        private MetroFramework.Controls.MetroPanel skillsPanel;
        private MetroFramework.Controls.MetroGrid skillsGrid;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton editProfileButton;
        private MetroFramework.Controls.MetroButton saveChangesButton;
        private MetroFramework.Controls.MetroGrid workUnitsGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn workStartTimeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workEndedTimeColumn;
        private MetroFramework.Controls.MetroTextBox newSkillNameTextBox;
        private MetroFramework.Controls.MetroButton addNewSkillButton;
        private MetroFramework.Controls.MetroPanel addNewSkillPanel;
        private MetroFramework.Controls.MetroButton cancelChangesButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn skillNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn skillLevelColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn skillExperienceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn skillNewLevelProgressColumn;
        private System.Windows.Forms.DataGridViewButtonColumn RemoveSkillButtonColumn;
    }
}
