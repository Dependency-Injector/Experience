namespace PresentationLayer.Controls
{
    partial class TaskDisplayControl
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
            this.closeEditFormButton = new MetroFramework.Controls.MetroButton();
            this.finishedButton = new MetroFramework.Controls.MetroButton();
            this.editButton = new MetroFramework.Controls.MetroButton();
            this.stopWorkingButton = new MetroFramework.Controls.MetroButton();
            this.startWorkButton = new MetroFramework.Controls.MetroButton();
            this.taskInfoPanel.SuspendLayout();
            this.workUnitsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workUnitsGrid)).BeginInit();
            this.taskActionButtonsPanel.SuspendLayout();
            this.SuspendLayout();
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
            this.taskInfoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.taskInfoPanel.HorizontalScrollbarBarColor = true;
            this.taskInfoPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.taskInfoPanel.HorizontalScrollbarSize = 10;
            this.taskInfoPanel.Location = new System.Drawing.Point(0, 0);
            this.taskInfoPanel.Name = "taskInfoPanel";
            this.taskInfoPanel.Size = new System.Drawing.Size(643, 303);
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
            this.workUnitsPanel.Controls.Add(this.workUnitsGrid);
            this.workUnitsPanel.Controls.Add(this.reportedWorkTextLabel);
            this.workUnitsPanel.HorizontalScrollbarBarColor = true;
            this.workUnitsPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.workUnitsPanel.HorizontalScrollbarSize = 10;
            this.workUnitsPanel.Location = new System.Drawing.Point(0, 0);
            this.workUnitsPanel.Name = "workUnitsPanel";
            this.workUnitsPanel.Size = new System.Drawing.Size(637, 249);
            this.workUnitsPanel.TabIndex = 7;
            this.workUnitsPanel.VerticalScrollbarBarColor = true;
            this.workUnitsPanel.VerticalScrollbarHighlightOnWheel = false;
            this.workUnitsPanel.VerticalScrollbarSize = 10;
            this.workUnitsPanel.Visible = false;
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.workUnitsGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.workUnitsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.workUnitsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.workStartTimeColumn,
            this.workEndedTimeColumn,
            this.workDurationColumn});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.workUnitsGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.workUnitsGrid.EnableHeadersVisualStyles = false;
            this.workUnitsGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.workUnitsGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.workUnitsGrid.Location = new System.Drawing.Point(0, 0);
            this.workUnitsGrid.Name = "workUnitsGrid";
            this.workUnitsGrid.ReadOnly = true;
            this.workUnitsGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.workUnitsGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.workUnitsGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.workUnitsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.workUnitsGrid.Size = new System.Drawing.Size(620, 214);
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
            this.taskActionButtonsPanel.Location = new System.Drawing.Point(0, 303);
            this.taskActionButtonsPanel.Name = "taskActionButtonsPanel";
            this.taskActionButtonsPanel.Size = new System.Drawing.Size(643, 36);
            this.taskActionButtonsPanel.TabIndex = 13;
            this.taskActionButtonsPanel.VerticalScrollbarBarColor = true;
            this.taskActionButtonsPanel.VerticalScrollbarHighlightOnWheel = false;
            this.taskActionButtonsPanel.VerticalScrollbarSize = 10;
            // 
            // closeEditFormButton
            // 
            this.closeEditFormButton.Location = new System.Drawing.Point(105, 3);
            this.closeEditFormButton.Name = "closeEditFormButton";
            this.closeEditFormButton.Size = new System.Drawing.Size(102, 26);
            this.closeEditFormButton.TabIndex = 8;
            this.closeEditFormButton.Text = "Close";
            this.closeEditFormButton.UseSelectable = true;
            // 
            // finishedButton
            // 
            this.finishedButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.finishedButton.Highlight = true;
            this.finishedButton.Location = new System.Drawing.Point(553, 3);
            this.finishedButton.Name = "finishedButton";
            this.finishedButton.Size = new System.Drawing.Size(84, 26);
            this.finishedButton.TabIndex = 10;
            this.finishedButton.Text = "Finished!";
            this.finishedButton.UseSelectable = true;
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(3, 3);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(99, 26);
            this.editButton.TabIndex = 9;
            this.editButton.Text = "Edit";
            this.editButton.UseSelectable = true;
            // 
            // stopWorkingButton
            // 
            this.stopWorkingButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.stopWorkingButton.Location = new System.Drawing.Point(371, 3);
            this.stopWorkingButton.Name = "stopWorkingButton";
            this.stopWorkingButton.Size = new System.Drawing.Size(85, 26);
            this.stopWorkingButton.TabIndex = 11;
            this.stopWorkingButton.Text = "Stop working";
            this.stopWorkingButton.UseSelectable = true;
            // 
            // startWorkButton
            // 
            this.startWorkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.startWorkButton.Location = new System.Drawing.Point(462, 3);
            this.startWorkButton.Name = "startWorkButton";
            this.startWorkButton.Size = new System.Drawing.Size(85, 26);
            this.startWorkButton.TabIndex = 11;
            this.startWorkButton.Text = "Start working";
            this.startWorkButton.UseSelectable = true;
            // 
            // TaskDetailsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.taskInfoPanel);
            this.Controls.Add(this.taskActionButtonsPanel);
            this.Controls.Add(this.workUnitsPanel);
            this.Name = "TaskDetailsView";
            this.Size = new System.Drawing.Size(643, 339);
            this.taskInfoPanel.ResumeLayout(false);
            this.taskInfoPanel.PerformLayout();
            this.workUnitsPanel.ResumeLayout(false);
            this.workUnitsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workUnitsGrid)).EndInit();
            this.taskActionButtonsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroPanel workUnitsPanel;
        private MetroFramework.Controls.MetroLabel reportedWorkTextLabel;
        private MetroFramework.Controls.MetroGrid workUnitsGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn workStartTimeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workEndedTimeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workDurationColumn;
        private MetroFramework.Controls.MetroPanel taskActionButtonsPanel;
        private MetroFramework.Controls.MetroButton closeEditFormButton;
        private MetroFramework.Controls.MetroButton finishedButton;
        private MetroFramework.Controls.MetroButton editButton;
        private MetroFramework.Controls.MetroButton stopWorkingButton;
        private MetroFramework.Controls.MetroButton startWorkButton;
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
    }
}
