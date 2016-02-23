namespace View.Controls
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
            this.selectedDayDateTime = new MetroFramework.Controls.MetroDateTime();
            this.selectDayTextLabel = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.choosenDiaryEntryComboBox = new MetroFramework.Controls.MetroComboBox();
            this.changesButtonsPanel = new MetroFramework.Controls.MetroPanel();
            this.cancelChangesButton = new MetroFramework.Controls.MetroButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.changesButtonsPanel.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dayNumberLabel
            // 
            this.dayNumberLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.dayNumberLabel.Location = new System.Drawing.Point(6, 10);
            this.dayNumberLabel.Name = "dayNumberLabel";
            this.dayNumberLabel.Size = new System.Drawing.Size(241, 28);
            this.dayNumberLabel.TabIndex = 0;
            this.dayNumberLabel.Text = "Day [Number]";
            this.dayNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateLabel
            // 
            this.dateLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.dateLabel.Location = new System.Drawing.Point(186, 10);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(241, 26);
            this.dateLabel.TabIndex = 0;
            this.dateLabel.Text = "[Day date]";
            this.dateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // thoughtsTextBox
            // 
            this.thoughtsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.thoughtsTextBox.CustomButton.Image = null;
            this.thoughtsTextBox.CustomButton.Location = new System.Drawing.Point(325, 2);
            this.thoughtsTextBox.CustomButton.Name = "";
            this.thoughtsTextBox.CustomButton.Size = new System.Drawing.Size(259, 259);
            this.thoughtsTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.thoughtsTextBox.CustomButton.TabIndex = 1;
            this.thoughtsTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.thoughtsTextBox.CustomButton.UseSelectable = true;
            this.thoughtsTextBox.CustomButton.Visible = false;
            this.thoughtsTextBox.Enabled = false;
            this.thoughtsTextBox.Lines = new string[] {
        "[Thoughts]"};
            this.thoughtsTextBox.Location = new System.Drawing.Point(10, 42);
            this.thoughtsTextBox.MaxLength = 32767;
            this.thoughtsTextBox.Multiline = true;
            this.thoughtsTextBox.Name = "thoughtsTextBox";
            this.thoughtsTextBox.PasswordChar = '\0';
            this.thoughtsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.thoughtsTextBox.SelectedText = "";
            this.thoughtsTextBox.SelectionLength = 0;
            this.thoughtsTextBox.SelectionStart = 0;
            this.thoughtsTextBox.Size = new System.Drawing.Size(602, 276);
            this.thoughtsTextBox.TabIndex = 1;
            this.thoughtsTextBox.Text = "[Thoughts]";
            this.thoughtsTextBox.UseSelectable = true;
            this.thoughtsTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.thoughtsTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // saveChangesButton
            // 
            this.saveChangesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveChangesButton.Location = new System.Drawing.Point(89, 29);
            this.saveChangesButton.Name = "saveChangesButton";
            this.saveChangesButton.Size = new System.Drawing.Size(75, 31);
            this.saveChangesButton.TabIndex = 2;
            this.saveChangesButton.Text = "Save";
            this.saveChangesButton.UseSelectable = true;
            this.saveChangesButton.Click += new System.EventHandler(this.saveChangesButton_Click);
            // 
            // editButton
            // 
            this.editButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.editButton.Location = new System.Drawing.Point(89, 29);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 31);
            this.editButton.TabIndex = 2;
            this.editButton.Text = "Edit";
            this.editButton.UseSelectable = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // nextDayButton
            // 
            this.nextDayButton.Location = new System.Drawing.Point(197, 29);
            this.nextDayButton.Name = "nextDayButton";
            this.nextDayButton.Size = new System.Drawing.Size(39, 29);
            this.nextDayButton.TabIndex = 3;
            this.nextDayButton.Text = "->";
            this.nextDayButton.UseSelectable = true;
            this.nextDayButton.Click += new System.EventHandler(this.nextDayButton_Click);
            // 
            // previousDayButton
            // 
            this.previousDayButton.Location = new System.Drawing.Point(4, 29);
            this.previousDayButton.Name = "previousDayButton";
            this.previousDayButton.Size = new System.Drawing.Size(40, 29);
            this.previousDayButton.TabIndex = 3;
            this.previousDayButton.Text = "<-";
            this.previousDayButton.UseSelectable = true;
            this.previousDayButton.Click += new System.EventHandler(this.previousDayButton_Click);
            // 
            // selectedDayDateTime
            // 
            this.selectedDayDateTime.Location = new System.Drawing.Point(50, 29);
            this.selectedDayDateTime.MinimumSize = new System.Drawing.Size(0, 29);
            this.selectedDayDateTime.Name = "selectedDayDateTime";
            this.selectedDayDateTime.Size = new System.Drawing.Size(141, 29);
            this.selectedDayDateTime.TabIndex = 4;
            this.selectedDayDateTime.ValueChanged += new System.EventHandler(this.selectedDayDateTime_ValueChanged);
            // 
            // selectDayTextLabel
            // 
            this.selectDayTextLabel.AutoSize = true;
            this.selectDayTextLabel.Location = new System.Drawing.Point(4, 7);
            this.selectDayTextLabel.Name = "selectDayTextLabel";
            this.selectDayTextLabel.Size = new System.Drawing.Size(73, 19);
            this.selectDayTextLabel.TabIndex = 5;
            this.selectDayTextLabel.Text = "Select date";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(250, 7);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(151, 19);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "or jump to specific entry";
            // 
            // choosenDiaryEntryComboBox
            // 
            this.choosenDiaryEntryComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.choosenDiaryEntryComboBox.DisplayMember = "Value";
            this.choosenDiaryEntryComboBox.FormattingEnabled = true;
            this.choosenDiaryEntryComboBox.ItemHeight = 23;
            this.choosenDiaryEntryComboBox.Location = new System.Drawing.Point(250, 29);
            this.choosenDiaryEntryComboBox.Name = "choosenDiaryEntryComboBox";
            this.choosenDiaryEntryComboBox.Size = new System.Drawing.Size(180, 29);
            this.choosenDiaryEntryComboBox.TabIndex = 6;
            this.choosenDiaryEntryComboBox.UseSelectable = true;
            this.choosenDiaryEntryComboBox.ValueMember = "Key";
            this.choosenDiaryEntryComboBox.SelectedIndexChanged += new System.EventHandler(this.choosenDiaryEntryComboBox_SelectedIndexChanged);
            // 
            // changesButtonsPanel
            // 
            this.changesButtonsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.changesButtonsPanel.Controls.Add(this.editButton);
            this.changesButtonsPanel.Controls.Add(this.cancelChangesButton);
            this.changesButtonsPanel.Controls.Add(this.saveChangesButton);
            this.changesButtonsPanel.HorizontalScrollbarBarColor = true;
            this.changesButtonsPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.changesButtonsPanel.HorizontalScrollbarSize = 10;
            this.changesButtonsPanel.Location = new System.Drawing.Point(448, 324);
            this.changesButtonsPanel.Name = "changesButtonsPanel";
            this.changesButtonsPanel.Size = new System.Drawing.Size(167, 63);
            this.changesButtonsPanel.TabIndex = 7;
            this.changesButtonsPanel.VerticalScrollbarBarColor = true;
            this.changesButtonsPanel.VerticalScrollbarHighlightOnWheel = false;
            this.changesButtonsPanel.VerticalScrollbarSize = 10;
            // 
            // cancelChangesButton
            // 
            this.cancelChangesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelChangesButton.Location = new System.Drawing.Point(8, 29);
            this.cancelChangesButton.Name = "cancelChangesButton";
            this.cancelChangesButton.Size = new System.Drawing.Size(75, 31);
            this.cancelChangesButton.TabIndex = 2;
            this.cancelChangesButton.Text = "Cancel";
            this.cancelChangesButton.UseSelectable = true;
            this.cancelChangesButton.Click += new System.EventHandler(this.cancelChangesButton_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel1.Controls.Add(this.choosenDiaryEntryComboBox);
            this.metroPanel1.Controls.Add(this.previousDayButton);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.nextDayButton);
            this.metroPanel1.Controls.Add(this.selectDayTextLabel);
            this.metroPanel1.Controls.Add(this.selectedDayDateTime);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(10, 324);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(433, 63);
            this.metroPanel1.TabIndex = 8;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // DayControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.changesButtonsPanel);
            this.Controls.Add(this.thoughtsTextBox);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.dayNumberLabel);
            this.Name = "DayControl";
            this.Size = new System.Drawing.Size(618, 390);
            this.changesButtonsPanel.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
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
        private MetroFramework.Controls.MetroDateTime selectedDayDateTime;
        private MetroFramework.Controls.MetroLabel selectDayTextLabel;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox choosenDiaryEntryComboBox;
        private MetroFramework.Controls.MetroPanel changesButtonsPanel;
        private MetroFramework.Controls.MetroButton cancelChangesButton;
        private MetroFramework.Controls.MetroPanel metroPanel1;
    }
}
