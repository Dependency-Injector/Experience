﻿using System;
using MetroFramework.Forms;
using PresentationLayer.Presenters;

namespace PresentationLayer.Forms
{
    public partial class TestForm : MetroForm
    {
        private TaskPresenter taskPresenter;
        private ProfilePresenter profilePresenter;

        public TestForm()
        {
            InitializeComponent();

            taskPresenter = new TaskPresenter(this.tasksControl1);
            profilePresenter = new ProfilePresenter(this.profileControl);
        }

        private void TestForm_Load(object sender, EventArgs e)
        {
            this.tasksControl1.SetColumnNames();
        }

        /*private void TestForm_Load(object sender, EventArgs e)
        {
            this.tasksControl1.SetColumnNames();
        }*/
    }
}
