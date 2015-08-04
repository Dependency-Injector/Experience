using System.ComponentModel;
using System.Windows.Forms;
using MetroFramework.Controls;

namespace PresentationLayer.Controls
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timePeriodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.activitiesTrackingTab = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.whatAreYouDoingLabel = new System.Windows.Forms.Label();
            this.activitiesListBox = new System.Windows.Forms.ListBox();
            this.newActivityTextBox = new System.Windows.Forms.TextBox();
            this.addActivityButton = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.activityHistoryGridView = new System.Windows.Forms.DataGridView();
            this.timeReportingPanel = new System.Windows.Forms.Panel();
            this.reportTimeLabel = new System.Windows.Forms.Label();
            this.startTimeLabel = new System.Windows.Forms.Label();
            this.startActivityButton = new System.Windows.Forms.Button();
            this.timeLeftValueLabel = new System.Windows.Forms.Label();
            this.resetActivityButton = new System.Windows.Forms.Button();
            this.saveActivityButton = new System.Windows.Forms.Button();
            this.pauseActivityButton = new System.Windows.Forms.Button();
            this.stopActivityButton = new System.Windows.Forms.Button();
            this.endTimeValueLabel = new System.Windows.Forms.Label();
            this.timeLeftLabel = new System.Windows.Forms.Label();
            this.startTimeValueLabel = new System.Windows.Forms.Label();
            this.endTimeLabel = new System.Windows.Forms.Label();
            this.tasksTab = new System.Windows.Forms.TabPage();
            this.tasksPanel = new PresentationLayer.Controls.TaskEditorEditor();
            this.menuTabControl = new MetroFramework.Controls.MetroTabControl();
            this.activitiesReportingTab = new MetroFramework.Controls.MetroTabPage();
            this.activitiesReportingPanel = new PresentationLayer.Controls.ActivitiesPanel();
            this.activitiesPanel1 = new PresentationLayer.Controls.ActivitiesPanel();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            ((System.ComponentModel.ISupportInitialize)(this.timePeriodBindingSource)).BeginInit();
            this.activitiesTrackingTab.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activityHistoryGridView)).BeginInit();
            this.timeReportingPanel.SuspendLayout();
            this.tasksTab.SuspendLayout();
            this.menuTabControl.SuspendLayout();
            this.activitiesReportingTab.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // activitiesTrackingTab
            // 
            this.activitiesTrackingTab.Controls.Add(this.panel3);
            this.activitiesTrackingTab.Controls.Add(this.panel6);
            this.activitiesTrackingTab.Controls.Add(this.panel5);
            this.activitiesTrackingTab.Controls.Add(this.timeReportingPanel);
            this.activitiesTrackingTab.Location = new System.Drawing.Point(4, 38);
            this.activitiesTrackingTab.Name = "activitiesTrackingTab";
            this.activitiesTrackingTab.Padding = new System.Windows.Forms.Padding(3);
            this.activitiesTrackingTab.Size = new System.Drawing.Size(871, 570);
            this.activitiesTrackingTab.TabIndex = 0;
            this.activitiesTrackingTab.Text = "Aktywności";
            this.activitiesTrackingTab.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.whatAreYouDoingLabel);
            this.panel3.Controls.Add(this.activitiesListBox);
            this.panel3.Controls.Add(this.newActivityTextBox);
            this.panel3.Controls.Add(this.addActivityButton);
            this.panel3.Location = new System.Drawing.Point(32, 22);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(223, 385);
            this.panel3.TabIndex = 13;
            // 
            // whatAreYouDoingLabel
            // 
            this.whatAreYouDoingLabel.AutoSize = true;
            this.whatAreYouDoingLabel.Location = new System.Drawing.Point(16, 16);
            this.whatAreYouDoingLabel.Name = "whatAreYouDoingLabel";
            this.whatAreYouDoingLabel.Size = new System.Drawing.Size(94, 13);
            this.whatAreYouDoingLabel.TabIndex = 0;
            this.whatAreYouDoingLabel.Text = "Co będziesz robił?";
            // 
            // activitiesListBox
            // 
            this.activitiesListBox.FormattingEnabled = true;
            this.activitiesListBox.Location = new System.Drawing.Point(16, 41);
            this.activitiesListBox.Name = "activitiesListBox";
            this.activitiesListBox.Size = new System.Drawing.Size(190, 186);
            this.activitiesListBox.TabIndex = 1;
            this.activitiesListBox.SelectedIndexChanged += new System.EventHandler(this.activitiesListBox_SelectedIndexChanged);
            // 
            // newActivityTextBox
            // 
            this.newActivityTextBox.Location = new System.Drawing.Point(16, 237);
            this.newActivityTextBox.Name = "newActivityTextBox";
            this.newActivityTextBox.Size = new System.Drawing.Size(112, 20);
            this.newActivityTextBox.TabIndex = 2;
            this.newActivityTextBox.Text = "Nie ma na liście?";
            // 
            // addActivityButton
            // 
            this.addActivityButton.Location = new System.Drawing.Point(131, 233);
            this.addActivityButton.Name = "addActivityButton";
            this.addActivityButton.Size = new System.Drawing.Size(75, 27);
            this.addActivityButton.TabIndex = 3;
            this.addActivityButton.Text = "Dodaj";
            this.addActivityButton.UseVisualStyleBackColor = true;
            this.addActivityButton.Click += new System.EventHandler(this.addActivityButton_Click);
            // 
            // panel6
            // 
            this.panel6.Location = new System.Drawing.Point(262, 22);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(235, 71);
            this.panel6.TabIndex = 16;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.activityHistoryGridView);
            this.panel5.Location = new System.Drawing.Point(512, 22);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(353, 385);
            this.panel5.TabIndex = 15;
            // 
            // activityHistoryGridView
            // 
            this.activityHistoryGridView.AutoGenerateColumns = false;
            this.activityHistoryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.activityHistoryGridView.DataSource = this.timePeriodBindingSource;
            this.activityHistoryGridView.Location = new System.Drawing.Point(14, 16);
            this.activityHistoryGridView.Name = "activityHistoryGridView";
            this.activityHistoryGridView.Size = new System.Drawing.Size(329, 244);
            this.activityHistoryGridView.TabIndex = 0;
            // 
            // timeReportingPanel
            // 
            this.timeReportingPanel.Controls.Add(this.reportTimeLabel);
            this.timeReportingPanel.Controls.Add(this.startTimeLabel);
            this.timeReportingPanel.Controls.Add(this.startActivityButton);
            this.timeReportingPanel.Controls.Add(this.timeLeftValueLabel);
            this.timeReportingPanel.Controls.Add(this.resetActivityButton);
            this.timeReportingPanel.Controls.Add(this.saveActivityButton);
            this.timeReportingPanel.Controls.Add(this.pauseActivityButton);
            this.timeReportingPanel.Controls.Add(this.stopActivityButton);
            this.timeReportingPanel.Controls.Add(this.endTimeValueLabel);
            this.timeReportingPanel.Controls.Add(this.timeLeftLabel);
            this.timeReportingPanel.Controls.Add(this.startTimeValueLabel);
            this.timeReportingPanel.Controls.Add(this.endTimeLabel);
            this.timeReportingPanel.Location = new System.Drawing.Point(261, 99);
            this.timeReportingPanel.Name = "timeReportingPanel";
            this.timeReportingPanel.Size = new System.Drawing.Size(236, 308);
            this.timeReportingPanel.TabIndex = 14;
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
            // startActivityButton
            // 
            this.startActivityButton.Location = new System.Drawing.Point(162, 127);
            this.startActivityButton.Name = "startActivityButton";
            this.startActivityButton.Size = new System.Drawing.Size(67, 23);
            this.startActivityButton.TabIndex = 8;
            this.startActivityButton.Text = "Start";
            this.startActivityButton.UseVisualStyleBackColor = true;
            this.startActivityButton.Click += new System.EventHandler(this.startActivityButton_Click);
            // 
            // timeLeftValueLabel
            // 
            this.timeLeftValueLabel.AutoSize = true;
            this.timeLeftValueLabel.Location = new System.Drawing.Point(159, 98);
            this.timeLeftValueLabel.Name = "timeLeftValueLabel";
            this.timeLeftValueLabel.Size = new System.Drawing.Size(22, 13);
            this.timeLeftValueLabel.TabIndex = 12;
            this.timeLeftValueLabel.Text = "--:--";
            // 
            // resetActivityButton
            // 
            this.resetActivityButton.Location = new System.Drawing.Point(91, 158);
            this.resetActivityButton.Name = "resetActivityButton";
            this.resetActivityButton.Size = new System.Drawing.Size(67, 23);
            this.resetActivityButton.TabIndex = 10;
            this.resetActivityButton.Text = "Zapisz";
            this.resetActivityButton.UseVisualStyleBackColor = true;
            this.resetActivityButton.Click += new System.EventHandler(this.saveActivityButton_Click);
            // 
            // saveActivityButton
            // 
            this.saveActivityButton.Location = new System.Drawing.Point(162, 158);
            this.saveActivityButton.Name = "saveActivityButton";
            this.saveActivityButton.Size = new System.Drawing.Size(67, 23);
            this.saveActivityButton.TabIndex = 10;
            this.saveActivityButton.Text = "Zapisz";
            this.saveActivityButton.UseVisualStyleBackColor = true;
            this.saveActivityButton.Click += new System.EventHandler(this.saveActivityButton_Click);
            // 
            // pauseActivityButton
            // 
            this.pauseActivityButton.Location = new System.Drawing.Point(91, 127);
            this.pauseActivityButton.Name = "pauseActivityButton";
            this.pauseActivityButton.Size = new System.Drawing.Size(67, 23);
            this.pauseActivityButton.TabIndex = 9;
            this.pauseActivityButton.Text = "Pauza";
            this.pauseActivityButton.UseVisualStyleBackColor = true;
            this.pauseActivityButton.Click += new System.EventHandler(this.stopActivityButton_Click);
            // 
            // stopActivityButton
            // 
            this.stopActivityButton.Location = new System.Drawing.Point(20, 127);
            this.stopActivityButton.Name = "stopActivityButton";
            this.stopActivityButton.Size = new System.Drawing.Size(67, 23);
            this.stopActivityButton.TabIndex = 9;
            this.stopActivityButton.Text = "Stop";
            this.stopActivityButton.UseVisualStyleBackColor = true;
            this.stopActivityButton.Click += new System.EventHandler(this.stopActivityButton_Click);
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
            // tasksTab
            // 
            this.tasksTab.Controls.Add(this.tasksPanel);
            this.tasksTab.Location = new System.Drawing.Point(4, 38);
            this.tasksTab.Name = "tasksTab";
            this.tasksTab.Size = new System.Drawing.Size(871, 570);
            this.tasksTab.TabIndex = 2;
            this.tasksTab.Text = "Zadania";
            this.tasksTab.UseVisualStyleBackColor = true;
            this.tasksTab.Click += new System.EventHandler(this.tasksTab_Click);
            // 
            // tasksPanel
            // 
            this.tasksPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tasksPanel.DueDate = new System.DateTime(2015, 7, 23, 11, 14, 34, 669);
            this.tasksPanel.FinishDate = null;
            this.tasksPanel.IsDirty = false;
            this.tasksPanel.IsFinished = false;
            this.tasksPanel.Location = new System.Drawing.Point(0, 0);
            this.tasksPanel.Name = "tasksPanel";
            this.tasksPanel.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.tasksPanel.Priority = 0;
            this.tasksPanel.Size = new System.Drawing.Size(871, 570);
            this.tasksPanel.StartDate = new System.DateTime(2015, 7, 23, 11, 14, 34, 671);
            this.tasksPanel.TabIndex = 4;
            this.tasksPanel.TaskName = "nameTextBox";
            this.tasksPanel.UseSelectable = true;
            this.tasksPanel.UseStyleColors = true;
            // 
            // menuTabControl
            // 
            this.menuTabControl.Controls.Add(this.tasksTab);
            this.menuTabControl.Controls.Add(this.activitiesReportingTab);
            this.menuTabControl.Controls.Add(this.activitiesTrackingTab);
            this.menuTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuTabControl.Location = new System.Drawing.Point(20, 60);
            this.menuTabControl.Name = "menuTabControl";
            this.menuTabControl.SelectedIndex = 0;
            this.menuTabControl.Size = new System.Drawing.Size(879, 612);
            this.menuTabControl.TabIndex = 3;
            this.menuTabControl.UseSelectable = true;
            // 
            // activitiesReportingTab
            // 
            this.activitiesReportingTab.Controls.Add(this.activitiesReportingPanel);
            this.activitiesReportingTab.HorizontalScrollbarBarColor = true;
            this.activitiesReportingTab.HorizontalScrollbarHighlightOnWheel = false;
            this.activitiesReportingTab.HorizontalScrollbarSize = 10;
            this.activitiesReportingTab.Location = new System.Drawing.Point(4, 38);
            this.activitiesReportingTab.Name = "activitiesReportingTab";
            this.activitiesReportingTab.Size = new System.Drawing.Size(871, 570);
            this.activitiesReportingTab.TabIndex = 3;
            this.activitiesReportingTab.Text = "Raportowanie aktywności";
            this.activitiesReportingTab.VerticalScrollbarBarColor = true;
            this.activitiesReportingTab.VerticalScrollbarHighlightOnWheel = false;
            this.activitiesReportingTab.VerticalScrollbarSize = 10;
            // 
            // activitiesReportingPanel
            // 
            this.activitiesReportingPanel.ActivityName = "Nowa...";
            this.activitiesReportingPanel.IsDirty = false;
            this.activitiesReportingPanel.Location = new System.Drawing.Point(0, 20);
            this.activitiesReportingPanel.Name = "activitiesReportingPanel";
            this.activitiesReportingPanel.Size = new System.Drawing.Size(853, 303);
            this.activitiesReportingPanel.TabIndex = 2;
            this.activitiesReportingPanel.UseSelectable = true;
            // 
            // activitiesPanel1
            // 
            this.activitiesPanel1.ActivityName = "Nowa...";
            this.activitiesPanel1.IsDirty = false;
            this.activitiesPanel1.Location = new System.Drawing.Point(-4, 21);
            this.activitiesPanel1.Name = "activitiesPanel1";
            this.activitiesPanel1.Size = new System.Drawing.Size(853, 303);
            this.activitiesPanel1.TabIndex = 4;
            this.activitiesPanel1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.activitiesPanel1);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(871, 413);
            this.metroTabPage1.TabIndex = 3;
            this.metroTabPage1.Text = "Raportowanie aktywności";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 692);
            this.Controls.Add(this.menuTabControl);
            this.Name = "MainForm";
            this.Text = "OGARNIĘTOŚĆ TO DOSKONAŁOŚĆ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.timePeriodBindingSource)).EndInit();
            this.activitiesTrackingTab.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.activityHistoryGridView)).EndInit();
            this.timeReportingPanel.ResumeLayout(false);
            this.timeReportingPanel.PerformLayout();
            this.tasksTab.ResumeLayout(false);
            this.menuTabControl.ResumeLayout(false);
            this.activitiesReportingTab.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn startDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn stopDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn intervalDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn activityDataGridViewTextBoxColumn;
        private BindingSource timePeriodBindingSource;
        private TabPage activitiesTrackingTab;
        private Panel panel3;
        private Label whatAreYouDoingLabel;
        private ListBox activitiesListBox;
        private TextBox newActivityTextBox;
        private Button addActivityButton;
        private Panel panel6;
        private Panel panel5;
        private DataGridView activityHistoryGridView;
        private Panel timeReportingPanel;
        private Label reportTimeLabel;
        private Label startTimeLabel;
        private Button startActivityButton;
        private Label timeLeftValueLabel;
        private Button resetActivityButton;
        private Button saveActivityButton;
        private Button pauseActivityButton;
        private Button stopActivityButton;
        private Label endTimeValueLabel;
        private Label timeLeftLabel;
        private Label startTimeValueLabel;
        private Label endTimeLabel;
        private TabPage tasksTab;
        private MetroTabControl menuTabControl;
        private TaskEditorEditor tasksPanel;
        private MetroTabPage activitiesReportingTab;
        private ActivitiesPanel activitiesPanel1;
        private ActivitiesPanel activitiesReportingPanel;
        private MetroTabPage metroTabPage1;
    }
}

