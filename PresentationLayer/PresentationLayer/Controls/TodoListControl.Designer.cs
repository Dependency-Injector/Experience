using System.ComponentModel;
using MetroFramework.Controls;

namespace View.Controls
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonsPanel = new MetroFramework.Controls.MetroPanel();
            this.displayOptionsPanel = new MetroFramework.Controls.MetroPanel();
            this.displayOptionsLabel = new MetroFramework.Controls.MetroLabel();
            this.showFinishedTasksCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.sortingOptionsPanel = new MetroFramework.Controls.MetroPanel();
            this.sortingOptionsLabel = new MetroFramework.Controls.MetroLabel();
            this.sortByGoalRadioButton = new MetroFramework.Controls.MetroRadioButton();
            this.sortByDueDateRadioButton = new MetroFramework.Controls.MetroRadioButton();
            this.newTaskButton = new MetroFramework.Controls.MetroButton();
            this.tasksPanel = new MetroFramework.Controls.MetroPanel();
            this.tasksListGrid = new MetroFramework.Controls.MetroGrid();
            this.buttonsPanel.SuspendLayout();
            this.displayOptionsPanel.SuspendLayout();
            this.sortingOptionsPanel.SuspendLayout();
            this.tasksPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tasksListGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.Controls.Add(this.displayOptionsPanel);
            this.buttonsPanel.Controls.Add(this.sortingOptionsPanel);
            this.buttonsPanel.Controls.Add(this.newTaskButton);
            this.buttonsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonsPanel.HorizontalScrollbarBarColor = true;
            this.buttonsPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.buttonsPanel.HorizontalScrollbarSize = 10;
            this.buttonsPanel.Location = new System.Drawing.Point(0, 435);
            this.buttonsPanel.Name = "buttonsPanel";
            this.buttonsPanel.Size = new System.Drawing.Size(581, 87);
            this.buttonsPanel.TabIndex = 3;
            this.buttonsPanel.VerticalScrollbarBarColor = true;
            this.buttonsPanel.VerticalScrollbarHighlightOnWheel = false;
            this.buttonsPanel.VerticalScrollbarSize = 10;
            // 
            // displayOptionsPanel
            // 
            this.displayOptionsPanel.Controls.Add(this.displayOptionsLabel);
            this.displayOptionsPanel.Controls.Add(this.showFinishedTasksCheckBox);
            this.displayOptionsPanel.HorizontalScrollbarBarColor = true;
            this.displayOptionsPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.displayOptionsPanel.HorizontalScrollbarSize = 10;
            this.displayOptionsPanel.Location = new System.Drawing.Point(3, 6);
            this.displayOptionsPanel.Name = "displayOptionsPanel";
            this.displayOptionsPanel.Size = new System.Drawing.Size(180, 78);
            this.displayOptionsPanel.TabIndex = 7;
            this.displayOptionsPanel.VerticalScrollbarBarColor = true;
            this.displayOptionsPanel.VerticalScrollbarHighlightOnWheel = false;
            this.displayOptionsPanel.VerticalScrollbarSize = 10;
            // 
            // displayOptionsLabel
            // 
            this.displayOptionsLabel.AutoSize = true;
            this.displayOptionsLabel.Location = new System.Drawing.Point(3, 8);
            this.displayOptionsLabel.Name = "displayOptionsLabel";
            this.displayOptionsLabel.Size = new System.Drawing.Size(50, 19);
            this.displayOptionsLabel.TabIndex = 6;
            this.displayOptionsLabel.Text = "Display";
            // 
            // showFinishedTasksCheckBox
            // 
            this.showFinishedTasksCheckBox.AutoSize = true;
            this.showFinishedTasksCheckBox.Location = new System.Drawing.Point(15, 30);
            this.showFinishedTasksCheckBox.Name = "showFinishedTasksCheckBox";
            this.showFinishedTasksCheckBox.Size = new System.Drawing.Size(97, 15);
            this.showFinishedTasksCheckBox.TabIndex = 3;
            this.showFinishedTasksCheckBox.Text = "Show finished";
            this.showFinishedTasksCheckBox.UseSelectable = true;
            this.showFinishedTasksCheckBox.CheckedChanged += new System.EventHandler(this.showFinishedTasksCheckBox_CheckedChanged);
            // 
            // sortingOptionsPanel
            // 
            this.sortingOptionsPanel.Controls.Add(this.sortingOptionsLabel);
            this.sortingOptionsPanel.Controls.Add(this.sortByGoalRadioButton);
            this.sortingOptionsPanel.Controls.Add(this.sortByDueDateRadioButton);
            this.sortingOptionsPanel.HorizontalScrollbarBarColor = true;
            this.sortingOptionsPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.sortingOptionsPanel.HorizontalScrollbarSize = 10;
            this.sortingOptionsPanel.Location = new System.Drawing.Point(189, 6);
            this.sortingOptionsPanel.Name = "sortingOptionsPanel";
            this.sortingOptionsPanel.Size = new System.Drawing.Size(246, 78);
            this.sortingOptionsPanel.TabIndex = 6;
            this.sortingOptionsPanel.VerticalScrollbarBarColor = true;
            this.sortingOptionsPanel.VerticalScrollbarHighlightOnWheel = false;
            this.sortingOptionsPanel.VerticalScrollbarSize = 10;
            // 
            // sortingOptionsLabel
            // 
            this.sortingOptionsLabel.AutoSize = true;
            this.sortingOptionsLabel.Location = new System.Drawing.Point(3, 8);
            this.sortingOptionsLabel.Name = "sortingOptionsLabel";
            this.sortingOptionsLabel.Size = new System.Drawing.Size(33, 19);
            this.sortingOptionsLabel.TabIndex = 6;
            this.sortingOptionsLabel.Text = "Sort";
            // 
            // sortByGoalRadioButton
            // 
            this.sortByGoalRadioButton.AutoSize = true;
            this.sortByGoalRadioButton.Checked = true;
            this.sortByGoalRadioButton.Location = new System.Drawing.Point(12, 51);
            this.sortByGoalRadioButton.Name = "sortByGoalRadioButton";
            this.sortByGoalRadioButton.Size = new System.Drawing.Size(62, 15);
            this.sortByGoalRadioButton.TabIndex = 5;
            this.sortByGoalRadioButton.TabStop = true;
            this.sortByGoalRadioButton.Text = "By goal";
            this.sortByGoalRadioButton.UseSelectable = true;
            this.sortByGoalRadioButton.CheckedChanged += new System.EventHandler(this.sortingTypeRadioButton_CheckedChanged);
            // 
            // sortByDueDateRadioButton
            // 
            this.sortByDueDateRadioButton.AutoSize = true;
            this.sortByDueDateRadioButton.Location = new System.Drawing.Point(12, 30);
            this.sortByDueDateRadioButton.Name = "sortByDueDateRadioButton";
            this.sortByDueDateRadioButton.Size = new System.Drawing.Size(85, 15);
            this.sortByDueDateRadioButton.TabIndex = 5;
            this.sortByDueDateRadioButton.Text = "By due date";
            this.sortByDueDateRadioButton.UseSelectable = true;
            this.sortByDueDateRadioButton.CheckedChanged += new System.EventHandler(this.sortingTypeRadioButton_CheckedChanged);
            // 
            // newTaskButton
            // 
            this.newTaskButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.newTaskButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.newTaskButton.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.newTaskButton.Location = new System.Drawing.Point(441, 47);
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
            this.tasksPanel.Size = new System.Drawing.Size(581, 435);
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
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.tasksListGrid.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.tasksListGrid.RowTemplate.Height = 30;
            this.tasksListGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tasksListGrid.Size = new System.Drawing.Size(575, 388);
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
            this.displayOptionsPanel.ResumeLayout(false);
            this.displayOptionsPanel.PerformLayout();
            this.sortingOptionsPanel.ResumeLayout(false);
            this.sortingOptionsPanel.PerformLayout();
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
        private MetroPanel displayOptionsPanel;
        private MetroLabel displayOptionsLabel;
        private MetroPanel sortingOptionsPanel;
        private MetroLabel sortingOptionsLabel;
        private MetroRadioButton sortByGoalRadioButton;
        private MetroRadioButton sortByDueDateRadioButton;
    }
}
