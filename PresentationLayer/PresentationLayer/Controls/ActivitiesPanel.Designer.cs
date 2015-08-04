using System.ComponentModel;
using System.Windows.Forms;

namespace PresentationLayer.Controls
{
    partial class ActivitiesPanel
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
            this.activitiesListPanel = new System.Windows.Forms.Panel();
            this.activitiesListLabel = new System.Windows.Forms.Label();
            this.activitiesListBox = new System.Windows.Forms.ListBox();
            this.newActivityTitleTextBox = new System.Windows.Forms.TextBox();
            this.addNewActivityButton = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.stopActivityButton = new System.Windows.Forms.Button();
            this.startActivityButton = new System.Windows.Forms.Button();
            this.pauseActivityButton = new System.Windows.Forms.Button();
            this.resetActivityButton = new System.Windows.Forms.Button();
            this.saveActivityButton = new System.Windows.Forms.Button();
            this.activitiesHistoryPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.activityHistoryGridView = new System.Windows.Forms.DataGridView();
            this.timeReportingPanel = new System.Windows.Forms.Panel();
            this.reportTimeLabel = new System.Windows.Forms.Label();
            this.startTimeLabel = new System.Windows.Forms.Label();
            this.elapsedTimeLabel = new System.Windows.Forms.Label();
            this.endTimeValueLabel = new System.Windows.Forms.Label();
            this.timeLeftLabel = new System.Windows.Forms.Label();
            this.startTimeValueLabel = new System.Windows.Forms.Label();
            this.endTimeLabel = new System.Windows.Forms.Label();
            this.activitiesListPanel.SuspendLayout();
            this.panel6.SuspendLayout();
            this.activitiesHistoryPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activityHistoryGridView)).BeginInit();
            this.timeReportingPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // activitiesListPanel
            // 
            this.activitiesListPanel.Controls.Add(this.activitiesListLabel);
            this.activitiesListPanel.Controls.Add(this.activitiesListBox);
            this.activitiesListPanel.Controls.Add(this.newActivityTitleTextBox);
            this.activitiesListPanel.Controls.Add(this.addNewActivityButton);
            this.activitiesListPanel.Location = new System.Drawing.Point(11, 16);
            this.activitiesListPanel.Name = "activitiesListPanel";
            this.activitiesListPanel.Size = new System.Drawing.Size(223, 273);
            this.activitiesListPanel.TabIndex = 17;
            // 
            // activitiesListLabel
            // 
            this.activitiesListLabel.AutoSize = true;
            this.activitiesListLabel.Location = new System.Drawing.Point(16, 16);
            this.activitiesListLabel.Name = "activitiesListLabel";
            this.activitiesListLabel.Size = new System.Drawing.Size(85, 13);
            this.activitiesListLabel.TabIndex = 0;
            this.activitiesListLabel.Text = "Lista aktywności";
            // 
            // activitiesListBox
            // 
            this.activitiesListBox.FormattingEnabled = true;
            this.activitiesListBox.Location = new System.Drawing.Point(16, 41);
            this.activitiesListBox.Name = "activitiesListBox";
            this.activitiesListBox.Size = new System.Drawing.Size(190, 186);
            this.activitiesListBox.TabIndex = 1;
            // 
            // newActivityTitleTextBox
            // 
            this.newActivityTitleTextBox.Location = new System.Drawing.Point(16, 237);
            this.newActivityTitleTextBox.Name = "newActivityTitleTextBox";
            this.newActivityTitleTextBox.Size = new System.Drawing.Size(112, 20);
            this.newActivityTitleTextBox.TabIndex = 2;
            this.newActivityTitleTextBox.Text = "Nowa...";
            // 
            // addNewActivityButton
            // 
            this.addNewActivityButton.Location = new System.Drawing.Point(131, 233);
            this.addNewActivityButton.Name = "addNewActivityButton";
            this.addNewActivityButton.Size = new System.Drawing.Size(75, 27);
            this.addNewActivityButton.TabIndex = 3;
            this.addNewActivityButton.Text = "Dodaj";
            this.addNewActivityButton.UseVisualStyleBackColor = true;
            this.addNewActivityButton.Click += new System.EventHandler(this.addNewActivity_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.stopActivityButton);
            this.panel6.Controls.Add(this.startActivityButton);
            this.panel6.Controls.Add(this.pauseActivityButton);
            this.panel6.Controls.Add(this.resetActivityButton);
            this.panel6.Controls.Add(this.saveActivityButton);
            this.panel6.Location = new System.Drawing.Point(241, 16);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(262, 106);
            this.panel6.TabIndex = 20;
            // 
            // stopActivityButton
            // 
            this.stopActivityButton.Location = new System.Drawing.Point(19, 41);
            this.stopActivityButton.Name = "stopActivityButton";
            this.stopActivityButton.Size = new System.Drawing.Size(88, 23);
            this.stopActivityButton.TabIndex = 9;
            this.stopActivityButton.Text = "Skończyłem";
            this.stopActivityButton.UseVisualStyleBackColor = true;
            this.stopActivityButton.Click += new System.EventHandler(this.stopActivityButton_Click);
            // 
            // startActivityButton
            // 
            this.startActivityButton.Location = new System.Drawing.Point(19, 12);
            this.startActivityButton.Name = "startActivityButton";
            this.startActivityButton.Size = new System.Drawing.Size(88, 23);
            this.startActivityButton.TabIndex = 8;
            this.startActivityButton.Text = "Zaczynam";
            this.startActivityButton.UseVisualStyleBackColor = true;
            this.startActivityButton.Click += new System.EventHandler(this.startActivityButton_Click);
            // 
            // pauseActivityButton
            // 
            this.pauseActivityButton.Location = new System.Drawing.Point(19, 70);
            this.pauseActivityButton.Name = "pauseActivityButton";
            this.pauseActivityButton.Size = new System.Drawing.Size(88, 23);
            this.pauseActivityButton.TabIndex = 9;
            this.pauseActivityButton.Text = "Przerwa";
            this.pauseActivityButton.UseVisualStyleBackColor = true;
            this.pauseActivityButton.Click += new System.EventHandler(this.pauseActivityButton_Click);
            // 
            // resetActivityButton
            // 
            this.resetActivityButton.Location = new System.Drawing.Point(140, 41);
            this.resetActivityButton.Name = "resetActivityButton";
            this.resetActivityButton.Size = new System.Drawing.Size(88, 23);
            this.resetActivityButton.TabIndex = 10;
            this.resetActivityButton.Text = "Odrzuć / Reset";
            this.resetActivityButton.UseVisualStyleBackColor = true;
            this.resetActivityButton.Click += new System.EventHandler(this.resetActivityButton_Click);
            // 
            // saveActivityButton
            // 
            this.saveActivityButton.Location = new System.Drawing.Point(140, 11);
            this.saveActivityButton.Name = "saveActivityButton";
            this.saveActivityButton.Size = new System.Drawing.Size(88, 23);
            this.saveActivityButton.TabIndex = 10;
            this.saveActivityButton.Text = "Zaraportuj";
            this.saveActivityButton.UseVisualStyleBackColor = true;
            this.saveActivityButton.Click += new System.EventHandler(this.saveActivityButton_Click);
            // 
            // activitiesHistoryPanel
            // 
            this.activitiesHistoryPanel.Controls.Add(this.label1);
            this.activitiesHistoryPanel.Controls.Add(this.activityHistoryGridView);
            this.activitiesHistoryPanel.Location = new System.Drawing.Point(509, 16);
            this.activitiesHistoryPanel.Name = "activitiesHistoryPanel";
            this.activitiesHistoryPanel.Size = new System.Drawing.Size(335, 273);
            this.activitiesHistoryPanel.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ostatnio zaraportowane";
            // 
            // activityHistoryGridView
            // 
            this.activityHistoryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.activityHistoryGridView.Location = new System.Drawing.Point(13, 41);
            this.activityHistoryGridView.Name = "activityHistoryGridView";
            this.activityHistoryGridView.Size = new System.Drawing.Size(312, 219);
            this.activityHistoryGridView.TabIndex = 0;
            // 
            // timeReportingPanel
            // 
            this.timeReportingPanel.Controls.Add(this.reportTimeLabel);
            this.timeReportingPanel.Controls.Add(this.startTimeLabel);
            this.timeReportingPanel.Controls.Add(this.elapsedTimeLabel);
            this.timeReportingPanel.Controls.Add(this.endTimeValueLabel);
            this.timeReportingPanel.Controls.Add(this.timeLeftLabel);
            this.timeReportingPanel.Controls.Add(this.startTimeValueLabel);
            this.timeReportingPanel.Controls.Add(this.endTimeLabel);
            this.timeReportingPanel.Location = new System.Drawing.Point(240, 128);
            this.timeReportingPanel.Name = "timeReportingPanel";
            this.timeReportingPanel.Size = new System.Drawing.Size(263, 161);
            this.timeReportingPanel.TabIndex = 18;
            // 
            // reportTimeLabel
            // 
            this.reportTimeLabel.AutoSize = true;
            this.reportTimeLabel.Location = new System.Drawing.Point(17, 19);
            this.reportTimeLabel.Name = "reportTimeLabel";
            this.reportTimeLabel.Size = new System.Drawing.Size(47, 13);
            this.reportTimeLabel.TabIndex = 13;
            this.reportTimeLabel.Text = "Raportuj";
            // 
            // startTimeLabel
            // 
            this.startTimeLabel.AutoSize = true;
            this.startTimeLabel.Location = new System.Drawing.Point(17, 48);
            this.startTimeLabel.Name = "startTimeLabel";
            this.startTimeLabel.Size = new System.Drawing.Size(93, 13);
            this.startTimeLabel.TabIndex = 12;
            this.startTimeLabel.Text = "Czas rozpoczęcia:";
            // 
            // elapsedTimeLabel
            // 
            this.elapsedTimeLabel.AutoSize = true;
            this.elapsedTimeLabel.Location = new System.Drawing.Point(159, 98);
            this.elapsedTimeLabel.Name = "elapsedTimeLabel";
            this.elapsedTimeLabel.Size = new System.Drawing.Size(22, 13);
            this.elapsedTimeLabel.TabIndex = 12;
            this.elapsedTimeLabel.Text = "--:--";
            // 
            // endTimeValueLabel
            // 
            this.endTimeValueLabel.AutoSize = true;
            this.endTimeValueLabel.Location = new System.Drawing.Point(159, 73);
            this.endTimeValueLabel.Name = "endTimeValueLabel";
            this.endTimeValueLabel.Size = new System.Drawing.Size(22, 13);
            this.endTimeValueLabel.TabIndex = 12;
            this.endTimeValueLabel.Text = "--:--";
            // 
            // timeLeftLabel
            // 
            this.timeLeftLabel.AutoSize = true;
            this.timeLeftLabel.Location = new System.Drawing.Point(17, 98);
            this.timeLeftLabel.Name = "timeLeftLabel";
            this.timeLeftLabel.Size = new System.Drawing.Size(55, 13);
            this.timeLeftLabel.TabIndex = 12;
            this.timeLeftLabel.Text = "Upłynęło:";
            // 
            // startTimeValueLabel
            // 
            this.startTimeValueLabel.AutoSize = true;
            this.startTimeValueLabel.Location = new System.Drawing.Point(159, 48);
            this.startTimeValueLabel.Name = "startTimeValueLabel";
            this.startTimeValueLabel.Size = new System.Drawing.Size(22, 13);
            this.startTimeValueLabel.TabIndex = 12;
            this.startTimeValueLabel.Text = "--:--";
            // 
            // endTimeLabel
            // 
            this.endTimeLabel.AutoSize = true;
            this.endTimeLabel.Location = new System.Drawing.Point(17, 73);
            this.endTimeLabel.Name = "endTimeLabel";
            this.endTimeLabel.Size = new System.Drawing.Size(96, 13);
            this.endTimeLabel.TabIndex = 12;
            this.endTimeLabel.Text = "Czas zakończenia:";
            // 
            // ActivitiesPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.activitiesListPanel);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.activitiesHistoryPanel);
            this.Controls.Add(this.timeReportingPanel);
            this.Name = "ActivitiesPanel";
            this.Size = new System.Drawing.Size(853, 303);
            this.Load += new System.EventHandler(this.ActivitiesPanel_Load);
            this.activitiesListPanel.ResumeLayout(false);
            this.activitiesListPanel.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.activitiesHistoryPanel.ResumeLayout(false);
            this.activitiesHistoryPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activityHistoryGridView)).EndInit();
            this.timeReportingPanel.ResumeLayout(false);
            this.timeReportingPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel activitiesListPanel;
        private Label activitiesListLabel;
        private ListBox activitiesListBox;
        private TextBox newActivityTitleTextBox;
        private Button addNewActivityButton;
        private Panel panel6;
        private Panel activitiesHistoryPanel;
        private DataGridView activityHistoryGridView;
        private Panel timeReportingPanel;
        private Label reportTimeLabel;
        private Label startTimeLabel;
        private Button startActivityButton;
        private Label elapsedTimeLabel;
        private Button resetActivityButton;
        private Button saveActivityButton;
        private Button pauseActivityButton;
        private Button stopActivityButton;
        private Label endTimeValueLabel;
        private Label timeLeftLabel;
        private Label startTimeValueLabel;
        private Label endTimeLabel;
        private Label label1;

    }
}
