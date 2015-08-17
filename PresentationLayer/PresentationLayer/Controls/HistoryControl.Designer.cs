namespace PresentationLayer.Controls
{
    partial class HistoryControl
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
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.eventDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventTypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventTypeDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tasksEventsCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.experienceEventsCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.workUnitsEventsCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.displayInfoAboutTextLabel = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eventDateColumn,
            this.eventTypeColumn,
            this.eventTypeDescription});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(3, 109);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(622, 285);
            this.metroGrid1.TabIndex = 0;
            // 
            // eventDateColumn
            // 
            this.eventDateColumn.HeaderText = "When";
            this.eventDateColumn.Name = "eventDateColumn";
            // 
            // eventTypeColumn
            // 
            this.eventTypeColumn.HeaderText = "What";
            this.eventTypeColumn.Name = "eventTypeColumn";
            // 
            // eventTypeDescription
            // 
            this.eventTypeDescription.HeaderText = "Description";
            this.eventTypeDescription.Name = "eventTypeDescription";
            // 
            // tasksEventsCheckBox
            // 
            this.tasksEventsCheckBox.AutoSize = true;
            this.tasksEventsCheckBox.Checked = true;
            this.tasksEventsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tasksEventsCheckBox.Location = new System.Drawing.Point(3, 29);
            this.tasksEventsCheckBox.Name = "tasksEventsCheckBox";
            this.tasksEventsCheckBox.Size = new System.Drawing.Size(52, 15);
            this.tasksEventsCheckBox.TabIndex = 1;
            this.tasksEventsCheckBox.Text = "Tasks";
            this.tasksEventsCheckBox.UseSelectable = true;
            this.tasksEventsCheckBox.CheckedChanged += new System.EventHandler(this.tasksEventsCheckBox_CheckedChanged);
            // 
            // experienceEventsCheckBox
            // 
            this.experienceEventsCheckBox.AutoSize = true;
            this.experienceEventsCheckBox.Checked = true;
            this.experienceEventsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.experienceEventsCheckBox.Location = new System.Drawing.Point(3, 50);
            this.experienceEventsCheckBox.Name = "experienceEventsCheckBox";
            this.experienceEventsCheckBox.Size = new System.Drawing.Size(79, 15);
            this.experienceEventsCheckBox.TabIndex = 1;
            this.experienceEventsCheckBox.Text = "Experience";
            this.experienceEventsCheckBox.UseSelectable = true;
            this.experienceEventsCheckBox.CheckedChanged += new System.EventHandler(this.experienceEventsCheckBox_CheckedChanged);
            // 
            // workUnitsEventsCheckBox
            // 
            this.workUnitsEventsCheckBox.AutoSize = true;
            this.workUnitsEventsCheckBox.Checked = true;
            this.workUnitsEventsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.workUnitsEventsCheckBox.Location = new System.Drawing.Point(3, 71);
            this.workUnitsEventsCheckBox.Name = "workUnitsEventsCheckBox";
            this.workUnitsEventsCheckBox.Size = new System.Drawing.Size(80, 15);
            this.workUnitsEventsCheckBox.TabIndex = 1;
            this.workUnitsEventsCheckBox.Text = "Work units";
            this.workUnitsEventsCheckBox.UseSelectable = true;
            this.workUnitsEventsCheckBox.CheckedChanged += new System.EventHandler(this.metroCheckBox2_CheckedChanged);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.displayInfoAboutTextLabel);
            this.metroPanel1.Controls.Add(this.experienceEventsCheckBox);
            this.metroPanel1.Controls.Add(this.workUnitsEventsCheckBox);
            this.metroPanel1.Controls.Add(this.tasksEventsCheckBox);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(3, 3);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(270, 100);
            this.metroPanel1.TabIndex = 2;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // displayInfoAboutTextLabel
            // 
            this.displayInfoAboutTextLabel.AutoSize = true;
            this.displayInfoAboutTextLabel.Location = new System.Drawing.Point(3, 7);
            this.displayInfoAboutTextLabel.Name = "displayInfoAboutTextLabel";
            this.displayInfoAboutTextLabel.Size = new System.Drawing.Size(151, 19);
            this.displayInfoAboutTextLabel.TabIndex = 2;
            this.displayInfoAboutTextLabel.Text = "Display events related to";
            // 
            // HistoryControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.metroGrid1);
            this.Name = "HistoryControl";
            this.Size = new System.Drawing.Size(628, 397);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid metroGrid1;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventTypeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventTypeDescription;
        private MetroFramework.Controls.MetroCheckBox tasksEventsCheckBox;
        private MetroFramework.Controls.MetroCheckBox experienceEventsCheckBox;
        private MetroFramework.Controls.MetroCheckBox workUnitsEventsCheckBox;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel displayInfoAboutTextLabel;
    }
}
