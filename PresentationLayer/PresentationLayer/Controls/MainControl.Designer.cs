namespace PresentationLayer.Controls
{
    partial class MainControl
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
            this.subViewsTabControl = new MetroFramework.Controls.MetroTabControl();
            this.dayTabPage = new MetroFramework.Controls.MetroTabPage();
            this.tasksTabPage = new MetroFramework.Controls.MetroTabPage();
            this.profileTabPage = new MetroFramework.Controls.MetroTabPage();
            this.historyTabPage = new MetroFramework.Controls.MetroTabPage();
            this.optionsTabPage = new MetroFramework.Controls.MetroTabPage();
            this.dayControl = new PresentationLayer.Controls.DayControl();
            this.tasksListControl = new PresentationLayer.Controls.TasksListControl();
            this.profileControl = new PresentationLayer.Controls.ProfileControl();
            this.historyControl = new PresentationLayer.Controls.HistoryControl();
            this.optionsControl = new PresentationLayer.Controls.OptionsControl();
            this.subViewsTabControl.SuspendLayout();
            this.dayTabPage.SuspendLayout();
            this.tasksTabPage.SuspendLayout();
            this.profileTabPage.SuspendLayout();
            this.historyTabPage.SuspendLayout();
            this.optionsTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // subViewsTabControl
            // 
            this.subViewsTabControl.Controls.Add(this.dayTabPage);
            this.subViewsTabControl.Controls.Add(this.tasksTabPage);
            this.subViewsTabControl.Controls.Add(this.profileTabPage);
            this.subViewsTabControl.Controls.Add(this.historyTabPage);
            this.subViewsTabControl.Controls.Add(this.optionsTabPage);
            this.subViewsTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.subViewsTabControl.Location = new System.Drawing.Point(0, 0);
            this.subViewsTabControl.Name = "subViewsTabControl";
            this.subViewsTabControl.SelectedIndex = 2;
            this.subViewsTabControl.Size = new System.Drawing.Size(1100, 600);
            this.subViewsTabControl.TabIndex = 3;
            this.subViewsTabControl.UseSelectable = true;
            this.subViewsTabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.contentTabControl_Selected);
            // 
            // dayTabPage
            // 
            this.dayTabPage.AutoScroll = true;
            this.dayTabPage.Controls.Add(this.dayControl);
            this.dayTabPage.HorizontalScrollbar = true;
            this.dayTabPage.HorizontalScrollbarBarColor = true;
            this.dayTabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.dayTabPage.HorizontalScrollbarSize = 10;
            this.dayTabPage.Location = new System.Drawing.Point(4, 38);
            this.dayTabPage.Name = "dayTabPage";
            this.dayTabPage.Padding = new System.Windows.Forms.Padding(25);
            this.dayTabPage.Size = new System.Drawing.Size(1092, 558);
            this.dayTabPage.TabIndex = 4;
            this.dayTabPage.Text = "Memories";
            this.dayTabPage.VerticalScrollbar = true;
            this.dayTabPage.VerticalScrollbarBarColor = true;
            this.dayTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.dayTabPage.VerticalScrollbarSize = 10;
            // 
            // tasksTabPage
            // 
            this.tasksTabPage.AutoScroll = true;
            this.tasksTabPage.Controls.Add(this.tasksListControl);
            this.tasksTabPage.HorizontalScrollbar = true;
            this.tasksTabPage.HorizontalScrollbarBarColor = true;
            this.tasksTabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.tasksTabPage.HorizontalScrollbarSize = 10;
            this.tasksTabPage.Location = new System.Drawing.Point(4, 38);
            this.tasksTabPage.Name = "tasksTabPage";
            this.tasksTabPage.Padding = new System.Windows.Forms.Padding(25);
            this.tasksTabPage.Size = new System.Drawing.Size(1092, 558);
            this.tasksTabPage.TabIndex = 0;
            this.tasksTabPage.Text = "Tasks";
            this.tasksTabPage.VerticalScrollbar = true;
            this.tasksTabPage.VerticalScrollbarBarColor = true;
            this.tasksTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.tasksTabPage.VerticalScrollbarSize = 10;
            // 
            // profileTabPage
            // 
            this.profileTabPage.AutoScroll = true;
            this.profileTabPage.Controls.Add(this.profileControl);
            this.profileTabPage.HorizontalScrollbar = true;
            this.profileTabPage.HorizontalScrollbarBarColor = true;
            this.profileTabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.profileTabPage.HorizontalScrollbarSize = 10;
            this.profileTabPage.Location = new System.Drawing.Point(4, 38);
            this.profileTabPage.Name = "profileTabPage";
            this.profileTabPage.Padding = new System.Windows.Forms.Padding(5);
            this.profileTabPage.Size = new System.Drawing.Size(1092, 558);
            this.profileTabPage.TabIndex = 1;
            this.profileTabPage.Text = "Profile";
            this.profileTabPage.VerticalScrollbar = true;
            this.profileTabPage.VerticalScrollbarBarColor = true;
            this.profileTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.profileTabPage.VerticalScrollbarSize = 10;
            // 
            // historyTabPage
            // 
            this.historyTabPage.Controls.Add(this.historyControl);
            this.historyTabPage.HorizontalScrollbarBarColor = true;
            this.historyTabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.historyTabPage.HorizontalScrollbarSize = 10;
            this.historyTabPage.Location = new System.Drawing.Point(4, 38);
            this.historyTabPage.Name = "historyTabPage";
            this.historyTabPage.Padding = new System.Windows.Forms.Padding(25);
            this.historyTabPage.Size = new System.Drawing.Size(1092, 558);
            this.historyTabPage.TabIndex = 3;
            this.historyTabPage.Text = "History";
            this.historyTabPage.VerticalScrollbarBarColor = true;
            this.historyTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.historyTabPage.VerticalScrollbarSize = 10;
            // 
            // optionsTabPage
            // 
            this.optionsTabPage.AutoScroll = true;
            this.optionsTabPage.Controls.Add(this.optionsControl);
            this.optionsTabPage.HorizontalScrollbar = true;
            this.optionsTabPage.HorizontalScrollbarBarColor = true;
            this.optionsTabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.optionsTabPage.HorizontalScrollbarSize = 10;
            this.optionsTabPage.Location = new System.Drawing.Point(4, 38);
            this.optionsTabPage.Name = "optionsTabPage";
            this.optionsTabPage.Padding = new System.Windows.Forms.Padding(25);
            this.optionsTabPage.Size = new System.Drawing.Size(1092, 558);
            this.optionsTabPage.TabIndex = 2;
            this.optionsTabPage.Text = "Options";
            this.optionsTabPage.VerticalScrollbar = true;
            this.optionsTabPage.VerticalScrollbarBarColor = true;
            this.optionsTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.optionsTabPage.VerticalScrollbarSize = 10;
            // 
            // dayControl
            // 
            this.dayControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dayControl.ChoosenEntryId = null;
            this.dayControl.Location = new System.Drawing.Point(28, 28);
            this.dayControl.Name = "dayControl";
            this.dayControl.Size = new System.Drawing.Size(1025, 505);
            this.dayControl.TabIndex = 2;
            this.dayControl.Thoughts = "[Thoughts]";
            this.dayControl.UseSelectable = true;
            // 
            // tasksControl
            // 
            this.tasksListControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tasksListControl.Difficulty = 0;
            this.tasksListControl.DueDate = new System.DateTime(2015, 8, 11, 6, 25, 43, 330);
            this.tasksListControl.FinishDate = null;
            this.tasksListControl.Location = new System.Drawing.Point(25, 28);
            this.tasksListControl.MinDueDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.tasksListControl.Name = "tasksListControl";
            this.tasksListControl.ParentTaskId = null;
            this.tasksListControl.Priority = 0;
            this.tasksListControl.Size = new System.Drawing.Size(1039, 506);
            this.tasksListControl.SkillToTrainId = null;
            this.tasksListControl.TabIndex = 0;
            this.tasksListControl.TaskDescription = "Description";
            this.tasksListControl.TaskId = 0;
            this.tasksListControl.TaskName = "Name";
            this.tasksListControl.UseSelectable = true;
            // 
            // profileControl
            // 
            this.profileControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.profileControl.BirthDate = new System.DateTime(2016, 1, 30, 20, 53, 28, 79);
            this.profileControl.Experience = "(Experience Value)";
            this.profileControl.History = "(History Value)";
            this.profileControl.Level = 0;
            this.profileControl.LevelProgress = 0;
            this.profileControl.Location = new System.Drawing.Point(5, 8);
            this.profileControl.Name = "profileControl";
            this.profileControl.NewSkillName = "(New skil name)";
            this.profileControl.PlayerName = "profileControl";
            this.profileControl.SelectedSkill = null;
            this.profileControl.Size = new System.Drawing.Size(1066, 542);
            this.profileControl.TabIndex = 1;
            this.profileControl.UseSelectable = true;
            // 
            // historyControl
            // 
            this.historyControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.historyControl.DisplayExperienceEvents = true;
            this.historyControl.DisplayProfileAndSkillsEvents = true;
            this.historyControl.DisplayTaskEvents = true;
            this.historyControl.DisplayWorkUnitEvents = true;
            this.historyControl.Location = new System.Drawing.Point(28, 28);
            this.historyControl.Name = "historyControl";
            this.historyControl.Size = new System.Drawing.Size(703, 343);
            this.historyControl.TabIndex = 2;
            this.historyControl.UseSelectable = true;
            // 
            // optionsControl
            // 
            this.optionsControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.optionsControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.optionsControl.Location = new System.Drawing.Point(28, 28);
            this.optionsControl.Name = "optionsControl";
            this.optionsControl.ShowFinishedTasks = null;
            this.optionsControl.Size = new System.Drawing.Size(463, 362);
            this.optionsControl.StyleName = null;
            this.optionsControl.TabIndex = 5;
            this.optionsControl.ThemeName = "Light";
            this.optionsControl.UseSelectable = true;
            // 
            // MainControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.subViewsTabControl);
            this.Name = "MainControl";
            this.Size = new System.Drawing.Size(1100, 600);
            this.subViewsTabControl.ResumeLayout(false);
            this.dayTabPage.ResumeLayout(false);
            this.tasksTabPage.ResumeLayout(false);
            this.profileTabPage.ResumeLayout(false);
            this.historyTabPage.ResumeLayout(false);
            this.optionsTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl subViewsTabControl;
        private MetroFramework.Controls.MetroTabPage dayTabPage;
        private DayControl dayControl;
        private MetroFramework.Controls.MetroTabPage tasksTabPage;
        private TasksListControl tasksListControl;
        private MetroFramework.Controls.MetroTabPage profileTabPage;
        private ProfileControl profileControl;
        private MetroFramework.Controls.MetroTabPage historyTabPage;
        private HistoryControl historyControl;
        private MetroFramework.Controls.MetroTabPage optionsTabPage;
        private OptionsControl optionsControl;
    }
}
