﻿using System.ComponentModel;
using View.Controls;

namespace View.Forms.Old
{
    partial class PosthumanFormOld
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PosthumanFormOld));
            this.contentTabControl = new MetroFramework.Controls.MetroTabControl();
            this.dayTabPage = new MetroFramework.Controls.MetroTabPage();
            this.dayControl = new JournalControl();
            this.tasksTabPage = new MetroFramework.Controls.MetroTabPage();
            this.todoListControl = new TodoListControl();
            this.profileTabPage = new MetroFramework.Controls.MetroTabPage();
            this.profileControl = new ProfileControl();
            this.historyTabPage = new MetroFramework.Controls.MetroTabPage();
            this.historyControl2 = new HistoryControl();
            this.optionsTabPage = new MetroFramework.Controls.MetroTabPage();
            this.optionsControl = new OptionsControl();
            this.metroColorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.loggedUserControl = new LoggedUserControl();
            this.loginControl = new LoginControl();
            this.historyControl1 = new HistoryControl();
            this.profileControl1 = new ProfileControl();
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
            this.contentTabControl.SelectedIndex = 1;
            this.contentTabControl.Size = new System.Drawing.Size(1186, 524);
            this.contentTabControl.TabIndex = 2;
            this.contentTabControl.UseSelectable = true;
            this.contentTabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.contentTabControl_Selected);
            // 
            // dayTabPage
            // 
            this.dayTabPage.Controls.Add(this.dayControl);
            this.dayTabPage.HorizontalScrollbarBarColor = true;
            this.dayTabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.dayTabPage.HorizontalScrollbarSize = 10;
            this.dayTabPage.Location = new System.Drawing.Point(4, 38);
            this.dayTabPage.Name = "dayTabPage";
            this.dayTabPage.Size = new System.Drawing.Size(1178, 482);
            this.dayTabPage.TabIndex = 4;
            this.dayTabPage.Text = "Memories";
            this.dayTabPage.VerticalScrollbarBarColor = true;
            this.dayTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.dayTabPage.VerticalScrollbarSize = 10;
            // 
            // journalControl
            // 
            this.dayControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dayControl.ChoosenEntryId = null;
            this.dayControl.Location = new System.Drawing.Point(3, 3);
            this.dayControl.Name = "journalControl";
            this.dayControl.Size = new System.Drawing.Size(1182, 411);
            this.dayControl.TabIndex = 2;
            this.dayControl.Thoughts = "[Thoughts]";
            this.dayControl.UseSelectable = true;
            // 
            // tasksTabPage
            // 
            this.tasksTabPage.Controls.Add(this.todoListControl);
            this.tasksTabPage.HorizontalScrollbarBarColor = true;
            this.tasksTabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.tasksTabPage.HorizontalScrollbarSize = 10;
            this.tasksTabPage.Location = new System.Drawing.Point(4, 38);
            this.tasksTabPage.Name = "tasksTabPage";
            this.tasksTabPage.Size = new System.Drawing.Size(1178, 482);
            this.tasksTabPage.TabIndex = 0;
            this.tasksTabPage.Text = "Tasks";
            this.tasksTabPage.VerticalScrollbarBarColor = true;
            this.tasksTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.tasksTabPage.VerticalScrollbarSize = 10;
            // 
            // tasksControl
            // 
            this.todoListControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            /* this.tasksListControl.Difficulty = 0;
             this.tasksListControl.DueDate = new System.DateTime(2015, 8, 11, 6, 25, 43, 330);
             this.tasksListControl.FinishDate = null;*/
            this.todoListControl.Location = new System.Drawing.Point(0, 7);
            //this.tasksListControl.MinDueDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.todoListControl.Name = "todoListControl";
            //this.tasksListControl.ParentTaskId = null;
            //this.tasksListControl.Priority = 0;
            this.todoListControl.Size = new System.Drawing.Size(1177, 479);
            // this.tasksListControl.SkillToTrainId = null;
            this.todoListControl.TabIndex = 0;
            // this.tasksListControl.TaskDescription = "Description";
            //this.todoListControl.TaskId = 0;
            // this.tasksListControl.TaskName = "Name";
            this.todoListControl.UseSelectable = true;
            // 
            // profileTabPage
            // 
            this.profileTabPage.Controls.Add(this.profileControl);
            this.profileTabPage.HorizontalScrollbarBarColor = true;
            this.profileTabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.profileTabPage.HorizontalScrollbarSize = 10;
            this.profileTabPage.Location = new System.Drawing.Point(4, 38);
            this.profileTabPage.Name = "profileTabPage";
            this.profileTabPage.Size = new System.Drawing.Size(1178, 482);
            this.profileTabPage.TabIndex = 1;
            this.profileTabPage.Text = "Profile";
            this.profileTabPage.VerticalScrollbarBarColor = true;
            this.profileTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.profileTabPage.VerticalScrollbarSize = 10;
            // 
            // profileControl
            // 
            this.profileControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.profileControl.BirthDate = new System.DateTime(2015, 12, 19, 19, 25, 56, 407);
            this.profileControl.Experience = "(Experience Value)";
            this.profileControl.History = "(History Value)";
            this.profileControl.Level = 0;
            this.profileControl.LevelProgress = 0;
            this.profileControl.Location = new System.Drawing.Point(0, 3);
            this.profileControl.Name = "profileControl";
            this.profileControl.NewSkillName = "(New skil name)";
            this.profileControl.PlayerName = "profileControl";
            this.profileControl.SelectedSkill = null;
            this.profileControl.Size = new System.Drawing.Size(1169, 485);
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
            this.historyTabPage.Size = new System.Drawing.Size(1178, 482);
            this.historyTabPage.TabIndex = 3;
            this.historyTabPage.Text = "History";
            this.historyTabPage.VerticalScrollbarBarColor = true;
            this.historyTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.historyTabPage.VerticalScrollbarSize = 10;
            // 
            // historyControl2
            // 
            this.historyControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.historyControl2.DisplayExperienceEvents = true;
            this.historyControl2.DisplayProfileAndSkillsEvents = true;
            this.historyControl2.DisplayTaskEvents = true;
            this.historyControl2.DisplayWorkUnitEvents = true;
            this.historyControl2.Location = new System.Drawing.Point(3, 3);
            this.historyControl2.Name = "historyControl2";
            this.historyControl2.Size = new System.Drawing.Size(1182, 486);
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
            this.optionsTabPage.Size = new System.Drawing.Size(1178, 482);
            this.optionsTabPage.TabIndex = 2;
            this.optionsTabPage.Text = "Options";
            this.optionsTabPage.VerticalScrollbarBarColor = true;
            this.optionsTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.optionsTabPage.VerticalScrollbarSize = 10;
            // 
            // optionsControl
            // 
            this.optionsControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.optionsControl.Location = new System.Drawing.Point(3, 3);
            this.optionsControl.Name = "optionsControl";
            this.optionsControl.ShowFinishedTasks = null;
            this.optionsControl.Size = new System.Drawing.Size(1107, 486);
            this.optionsControl.StyleName = null;
            this.optionsControl.TabIndex = 5;
            this.optionsControl.ThemeName = "Light";
            this.optionsControl.UseSelectable = true;
            // 
            // metroColorsBindingSource
            // 
            this.metroColorsBindingSource.DataSource = typeof(MetroFramework.MetroColors);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipText = "Baloon minimize text";
            this.notifyIcon1.BalloonTipTitle = "Baloon minimize title";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Icon hover text";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // loggedUserControl
            // 
            this.loggedUserControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.loggedUserControl.Location = new System.Drawing.Point(1013, 24);
            this.loggedUserControl.LoggedUserName = "[User name]";
            this.loggedUserControl.Name = "loggedUserControl";
            this.loggedUserControl.Size = new System.Drawing.Size(189, 30);
            this.loggedUserControl.TabIndex = 3;
            this.loggedUserControl.UseSelectable = true;
            // 
            // loginControl
            // 
            this.loginControl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.loginControl.IsNew = false;
            this.loginControl.Location = new System.Drawing.Point(454, 110);
            this.loginControl.Name = "loginControl";
            this.loginControl.Size = new System.Drawing.Size(319, 430);
            this.loginControl.TabIndex = 2;
            this.loginControl.UseSelectable = true;
            // 
            // historyControl1
            // 
            this.historyControl1.DisplayExperienceEvents = true;
            this.historyControl1.DisplayProfileAndSkillsEvents = true;
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
            this.profileControl1.BirthDate = new System.DateTime(2015, 12, 19, 19, 25, 56, 454);
            this.profileControl1.Experience = "(Experience Value)";
            this.profileControl1.History = "(History Value)";
            this.profileControl1.Level = 0;
            this.profileControl1.LevelProgress = 0;
            this.profileControl1.Location = new System.Drawing.Point(493, 63);
            this.profileControl1.Name = "profileControl1";
            this.profileControl1.NewSkillName = "(New skil name)";
            this.profileControl1.PlayerName = "profileControl1";
            this.profileControl1.SelectedSkill = null;
            this.profileControl1.Size = new System.Drawing.Size(368, 418);
            this.profileControl1.TabIndex = 1;
            this.profileControl1.UseSelectable = true;
            // 
            // PosthumanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackImagePadding = new System.Windows.Forms.Padding(0, 10, 20, 0);
            this.BackLocation = MetroFramework.Forms.BackLocation.TopRight;
            this.BackMaxSize = 50;
            this.ClientSize = new System.Drawing.Size(1226, 604);
            this.Controls.Add(this.loggedUserControl);
            this.Controls.Add(this.contentTabControl);
            this.Controls.Add(this.loginControl);
            this.Name = "PosthumanForm";
            this.Text = "POSTHUMAN";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PosthumanForm_FormClosing);
            this.Load += new System.EventHandler(this.TestForm_Load);
            this.Resize += new System.EventHandler(this.TestForm_Resize);
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

        private TodoListControl todoListControl;
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
        private JournalControl dayControl;
        private HistoryControl historyControl2;
        private LoginControl loginControl;
        private LoggedUserControl loggedUserControl;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}