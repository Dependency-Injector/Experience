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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.skillsGrid = new MetroFramework.Controls.MetroGrid();
            this.skillNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skillLevelColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skillExperienceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skillNewLevelProgressColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.editButton = new MetroFramework.Controls.MetroButton();
            this.saveButton = new MetroFramework.Controls.MetroButton();
            this.skillsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skillsGrid)).BeginInit();
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
            this.skillsPanel.Size = new System.Drawing.Size(479, 141);
            this.skillsPanel.TabIndex = 2;
            this.skillsPanel.VerticalScrollbarBarColor = true;
            this.skillsPanel.VerticalScrollbarHighlightOnWheel = false;
            this.skillsPanel.VerticalScrollbarSize = 10;
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
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.skillsGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.skillsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.skillsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.skillNameColumn,
            this.skillLevelColumn,
            this.skillExperienceColumn,
            this.skillNewLevelProgressColumn});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.skillsGrid.DefaultCellStyle = dataGridViewCellStyle8;
            this.skillsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skillsGrid.EnableHeadersVisualStyles = false;
            this.skillsGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.skillsGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.skillsGrid.Location = new System.Drawing.Point(0, 0);
            this.skillsGrid.Name = "skillsGrid";
            this.skillsGrid.ReadOnly = true;
            this.skillsGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.skillsGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.skillsGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.skillsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.skillsGrid.Size = new System.Drawing.Size(479, 141);
            this.skillsGrid.TabIndex = 2;
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
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(6, 382);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(106, 30);
            this.editButton.TabIndex = 2;
            this.editButton.Text = "Edit";
            this.editButton.UseSelectable = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(119, 382);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(106, 30);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save";
            this.saveButton.UseSelectable = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // ProfileControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.editButton);
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
            this.Size = new System.Drawing.Size(485, 418);
            this.skillsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.skillsGrid)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn skillNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn skillLevelColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn skillExperienceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn skillNewLevelProgressColumn;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton editButton;
        private MetroFramework.Controls.MetroButton saveButton;
    }
}
