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
            this.tasksTab = new System.Windows.Forms.TabPage();
            this.menuTabControl = new MetroFramework.Controls.MetroTabControl();
            this.activitiesReportingTab = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.tasks2Tab = new MetroFramework.Controls.MetroTabPage();
            this.tasksPanel = new PresentationLayer.Controls.TaskEditorEditor();
            this.tasksControll = new PresentationLayer.Controls.Panels.TasksControl();
            this.activitiesPanel1 = new PresentationLayer.Controls.ActivitiesPanel();
            this.tasksControl1 = new PresentationLayer.Controls.Panels.TasksControl();
            ((System.ComponentModel.ISupportInitialize)(this.timePeriodBindingSource)).BeginInit();
            this.tasksTab.SuspendLayout();
            this.menuTabControl.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.tasks2Tab.SuspendLayout();
            this.SuspendLayout();
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
            // menuTabControl
            // 
            this.menuTabControl.Controls.Add(this.tasksTab);
            this.menuTabControl.Controls.Add(this.activitiesReportingTab);
            this.menuTabControl.Controls.Add(this.tasks2Tab);
            this.menuTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuTabControl.Location = new System.Drawing.Point(20, 60);
            this.menuTabControl.Name = "menuTabControl";
            this.menuTabControl.SelectedIndex = 2;
            this.menuTabControl.Size = new System.Drawing.Size(879, 612);
            this.menuTabControl.TabIndex = 3;
            this.menuTabControl.UseSelectable = true;
            // 
            // activitiesReportingTab
            // 
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
            // tasks2Tab
            // 
            this.tasks2Tab.Controls.Add(this.tasksControll);
            this.tasks2Tab.HorizontalScrollbarBarColor = true;
            this.tasks2Tab.HorizontalScrollbarHighlightOnWheel = false;
            this.tasks2Tab.HorizontalScrollbarSize = 10;
            this.tasks2Tab.Location = new System.Drawing.Point(4, 38);
            this.tasks2Tab.Name = "tasks2Tab";
            this.tasks2Tab.Size = new System.Drawing.Size(871, 570);
            this.tasks2Tab.TabIndex = 4;
            this.tasks2Tab.Text = "metroTabPage2";
            this.tasks2Tab.VerticalScrollbarBarColor = true;
            this.tasks2Tab.VerticalScrollbarHighlightOnWheel = false;
            this.tasks2Tab.VerticalScrollbarSize = 10;
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
            // tasksControll
            // 
            this.tasksControll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tasksControll.IsDirty = false;
            this.tasksControll.Location = new System.Drawing.Point(0, 0);
            this.tasksControll.Name = "tasksControll";
            this.tasksControll.Size = new System.Drawing.Size(871, 570);
            this.tasksControll.Status = null;
            this.tasksControll.TabIndex = 2;
            this.tasksControll.Tasks = null;
            this.tasksControll.UseSelectable = true;
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
            // tasksControl1
            // 
            this.tasksControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tasksControl1.IsDirty = false;
            this.tasksControl1.Location = new System.Drawing.Point(0, 0);
            this.tasksControl1.Name = "tasksControl1";
            this.tasksControl1.Size = new System.Drawing.Size(871, 570);
            this.tasksControl1.Status = null;
            this.tasksControl1.TabIndex = 2;
            this.tasksControl1.Tasks = null;
            this.tasksControl1.UseSelectable = true;
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
            this.tasksTab.ResumeLayout(false);
            this.menuTabControl.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.tasks2Tab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn startDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn stopDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn intervalDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn activityDataGridViewTextBoxColumn;
        private BindingSource timePeriodBindingSource;
        private TabPage tasksTab;
        private MetroTabControl menuTabControl;
        private TaskEditorEditor tasksPanel;
        private MetroTabPage activitiesReportingTab;
        private ActivitiesPanel activitiesPanel1;
        private MetroTabPage metroTabPage1;
        private MetroTabPage tasks2Tab;
        private Panels.TasksControl tasksControll;
        private Panels.TasksControl tasksControl1;
    }
}

