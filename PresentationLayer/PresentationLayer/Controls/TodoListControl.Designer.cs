using System.ComponentModel;
using MetroFramework.Controls;
using Model.Entities;

namespace PresentationLayer.Controls
{
    partial class TodoListControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonsPanel = new MetroFramework.Controls.MetroPanel();
            this.addTaskMetroLink = new MetroFramework.Controls.MetroLink();
            this.showFinishedTasksCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.newTaskButton = new MetroFramework.Controls.MetroButton();
            this.tasksPanel = new MetroFramework.Controls.MetroPanel();
            this.tasksListGrid = new MetroFramework.Controls.MetroGrid();
            this.buttonsPanel.SuspendLayout();
            this.tasksPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tasksListGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.Controls.Add(this.addTaskMetroLink);
            this.buttonsPanel.Controls.Add(this.showFinishedTasksCheckBox);
            this.buttonsPanel.Controls.Add(this.newTaskButton);
            this.buttonsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonsPanel.HorizontalScrollbarBarColor = true;
            this.buttonsPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.buttonsPanel.HorizontalScrollbarSize = 10;
            this.buttonsPanel.Location = new System.Drawing.Point(0, 473);
            this.buttonsPanel.Name = "buttonsPanel";
            this.buttonsPanel.Size = new System.Drawing.Size(581, 49);
            this.buttonsPanel.TabIndex = 3;
            this.buttonsPanel.VerticalScrollbarBarColor = true;
            this.buttonsPanel.VerticalScrollbarHighlightOnWheel = false;
            this.buttonsPanel.VerticalScrollbarSize = 10;
            // 
            // addTaskMetroLink
            // 
            this.addTaskMetroLink.Image = global::PresentationLayer.Properties.Resources.add_icon;
            this.addTaskMetroLink.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addTaskMetroLink.Location = new System.Drawing.Point(111, 9);
            this.addTaskMetroLink.Name = "addTaskMetroLink";
            this.addTaskMetroLink.NoFocusImage = global::PresentationLayer.Properties.Resources.add_icon_hover;
            this.addTaskMetroLink.Size = new System.Drawing.Size(91, 28);
            this.addTaskMetroLink.TabIndex = 4;
            this.addTaskMetroLink.Text = "Add";
            this.addTaskMetroLink.UseSelectable = true;
            this.addTaskMetroLink.Visible = false;
            this.addTaskMetroLink.Click += new System.EventHandler(this.addTaskMetroLink_Click);
            // 
            // showFinishedTasksCheckBox
            // 
            this.showFinishedTasksCheckBox.AutoSize = true;
            this.showFinishedTasksCheckBox.Location = new System.Drawing.Point(8, 22);
            this.showFinishedTasksCheckBox.Name = "showFinishedTasksCheckBox";
            this.showFinishedTasksCheckBox.Size = new System.Drawing.Size(97, 15);
            this.showFinishedTasksCheckBox.TabIndex = 3;
            this.showFinishedTasksCheckBox.Text = "Show finished";
            this.showFinishedTasksCheckBox.UseSelectable = true;
            this.showFinishedTasksCheckBox.Visible = false;
            this.showFinishedTasksCheckBox.CheckedChanged += new System.EventHandler(this.showFinishedTasksCheckBox_CheckedChanged);
            // 
            // newTaskButton
            // 
            this.newTaskButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.newTaskButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.newTaskButton.Highlight = true;
            this.newTaskButton.Location = new System.Drawing.Point(441, 9);
            this.newTaskButton.Name = "newTaskButton";
            this.newTaskButton.Size = new System.Drawing.Size(137, 31);
            this.newTaskButton.TabIndex = 2;
            this.newTaskButton.Text = "New task";
            this.newTaskButton.UseSelectable = true;
            this.newTaskButton.Click += new System.EventHandler(this.newTaskButton_Click);
            // 
            // tasksPanel
            // 
            this.tasksPanel.Controls.Add(this.tasksListGrid);
            this.tasksPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tasksPanel.HorizontalScrollbarBarColor = true;
            this.tasksPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.tasksPanel.HorizontalScrollbarSize = 10;
            this.tasksPanel.Location = new System.Drawing.Point(0, 0);
            this.tasksPanel.Name = "tasksPanel";
            this.tasksPanel.Size = new System.Drawing.Size(581, 473);
            this.tasksPanel.TabIndex = 4;
            this.tasksPanel.VerticalScrollbarBarColor = true;
            this.tasksPanel.VerticalScrollbarHighlightOnWheel = false;
            this.tasksPanel.VerticalScrollbarSize = 10;
            // 
            // tasksListGrid
            // 
            this.tasksListGrid.AllowUserToAddRows = false;
            this.tasksListGrid.AllowUserToDeleteRows = false;
            this.tasksListGrid.AllowUserToResizeRows = false;
            this.tasksListGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tasksListGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tasksListGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tasksListGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tasksListGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.tasksListGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tasksListGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tasksListGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tasksListGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.tasksListGrid.EnableHeadersVisualStyles = false;
            this.tasksListGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tasksListGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tasksListGrid.Location = new System.Drawing.Point(3, 3);
            this.tasksListGrid.MultiSelect = false;
            this.tasksListGrid.Name = "tasksListGrid";
            this.tasksListGrid.ReadOnly = true;
            this.tasksListGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tasksListGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.tasksListGrid.RowHeadersVisible = false;
            this.tasksListGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.tasksListGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tasksListGrid.Size = new System.Drawing.Size(575, 467);
            this.tasksListGrid.TabIndex = 2;
            this.tasksListGrid.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.tasksListGrid_DataBindingComplete);
            this.tasksListGrid.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.tasksListGrid_RowsAdded);
            this.tasksListGrid.DoubleClick += new System.EventHandler(this.tasksListGrid_DoubleClick);
            // 
            // TodoListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tasksPanel);
            this.Controls.Add(this.buttonsPanel);
            this.Name = "TodoListControl";
            this.Size = new System.Drawing.Size(581, 522);
            this.Load += new System.EventHandler(this.TasksControl_Load);
            this.buttonsPanel.ResumeLayout(false);
            this.buttonsPanel.PerformLayout();
            this.tasksPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tasksListGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroPanel buttonsPanel;
        private MetroButton newTaskButton;
        private MetroGrid tasksListGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dueDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isFinishedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priorityDataGridViewTextBoxColumn;
        private MetroCheckBox showFinishedTasksCheckBox;
        private MetroPanel tasksPanel;
        private MetroLink addTaskMetroLink;
    }
}
