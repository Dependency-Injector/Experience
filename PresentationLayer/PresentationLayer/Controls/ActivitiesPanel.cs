

using System;
using System.Timers;
using MetroFramework.Controls;
using PresentationLayer.Views;
using Utilities;

namespace PresentationLayer.Controls
{
    public partial class ActivitiesPanel : MetroUserControl, IActivityLayer
    {
        //private ActivityPresenter presenter;
        private Timer activityTimer;

        public string ActivityName
        {
            get { return newActivityTitleTextBox.Text; }
            set { newActivityTitleTextBox.Text = value; }
        }

        public DateTime? StartDateTime
        {
            get { return Convert.ToDateTime(startTimeValueLabel.Text); }
            set { startTimeValueLabel.Text = value.HasValue ? value.Value.ToShortTimeString() : DefaultValues.DefaultHour;
            }
        }

        public DateTime? EndDateTime
        {
            get { return DateTime.Parse(endTimeValueLabel.Text); }
            set
            {
                endTimeValueLabel.Text = value.HasValue ? value.Value.ToShortTimeString() : DefaultValues.DefaultHour;
            }
        }

        public DateTime? ElapsedTime
        {
            get { return DateTime.Parse(endTimeValueLabel.Text); }
            set
            {
                elapsedTimeLabel.Text = value.HasValue ? value.Value.ToShortTimeString() : DefaultValues.DefaultHour;
            }
        }

        public bool IsDirty { get; set; }

        public event EventHandler<EventArgs> StartActivity;
        public event EventHandler<EventArgs> ReportActivity;
        public event EventHandler<EventArgs> Delete;
        public event EventHandler<EventArgs> StopActivity;
        public event EventHandler<EventArgs> NewActivity;
        public event EventHandler<EventArgs> Pause;

        public event EventHandler<EventArgs> AddActivity;

        public ActivitiesPanel()
        {
            InitializeComponent();
        

          //  activityTimer = new Timer();
          //  activityTimer.Interval = 1000;
           // activityTimer. += activityTimer_Tick;
        }


        private void ActivitiesPanel_Load(object sender, EventArgs e)
        {
            //presenter = new ActivityPresenter(this);
            this.IsDirty = false;
        }


        //private void Load(object sender, EventArgs e)
        //{
        //    presenter = new ActivityPresenter(this);
/*
            if (repository.GetActivities() != null && repository.GetActivities().Any())
            {
                List<Activity> activities = repository.GetActivities().ToList();
                activitiesListBox.DataSource = activities;
                activitiesListBox.ValueMember = "Id";
                activitiesListBox.DisplayMember = "Name";
            }*/

       // }

        private void activityTimer_Tick(object sender, EventArgs e)
        {
          //  interval += 1;
         //   timeLeftValueLabel.Text = interval.ToString();
        }

        private void addActivityButton_Click(object sender, EventArgs e)
        {

        }

        private void startActivityButton_Click(object sender, EventArgs e)
        {
            if(StartActivity != null)
                StartActivity(sender, e);
        }

        private void stopActivityButton_Click(object sender, EventArgs e)
        {
            if (StopActivity != null)
                StopActivity(sender, e);
        }

        private void saveActivityButton_Click(object sender, EventArgs e)
        {
            if (ReportActivity != null)
                ReportActivity(sender, e);
        }

        private void pauseActivityButton_Click(object sender, EventArgs e)
        {
            if(pauseActivityButton != null)
                Pause(sender, e);
        }

        private void resetActivityButton_Click(object sender, EventArgs e)
        {
            if (NewActivity != null)
                NewActivity(sender, e);
        }

        private void addNewActivity_Click(object sender, EventArgs e)
        {
            if (AddActivity != null)
                AddActivity(sender, e);
        }
    }
}
