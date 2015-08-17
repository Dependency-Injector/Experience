﻿using System.ComponentModel;
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
            this.tasksTabPage = new MetroFramework.Controls.MetroTabPage();
            this.profileTabPage = new MetroFramework.Controls.MetroTabPage();
            this.optionsTabPage = new MetroFramework.Controls.MetroTabPage();
            this.metroColorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tasksControl1 = new PresentationLayer.Controls.TasksControl();
            this.profileControl = new PresentationLayer.Controls.ProfileControl();
            this.optionsControl = new PresentationLayer.Controls.OptionsControl();
            this.profileControl1 = new PresentationLayer.Controls.ProfileControl();
            this.contentTabControl.SuspendLayout();
            this.tasksTabPage.SuspendLayout();
            this.profileTabPage.SuspendLayout();
            this.optionsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroColorsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // contentTabControl
            // 
            this.contentTabControl.Controls.Add(this.tasksTabPage);
            this.contentTabControl.Controls.Add(this.profileTabPage);
            this.contentTabControl.Controls.Add(this.optionsTabPage);
            this.contentTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentTabControl.Location = new System.Drawing.Point(20, 60);
            this.contentTabControl.Name = "contentTabControl";
            this.contentTabControl.SelectedIndex = 2;
            this.contentTabControl.Size = new System.Drawing.Size(1160, 620);
            this.contentTabControl.TabIndex = 2;
            this.contentTabControl.UseSelectable = true;
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
            // metroColorsBindingSource
            // 
            this.metroColorsBindingSource.DataSource = typeof(MetroFramework.MetroColors);
            // 
            // tasksControl1
            // 
            this.tasksControl1.DueDate = new System.DateTime(2015, 8, 11, 6, 25, 43, 330);
            this.tasksControl1.FinishDate = null;
            this.tasksControl1.IsDirty = true;
            this.tasksControl1.Location = new System.Drawing.Point(0, 0);
            this.tasksControl1.Name = "tasksControl1";
            this.tasksControl1.ParentTaskId = null;
            this.tasksControl1.Priority = 0;
            this.tasksControl1.Size = new System.Drawing.Size(1153, 575);
            this.tasksControl1.SkillToTrainId = null;
            this.tasksControl1.TabIndex = 0;
            this.tasksControl1.TaskDescription = "Description";
            this.tasksControl1.TaskName = "Name";
            this.tasksControl1.UseSelectable = true;
            // 
            // profileControl
            // 
            this.profileControl.Age = 0;
            this.profileControl.BirthDate = new System.DateTime(2015, 8, 17, 1, 30, 53, 181);
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
            // optionsControl
            // 
            this.optionsControl.Location = new System.Drawing.Point(3, 3);
            this.optionsControl.Name = "optionsControl";
            this.optionsControl.Size = new System.Drawing.Size(460, 420);
            this.optionsControl.StyleName = "Blue";
            this.optionsControl.TabIndex = 5;
            this.optionsControl.ThemeName = "Light";
            this.optionsControl.UseSelectable = true;
            // 
            // profileControl1
            // 
            this.profileControl1.Age = 0;
            this.profileControl1.BirthDate = new System.DateTime(2015, 8, 17, 1, 30, 53, 188);
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
            this.Text = "JESTEM OGARNIĘTY";
            this.Load += new System.EventHandler(this.TestForm_Load);
            this.contentTabControl.ResumeLayout(false);
            this.tasksTabPage.ResumeLayout(false);
            this.profileTabPage.ResumeLayout(false);
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
    }
}