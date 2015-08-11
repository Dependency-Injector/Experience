﻿using System.ComponentModel;
using MetroFramework.Controls;

namespace PresentationLayer.Controls
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.newTaskButton = new MetroFramework.Controls.MetroButton();
            this.nextTaskButton = new MetroFramework.Controls.MetroButton();
            this.previousTaskButton = new MetroFramework.Controls.MetroButton();
            this.taskViewPanel = new MetroFramework.Controls.MetroPanel();
            this.stopWorkingButton = new MetroFramework.Controls.MetroButton();
            this.startWorkButton = new MetroFramework.Controls.MetroButton();
            this.editButton = new MetroFramework.Controls.MetroButton();
            this.finishedButton = new MetroFramework.Controls.MetroButton();
            this.priorityLabel = new MetroFramework.Controls.MetroLabel();
            this.nameLabel = new MetroFramework.Controls.MetroLabel();
            this.startAndDueDate = new MetroFramework.Controls.MetroLabel();
            this.descriptionLabel = new MetroFramework.Controls.MetroLabel();
            this.workUnitsPanel = new MetroFramework.Controls.MetroPanel();
            this.workUnitsGrid = new MetroFramework.Controls.MetroGrid();
            this.workUnitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taskEditPanel = new MetroFramework.Controls.MetroPanel();
            this.removeButton = new MetroFramework.Controls.MetroButton();
            this.cancelButton = new MetroFramework.Controls.MetroButton();
            this.saveButton = new MetroFramework.Controls.MetroButton();
            this.descriptionTextBox = new MetroFramework.Controls.MetroTextBox();
            this.priorityPanel = new MetroFramework.Controls.MetroPanel();
            this.highPriorityRadioButton = new MetroFramework.Controls.MetroRadioButton();
            this.mediumPriorityRadioButton = new MetroFramework.Controls.MetroRadioButton();
            this.lowPriorityRadioButton = new MetroFramework.Controls.MetroRadioButton();
            this.dueDateTime = new MetroFramework.Controls.MetroDateTime();
            this.nameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.tasksListGrid = new MetroFramework.Controls.MetroGrid();
            this.taskBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taskDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idGridColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameGridColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dueDateGridColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priorityGridColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isFinishedGridColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.metroPanel1.SuspendLayout();
            this.taskViewPanel.SuspendLayout();
            this.workUnitsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workUnitsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workUnitBindingSource)).BeginInit();
            this.taskEditPanel.SuspendLayout();
            this.priorityPanel.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tasksListGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskBindingSource)).BeginInit();
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
            this.metroPanel1.Location = new System.Drawing.Point(230, 20);
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
            this.taskViewPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.taskViewPanel.Controls.Add(this.stopWorkingButton);
            this.taskViewPanel.Controls.Add(this.startWorkButton);
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
            this.taskViewPanel.Location = new System.Drawing.Point(18, 56);
            this.taskViewPanel.Name = "taskViewPanel";
            this.taskViewPanel.Size = new System.Drawing.Size(426, 302);
            this.taskViewPanel.TabIndex = 4;
            this.taskViewPanel.VerticalScrollbarBarColor = true;
            this.taskViewPanel.VerticalScrollbarHighlightOnWheel = false;
            this.taskViewPanel.VerticalScrollbarSize = 10;
            // 
            // stopWorkingButton
            // 
            this.stopWorkingButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.stopWorkingButton.Location = new System.Drawing.Point(155, 271);
            this.stopWorkingButton.Name = "stopWorkingButton";
            this.stopWorkingButton.Size = new System.Drawing.Size(85, 26);
            this.stopWorkingButton.TabIndex = 11;
            this.stopWorkingButton.Text = "Stop working";
            this.stopWorkingButton.UseSelectable = true;
            this.stopWorkingButton.Click += new System.EventHandler(this.stopWorkingButton_Click);
            // 
            // startWorkButton
            // 
            this.startWorkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.startWorkButton.Location = new System.Drawing.Point(246, 271);
            this.startWorkButton.Name = "startWorkButton";
            this.startWorkButton.Size = new System.Drawing.Size(85, 26);
            this.startWorkButton.TabIndex = 11;
            this.startWorkButton.Text = "Start working";
            this.startWorkButton.UseSelectable = true;
            this.startWorkButton.Click += new System.EventHandler(this.startWorkButton_Click);
            // 
            // editButton
            // 
            this.editButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.editButton.Location = new System.Drawing.Point(3, 271);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(84, 26);
            this.editButton.TabIndex = 9;
            this.editButton.Text = "Edit";
            this.editButton.UseSelectable = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // finishedButton
            // 
            this.finishedButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.finishedButton.Location = new System.Drawing.Point(337, 271);
            this.finishedButton.Name = "finishedButton";
            this.finishedButton.Size = new System.Drawing.Size(84, 26);
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
            this.priorityLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
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
            this.workUnitsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.workUnitsPanel.Controls.Add(this.workUnitsGrid);
            this.workUnitsPanel.HorizontalScrollbarBarColor = true;
            this.workUnitsPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.workUnitsPanel.HorizontalScrollbarSize = 10;
            this.workUnitsPanel.Location = new System.Drawing.Point(3, 93);
            this.workUnitsPanel.Name = "workUnitsPanel";
            this.workUnitsPanel.Size = new System.Drawing.Size(418, 172);
            this.workUnitsPanel.TabIndex = 7;
            this.workUnitsPanel.VerticalScrollbarBarColor = true;
            this.workUnitsPanel.VerticalScrollbarHighlightOnWheel = false;
            this.workUnitsPanel.VerticalScrollbarSize = 10;
            // 
            // workUnitsGrid
            // 
            this.workUnitsGrid.AllowUserToAddRows = false;
            this.workUnitsGrid.AllowUserToDeleteRows = false;
            this.workUnitsGrid.AllowUserToResizeRows = false;
            this.workUnitsGrid.AutoGenerateColumns = false;
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
            this.dataGridViewTextBoxColumn1,
            this.startTimeDataGridViewTextBoxColumn,
            this.endTimeDataGridViewTextBoxColumn,
            this.durationDataGridViewTextBoxColumn,
            this.taskDataGridViewTextBoxColumn});
            this.workUnitsGrid.DataSource = this.workUnitBindingSource;
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
            this.workUnitsGrid.Location = new System.Drawing.Point(3, 3);
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
            this.workUnitsGrid.Size = new System.Drawing.Size(408, 164);
            this.workUnitsGrid.TabIndex = 2;
            // 
            // workUnitBindingSource
            // 
            this.workUnitBindingSource.DataSource = typeof(DataAccessLayer.Model.WorkUnit);
            // 
            // taskEditPanel
            // 
            this.taskEditPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.taskEditPanel.Controls.Add(this.removeButton);
            this.taskEditPanel.Controls.Add(this.cancelButton);
            this.taskEditPanel.Controls.Add(this.saveButton);
            this.taskEditPanel.Controls.Add(this.descriptionTextBox);
            this.taskEditPanel.Controls.Add(this.priorityPanel);
            this.taskEditPanel.Controls.Add(this.dueDateTime);
            this.taskEditPanel.Controls.Add(this.nameTextBox);
            this.taskEditPanel.HorizontalScrollbarBarColor = true;
            this.taskEditPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.taskEditPanel.HorizontalScrollbarSize = 10;
            this.taskEditPanel.Location = new System.Drawing.Point(450, 56);
            this.taskEditPanel.Name = "taskEditPanel";
            this.taskEditPanel.Size = new System.Drawing.Size(245, 302);
            this.taskEditPanel.TabIndex = 5;
            this.taskEditPanel.VerticalScrollbarBarColor = true;
            this.taskEditPanel.VerticalScrollbarHighlightOnWheel = false;
            this.taskEditPanel.VerticalScrollbarSize = 10;
            // 
            // removeButton
            // 
            this.removeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.removeButton.Location = new System.Drawing.Point(4, 274);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(72, 23);
            this.removeButton.TabIndex = 13;
            this.removeButton.Text = "Remove";
            this.removeButton.UseSelectable = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cancelButton.Location = new System.Drawing.Point(82, 274);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 13;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseSelectable = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.saveButton.Location = new System.Drawing.Point(163, 274);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 13;
            this.saveButton.Text = "Save";
            this.saveButton.UseSelectable = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.descriptionTextBox.Lines = new string[] {
        "Description"};
            this.descriptionTextBox.Location = new System.Drawing.Point(4, 151);
            this.descriptionTextBox.MaxLength = 32767;
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            //this.descriptionTextBox.PasswordChar = '\0';
            this.descriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.descriptionTextBox.SelectedText = "";
            this.descriptionTextBox.Size = new System.Drawing.Size(233, 117);
            this.descriptionTextBox.TabIndex = 12;
            this.descriptionTextBox.Text = "Description";
            this.descriptionTextBox.UseSelectable = true;
            // 
            // priorityPanel
            // 
            this.priorityPanel.Controls.Add(this.highPriorityRadioButton);
            this.priorityPanel.Controls.Add(this.mediumPriorityRadioButton);
            this.priorityPanel.Controls.Add(this.lowPriorityRadioButton);
            this.priorityPanel.HorizontalScrollbarBarColor = true;
            this.priorityPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.priorityPanel.HorizontalScrollbarSize = 10;
            this.priorityPanel.Location = new System.Drawing.Point(4, 76);
            this.priorityPanel.Name = "priorityPanel";
            this.priorityPanel.Size = new System.Drawing.Size(234, 69);
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
            this.dueDateTime.Location = new System.Drawing.Point(3, 40);
            this.dueDateTime.MinimumSize = new System.Drawing.Size(0, 29);
            this.dueDateTime.Name = "dueDateTime";
            this.dueDateTime.Size = new System.Drawing.Size(234, 29);
            this.dueDateTime.TabIndex = 10;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Lines = new string[] {
        "Name"};
            this.nameTextBox.Location = new System.Drawing.Point(4, 11);
            this.nameTextBox.MaxLength = 32767;
            this.nameTextBox.Name = "nameTextBox";
            //this.nameTextBox.PasswordChar = '\0';
            this.nameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.nameTextBox.SelectedText = "";
            this.nameTextBox.Size = new System.Drawing.Size(233, 22);
            this.nameTextBox.TabIndex = 14;
            this.nameTextBox.Text = "Name";
            this.nameTextBox.UseSelectable = true;
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.tasksListGrid);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(18, 364);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(677, 198);
            this.metroPanel2.TabIndex = 6;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // tasksListGrid
            // 
            this.tasksListGrid.AllowUserToAddRows = false;
            this.tasksListGrid.AllowUserToDeleteRows = false;
            this.tasksListGrid.AllowUserToResizeRows = false;
            this.tasksListGrid.AutoGenerateColumns = false;
            this.tasksListGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tasksListGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tasksListGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.tasksListGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tasksListGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.tasksListGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tasksListGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idGridColumn,
            this.nameGridColumn,
            this.dueDateGridColumn,
            this.priorityGridColumn,
            this.isFinishedGridColumn});
            this.tasksListGrid.DataSource = this.taskBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tasksListGrid.DefaultCellStyle = dataGridViewCellStyle6;
            this.tasksListGrid.EnableHeadersVisualStyles = false;
            this.tasksListGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tasksListGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tasksListGrid.Location = new System.Drawing.Point(3, 3);
            this.tasksListGrid.Name = "tasksListGrid";
            this.tasksListGrid.ReadOnly = true;
            this.tasksListGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tasksListGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.tasksListGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.tasksListGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tasksListGrid.Size = new System.Drawing.Size(671, 192);
            this.tasksListGrid.TabIndex = 2;
            this.tasksListGrid.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.tasksListGrid_DataBindingComplete);
            this.tasksListGrid.SelectionChanged += new System.EventHandler(this.tasksListGrid_SelectionChanged);
            // 
            // taskBindingSource
            // 
            this.taskBindingSource.DataSource = typeof(DataAccessLayer.Model.Task);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // startTimeDataGridViewTextBoxColumn
            // 
            this.startTimeDataGridViewTextBoxColumn.DataPropertyName = "StartTime";
            this.startTimeDataGridViewTextBoxColumn.HeaderText = "Started";
            this.startTimeDataGridViewTextBoxColumn.Name = "startTimeDataGridViewTextBoxColumn";
            this.startTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // endTimeDataGridViewTextBoxColumn
            // 
            this.endTimeDataGridViewTextBoxColumn.DataPropertyName = "EndTime";
            this.endTimeDataGridViewTextBoxColumn.HeaderText = "Ended";
            this.endTimeDataGridViewTextBoxColumn.Name = "endTimeDataGridViewTextBoxColumn";
            this.endTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // durationDataGridViewTextBoxColumn
            // 
            this.durationDataGridViewTextBoxColumn.DataPropertyName = "Duration";
            this.durationDataGridViewTextBoxColumn.HeaderText = "Duration";
            this.durationDataGridViewTextBoxColumn.Name = "durationDataGridViewTextBoxColumn";
            this.durationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // taskDataGridViewTextBoxColumn
            // 
            this.taskDataGridViewTextBoxColumn.DataPropertyName = "Task";
            this.taskDataGridViewTextBoxColumn.HeaderText = "Task";
            this.taskDataGridViewTextBoxColumn.Name = "taskDataGridViewTextBoxColumn";
            this.taskDataGridViewTextBoxColumn.ReadOnly = true;
            this.taskDataGridViewTextBoxColumn.Visible = false;
            // 
            // idGridColumn
            // 
            this.idGridColumn.DataPropertyName = "Id";
            this.idGridColumn.HeaderText = "Id";
            this.idGridColumn.Name = "idGridColumn";
            this.idGridColumn.ReadOnly = true;
            this.idGridColumn.Visible = false;
            // 
            // nameGridColumn
            // 
            this.nameGridColumn.DataPropertyName = "Name";
            this.nameGridColumn.HeaderText = "Name";
            this.nameGridColumn.Name = "nameGridColumn";
            this.nameGridColumn.ReadOnly = true;
            // 
            // dueDateGridColumn
            // 
            this.dueDateGridColumn.DataPropertyName = "DueDate";
            dataGridViewCellStyle5.Format = "M";
            dataGridViewCellStyle5.NullValue = null;
            this.dueDateGridColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.dueDateGridColumn.HeaderText = "Deadline";
            this.dueDateGridColumn.Name = "dueDateGridColumn";
            this.dueDateGridColumn.ReadOnly = true;
            // 
            // priorityGridColumn
            // 
            this.priorityGridColumn.DataPropertyName = "Priority";
            this.priorityGridColumn.HeaderText = "Priority";
            this.priorityGridColumn.Name = "priorityGridColumn";
            this.priorityGridColumn.ReadOnly = true;
            // 
            // isFinishedGridColumn
            // 
            this.isFinishedGridColumn.DataPropertyName = "IsFinished";
            this.isFinishedGridColumn.HeaderText = "Finished";
            this.isFinishedGridColumn.Name = "isFinishedGridColumn";
            this.isFinishedGridColumn.ReadOnly = true;
            // 
            // TasksControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.taskEditPanel);
            this.Controls.Add(this.taskViewPanel);
            this.Controls.Add(this.metroPanel1);
            this.Name = "TasksControl";
            this.Size = new System.Drawing.Size(833, 579);
            this.Load += new System.EventHandler(this.TasksControl_Load);
            this.metroPanel1.ResumeLayout(false);
            this.taskViewPanel.ResumeLayout(false);
            this.taskViewPanel.PerformLayout();
            this.workUnitsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.workUnitsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workUnitBindingSource)).EndInit();
            this.taskEditPanel.ResumeLayout(false);
            this.priorityPanel.ResumeLayout(false);
            this.priorityPanel.PerformLayout();
            this.metroPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tasksListGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskBindingSource)).EndInit();
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
        private MetroTextBox descriptionTextBox;
        private MetroPanel priorityPanel;
        private MetroDateTime dueDateTime;
        private MetroTextBox nameTextBox;
        private MetroRadioButton highPriorityRadioButton;
        private MetroRadioButton mediumPriorityRadioButton;
        private MetroRadioButton lowPriorityRadioButton;
        private MetroButton removeButton;
        private MetroPanel metroPanel2;
        private MetroGrid tasksListGrid;
        private System.Windows.Forms.BindingSource taskBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dueDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isFinishedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priorityDataGridViewTextBoxColumn;
        private MetroButton stopWorkingButton;
        private MetroButton startWorkButton;
        private MetroGrid workUnitsGrid;
        private System.Windows.Forms.BindingSource workUnitBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn startTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idGridColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameGridColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dueDateGridColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priorityGridColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isFinishedGridColumn;
    }
}
