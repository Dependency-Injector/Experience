using System;
using MetroFramework.Forms;
using PresentationLayer.Presenters;

namespace PresentationLayer.Controls
{
    public partial class MainForm : MetroForm
    {
        TaskPresenter taskPresenter;

        public MainForm()
        {
            InitializeComponent();
          
            taskPresenter = new TaskPresenter(this.tasksPanel);
        }

        private void addActivityButton_Click(object sender, EventArgs e)
        {
 /*           if (!String.IsNullOrEmpty(newActivityTextBox.Text))
            {
                Activity newActivity = new Activity();
                newActivity.Name = newActivityTextBox.Text;

                repository.AddActivity(newActivity);
            }*/
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         /*   if (repository.GetActivities() != null && repository.GetActivities().Any())
            {
                List<Activity> activities = repository.GetActivities().ToList();
                activitiesListBox.DataSource = activities;
                activitiesListBox.ValueMember = "Id";
                activitiesListBox.DisplayMember = "Name";
            }*/
        }

        private DateTime startTime;

        private void startActivityButton_Click(object sender, EventArgs e)
        {/*
            currentActivity = activitiesListBox.SelectedItem as Activity;
            interval = 0;

            startTime = DateTime.Now;
            startTimeValueLabel.Text = startTime.ToLongTimeString();
            endTimeValueLabel.Text = Resources.EmptyTime;

            activityTimer.Start();*/
        }

        private void activityTimer_Tick(object sender, EventArgs e)
        {
      /*      interval += 1;
            timeLeftValueLabel.Text = interval.ToString();*/
        }

        private void stopActivityButton_Click(object sender, EventArgs e)
        {
         /*   activityTimer.Stop();
            endTime = DateTime.Now;
            endTimeValueLabel.Text = endTime.ToLongTimeString();*/
        }

        private void saveActivityButton_Click(object sender, EventArgs e)
        {
      /*      TimePeriod period = new TimePeriod();
            period.Start = startTime;
            period.Stop = endTime;
            period.Interval = interval;

            currentActivity.TimePeriod.Add(period);

            repository.UpdateActivity(currentActivity);*/
        }

        private void activitiesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void tasksTab_Click(object sender, EventArgs e)
        {

        }
    }
}
