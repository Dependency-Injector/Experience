using System.ComponentModel;
using PresentationLayer.Controls;

namespace PresentationLayer.Forms
{
    partial class TestForm
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
            this.contentTabControl = new MetroFramework.Controls.MetroTabControl();
            this.dayTabPage = new MetroFramework.Controls.MetroTabPage();
            this.dayControl = new PresentationLayer.Controls.DayControl();
            this.tasksTabPage = new MetroFramework.Controls.MetroTabPage();
            this.tasksControl1 = new PresentationLayer.Controls.TasksControl();
            this.profileTabPage = new MetroFramework.Controls.MetroTabPage();
            this.profileControl = new PresentationLayer.Controls.ProfileControl();
            this.historyTabPage = new MetroFramework.Controls.MetroTabPage();
            this.historyControl2 = new PresentationLayer.Controls.HistoryControl();
            this.optionsTabPage = new MetroFramework.Controls.MetroTabPage();
            this.optionsControl = new PresentationLayer.Controls.OptionsControl();
            this.metroColorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.historyControl1 = new PresentationLayer.Controls.HistoryControl();
            this.profileControl1 = new PresentationLayer.Controls.ProfileControl();
            this.contentTabControl.SuspendLayout();
            this.dayTabPage.SuspendLayout();
            this.tasksTabPage.SuspendLayout();
            this.profileTabPage.SuspendLayout();
            this.historyTabPage.SuspendLayout();
            this.optionsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroColorsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // contentTabControl
            // 
            this.contentTabControl.Controls.Add(this.dayTabPage);
            this.contentTabControl.Controls.Add(this.tasksTabPage);
            this.contentTabControl.Controls.Add(this.profileTabPage);
            this.contentTabControl.Controls.Add(this.historyTabPage);
            this.contentTabControl.Controls.Add(this.optionsTabPage);
            this.contentTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentTabControl.Location = new System.Drawing.Point(20, 60);
            this.contentTabControl.Name = "contentTabControl";
            this.contentTabControl.SelectedIndex = 3;
            this.contentTabControl.Size = new System.Drawing.Size(1160, 620);
            this.contentTabControl.TabIndex = 2;
            this.contentTabControl.UseSelectable = true;
            // 
            // dayTabPage
            // 
            this.dayTabPage.Controls.Add(this.dayControl);
            this.dayTabPage.HorizontalScrollbarBarColor = true;
            this.dayTabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.dayTabPage.HorizontalScrollbarSize = 10;
            this.dayTabPage.Location = new System.Drawing.Point(4, 38);
            this.dayTabPage.Name = "dayTabPage";
            this.dayTabPage.Size = new System.Drawing.Size(1152, 578);
            this.dayTabPage.TabIndex = 4;
            this.dayTabPage.Text = "Day";
            this.dayTabPage.VerticalScrollbarBarColor = true;
            this.dayTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.dayTabPage.VerticalScrollbarSize = 10;
            // 
            // dayControl
            // 
            this.dayControl.Location = new System.Drawing.Point(0, 0);
            this.dayControl.Name = "dayControl";
            this.dayControl.Size = new System.Drawing.Size(368, 442);
            this.dayControl.TabIndex = 2;
            this.dayControl.Thoughts = "[Thoughts]";
            this.dayControl.UseSelectable = true;
            // 
            // tasksTabPage
            // 
            this.tasksTabPage.Controls.Add(this.tasksControl1);
            this.tasksTabPage.HorizontalScrollbarBarColor = true;
            this.tasksTabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.tasksTabPage.HorizontalScrollbarSize = 10;
            this.tasksTabPage.Location = new System.Drawing.Point(4, 38);
            this.tasksTabPage.Name = "tasksTabPage";
            this.tasksTabPage.Size = new System.Drawing.Size(1152, 578);
            this.tasksTabPage.TabIndex = 0;
            this.tasksTabPage.Text = "Tasks";
            this.tasksTabPage.VerticalScrollbarBarColor = true;
            this.tasksTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.tasksTabPage.VerticalScrollbarSize = 10;
            // 
            // tasksControl1
            // 
            this.tasksControl1.DueDate = new System.DateTime(2015, 8, 11, 6, 25, 43, 330);
            this.tasksControl1.FinishDate = null;
            this.tasksControl1.Location = new System.Drawing.Point(0, 0);
            this.tasksControl1.Name = "tasksControl1";
            this.tasksControl1.ParentTaskId = null;
            this.tasksControl1.Priority = 0;
            this.tasksControl1.Size = new System.Drawing.Size(1153, 575);
            this.tasksControl1.SkillToTrainId = null;
            this.tasksControl1.TabIndex = 0;
            this.tasksControl1.TaskDescription = "Description";
            this.tasksControl1.TaskId = 0;
            this.tasksControl1.TaskName = "Name";
            this.tasksControl1.UseSelectable = true;
            // 
            // profileTabPage
            // 
            this.profileTabPage.Controls.Add(this.profileControl);
            this.profileTabPage.HorizontalScrollbarBarColor = true;
            this.profileTabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.profileTabPage.HorizontalScrollbarSize = 10;
            this.profileTabPage.Location = new System.Drawing.Point(4, 38);
            this.profileTabPage.Name = "profileTabPage";
            this.profileTabPage.Size = new System.Drawing.Size(1152, 578);
            this.profileTabPage.TabIndex = 1;
            this.profileTabPage.Text = "Profile";
            this.profileTabPage.VerticalScrollbarBarColor = true;
            this.profileTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.profileTabPage.VerticalScrollbarSize = 10;
            // 
            // profileControl
            // 
            this.profileControl.Age = 0;
            this.profileControl.BirthDate = new System.DateTime(2015, 8, 24, 2, 7, 49, 920);
            this.profileControl.Experience = 0;
            this.profileControl.History = "(History Value)";
            this.profileControl.Level = 0;
            this.profileControl.LevelProgress = 0;
            this.profileControl.Location = new System.Drawing.Point(-1, 0);
            this.profileControl.Name = "profileControl";
            this.profileControl.PlayerName = "profileControl";
            this.profileControl.Size = new System.Drawing.Size(1154, 575);
            this.profileControl.TabIndex = 1;
            this.profileControl.UseSelectable = true;
            // 
            // historyTabPage
            // 
            this.historyTabPage.Controls.Add(this.historyControl2);
            this.historyTabPage.HorizontalScrollbarBarColor = true;
            this.historyTabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.historyTabPage.HorizontalScrollbarSize = 10;
            this.historyTabPage.Location = new System.Drawing.Point(4, 38);
            this.historyTabPage.Name = "historyTabPage";
            this.historyTabPage.Size = new System.Drawing.Size(1152, 578);
            this.historyTabPage.TabIndex = 3;
            this.historyTabPage.Text = "History";
            this.historyTabPage.VerticalScrollbarBarColor = true;
            this.historyTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.historyTabPage.VerticalScrollbarSize = 10;
            // 
            // historyControl2
            // 
            this.historyControl2.DisplayExperienceEvents = true;
            this.historyControl2.DisplayTaskEvents = true;
            this.historyControl2.DisplayWorkUnitEvents = true;
            this.historyControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.historyControl2.Location = new System.Drawing.Point(0, 0);
            this.historyControl2.Name = "historyControl2";
            this.historyControl2.Size = new System.Drawing.Size(1152, 578);
            this.historyControl2.TabIndex = 2;
            this.historyControl2.UseSelectable = true;
            // 
            // optionsTabPage
            // 
            this.optionsTabPage.Controls.Add(this.optionsControl);
            this.optionsTabPage.HorizontalScrollbarBarColor = true;
            this.optionsTabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.optionsTabPage.HorizontalScrollbarSize = 10;
            this.optionsTabPage.Location = new System.Drawing.Point(4, 38);
            this.optionsTabPage.Name = "optionsTabPage";
            this.optionsTabPage.Size = new System.Drawing.Size(1152, 578);
            this.optionsTabPage.TabIndex = 2;
            this.optionsTabPage.Text = "Options";
            this.optionsTabPage.VerticalScrollbarBarColor = true;
            this.optionsTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.optionsTabPage.VerticalScrollbarSize = 10;
            // 
            // optionsControl
            // 
            this.optionsControl.Location = new System.Drawing.Point(3, 3);
            this.optionsControl.Name = "optionsControl";
            this.optionsControl.ShowFinishedTasks = null;
            this.optionsControl.Size = new System.Drawing.Size(460, 420);
            this.optionsControl.StyleName = null;
            this.optionsControl.TabIndex = 5;
            this.optionsControl.ThemeName = "Light";
            this.optionsControl.UseSelectable = true;
            // 
            // metroColorsBindingSource
            // 
            this.metroColorsBindingSource.DataSource = typeof(MetroFramework.MetroColors);
            // 
            // historyControl1
            // 
            this.historyControl1.DisplayExperienceEvents = true;
            this.historyControl1.DisplayTaskEvents = true;
            this.historyControl1.DisplayWorkUnitEvents = true;
            this.historyControl1.Location = new System.Drawing.Point(0, 0);
            this.historyControl1.Name = "historyControl1";
            this.historyControl1.Size = new System.Drawing.Size(1091, 575);
            this.historyControl1.TabIndex = 2;
            this.historyControl1.UseSelectable = true;
            // 
            // profileControl1
            // 
            this.profileControl1.Age = 0;
            this.profileControl1.BirthDate = new System.DateTime(2015, 8, 24, 2, 7, 49, 945);
            this.profileControl1.Experience = 0;
            this.profileControl1.History = "(History Value)";
            this.profileControl1.Level = 0;
            this.profileControl1.LevelProgress = 0;
            this.profileControl1.Location = new System.Drawing.Point(493, 63);
            this.profileControl1.Name = "profileControl1";
            this.profileControl1.PlayerName = "profileControl1";
            this.profileControl1.Size = new System.Drawing.Size(368, 418);
            this.profileControl1.TabIndex = 1;
            this.profileControl1.UseSelectable = true;
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.contentTabControl);
            this.Name = "TestForm";
            this.Text = "jp2gmd";
            this.Load += new System.EventHandler(this.TestForm_Load);
            this.contentTabControl.ResumeLayout(false);
            this.dayTabPage.ResumeLayout(false);
            this.tasksTabPage.ResumeLayout(false);
            this.profileTabPage.ResumeLayout(false);
            this.historyTabPage.ResumeLayout(false);
            this.optionsTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroColorsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TasksControl tasksControl1;
        private ProfileControl profileControl;
        private ProfileControl profileControl1;
        private MetroFramework.Controls.MetroTabControl contentTabControl;
        private MetroFramework.Controls.MetroTabPage tasksTabPage;
        private MetroFramework.Controls.MetroTabPage profileTabPage;
        private MetroFramework.Controls.MetroTabPage optionsTabPage;
        private System.Windows.Forms.BindingSource metroColorsBindingSource;
        private OptionsControl optionsControl;
        private MetroFramework.Controls.MetroTabPage historyTabPage;
        private HistoryControl historyControl1;
        private MetroFramework.Controls.MetroTabPage dayTabPage;
        private DayControl dayControl;
        private HistoryControl historyControl2;
    }
}