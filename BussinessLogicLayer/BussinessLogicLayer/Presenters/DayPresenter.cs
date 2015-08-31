using System;
using BussinessLogicLayer.Interfaces;
using DataAccessLayer.Repositories;
using DataAccessLayer.Repositories.Interfaces;
using DataAccessLayer.Services;
using MetroFramework;
using Model.Entities;
using Model.Enums;
using Utilities;

namespace BussinessLogicLayer.Presenters
{
    public class DayPresenter
    {
        private readonly IDayView view;
        private readonly IDaysRepository daysRepository;
        private readonly IProfileRepository profileRepository;

        private readonly DaysService daysService;

        private Day dayToDisplay;
        private Profile currentUser;

        public DayPresenter(IDayView view, IDaysRepository daysRepository, IProfileRepository profileRepository)
        {
            this.view = view;
            this.daysRepository = daysRepository;
            this.profileRepository = profileRepository;
            daysService = new DaysService();

            Initialize();
        }

        private void Initialize()
        {
            try
            {
                AttachEvents();
                dayToDisplay = daysRepository.Get(DateTime.Now);
                DateTime firstDay;

                if (ApplicationSettings.Current.CurrentUserId.HasValue)
                {
                    currentUser = profileRepository.Get(ApplicationSettings.Current.CurrentUserId.Value);
                    firstDay = currentUser.JoinDate;
                }
                else
                {
                    firstDay = DateTime.Now;
                }

                int daysSinceUserFirstDay = GetDaysBetweenDates(DateTime.Now, firstDay);

                if (dayToDisplay != null)
                {
                    DisplayDayData(dayToDisplay, daysSinceUserFirstDay);
                }
                else
                {
                    dayToDisplay = CreateNewDay(DateTime.Now);
                    //dayToDisplay.Owner = currentUser;
                    daysRepository.Add(dayToDisplay);
                    DisplayDayData(dayToDisplay, daysSinceUserFirstDay);
                }

                ShowNextPreviousDayButtons(dayToDisplay.Date.Date, currentUser.GetDaysSinceFirstDay());


                view.DisplayMode = DisplayMode.View;
            }
            catch (Exception e)
            {
                MetroMessageBox.Show(view.Window, e.Message);
            }
        }

        private void ShowNextPreviousDayButtons(DateTime dayBeingDisplayed, int daysSinceFirstDay)
        {
            if (dayBeingDisplayed.Date.Date < DateTime.Now.Date)
                ShowNextDayButton(true);
            else
                ShowNextDayButton(false);

            if (daysSinceFirstDay > 1)
                ShowPreviousDayButton(true);
            else
                ShowPreviousDayButton(false);
        }

        private void ShowPreviousDayButton(bool show)
        {
            view.ShowPreviousDayButton = show;
        }

        private void ShowNextDayButton(bool show)
        {
            view.ShowNextDayButton = show;
        }

        private void AttachEvents()
        {
            view.ShowPreviousDay += ShowPreviousDay;
            view.ShowNextDay += ShowNextDay;
            view.SaveDay += SaveDay;
            view.SwitchDisplayMode += SwitchDisplayMode;
        }

        private void ShowNextDay(object sender, EventArgs e)
        {
            DateTime dateOfDayAhead = GetDayAhead(dayToDisplay.Date);
            Day dayAhead = null;
            if (daysRepository.HasDay(dateOfDayAhead))
            {
                dayAhead = daysRepository.Get(dateOfDayAhead);
            }
            else
            {
                dayAhead = CreateNewDay(dateOfDayAhead);
            }

            int daysSinceDayAhead = GetDaysBetweenDates(dateOfDayAhead, currentUser.JoinDate);
            DisplayDayData(dayAhead, daysSinceDayAhead);
            ShowNextPreviousDayButtons(dateOfDayAhead, currentUser.GetDaysSinceFirstDay(dateOfDayAhead));
        }

        DateTime GetDayBefore(DateTime day)
        {
            DateTime dateOfDayBefore = dayToDisplay.Date.AddDays(-1);
            return dateOfDayBefore;
        }

        DateTime GetDayAhead(DateTime day)
        {
            DateTime dateOfDayAhead = dayToDisplay.Date.AddDays(+1);
            return dateOfDayAhead;
        }

        private void ShowPreviousDay(object sender, EventArgs e)
        {
            DateTime dateOfDayBefore = dayToDisplay.Date.AddDays(-1);
            Day dayBefore = null;

            if (daysRepository.HasDay(dateOfDayBefore))
            {
                dayBefore = daysRepository.Get(dateOfDayBefore);
            }
            else
            {
                dayBefore = CreateNewDay(dateOfDayBefore);
            }

            int daysSinceDayBefore = GetDaysBetweenDates(dateOfDayBefore, currentUser.JoinDate);

            DisplayDayData(dayBefore, daysSinceDayBefore);
            ShowNextPreviousDayButtons(dateOfDayBefore, currentUser.GetDaysSinceFirstDay(dateOfDayBefore));
        }

        private void SaveDay(object sender, EventArgs e)
        {
            dayToDisplay = daysService.UpdateExistingDay(dayToDisplay.Id, view.Thoughts);
            daysRepository.Update(dayToDisplay);

            view.DisplayMode = DisplayMode.View;
        }

        private void SwitchDisplayMode(object sender, SwitchDisplayModeEventArgs e)
        {
            view.DisplayMode = e.DisplayMode;
        }

        private Day CreateNewDay(DateTime when)
        {
            Day newDay = new Day();
            newDay.Date = when;
            newDay.Thoughts = String.Empty;
            return newDay;
        }

        private void DisplayDayData(Day day, double dayNumber)
        {
            view.DayNumber = (int)dayNumber;
            view.Date = day.Date;
            view.Thoughts = day.Thoughts;
        }

        private int GetDaysBetweenDates(DateTime newerDate, DateTime olderDate)
        {
            double daysBetweenDates = (newerDate - olderDate).TotalDays;
            return (int)daysBetweenDates;
        }
    }
}
