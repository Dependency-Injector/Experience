namespace PresentationLayer.Presenters
{
    /*public class ActivityPresenter
    {
        private readonly IActivityLayer view;
        private List<Activity> activities;

        public ActivityPresenter(IActivityLayer view)
        {
            this.view = view;
            Initialize();
        }

        private void Initialize()
        {
            activities = new List<Activity>();
            view.StopActivity += StopActivity;
            view.StartActivity += StartActivity;
            view.ReportActivity+= ReportActivity;
            view.NewActivity += NewActivity;
            
        }

        private void NewActivity(object sender, EventArgs e)
        {
            /*if (!String.IsNullOrEmpty(view.ActivityName))
            {
                Activity newActivity = new Activity();
                newActivity.Name = view.ActivityName;

                repository.AddActivity(newActivity);
            }
        #1#}

        private void StartActivity(object sender, EventArgs e)
        {/*
            currentActivity = activitiesListBox.SelectedItem as Activity;
            interval = 0;

            startTime = DateTime.Now;
            startTimeValueLabel.Text = startTime.ToLongTimeString();
            endTimeValueLabel.Text = Resources.EmptyTime;

            activityTimer.Start();
        #1#}

        private void StopActivity(object sender, EventArgs e)
        {/*
            activityTimer.Stop();
            endTime = DateTime.Now;
            endTimeValueLabel.Text = endTime.ToLongTimeString();
        #1#}

        private void ReportActivity(object sender, EventArgs e)
        {
            /*TimePeriod period = new TimePeriod();
            period.Start = startTime;
            period.Stop = endTime;
            period.Interval = interval;

            currentActivity.TimePeriod.Add(period);

            repository.UpdateActivity(currentActivity);#1#
        }

        

    }*/
}
