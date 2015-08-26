using System;
using BussinessLogicLayer.Interfaces;
using DataAccessLayer.Repositories;
using DataAccessLayer.Repositories.Interfaces;
using DataAccessLayer.Services;
using MetroFramework;
using Model.Entities;
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
                    daysRepository.Add(dayToDisplay);
                    DisplayDayData(dayToDisplay, daysSinceUserFirstDay);
                }
            }
            catch (Exception e)
            {
                MetroMessageBox.Show(view.Window, e.Message);
            }
        }

        private void AttachEvents()
        {
            view.PreviousDay += PreviousDay;
            view.NextDay += NextDay;
            view.SaveDay += SaveDay;
        }

        private void NextDay(object sender, EventArgs e)
        {
            DateTime dateOfDayAhead = dayToDisplay.Date.AddDays(+1);
            if (daysRepository.HasDay(dateOfDayAhead))
            {
                Day dayAhead = daysRepository.Get(dateOfDayAhead);
                int daysSinceDayAhead = GetDaysBetweenDates(dateOfDayAhead, currentUser.JoinDate);

                DisplayDayData(dayAhead, daysSinceDayAhead);
            }
            else
            {

            }
        }

        private void PreviousDay(object sender, EventArgs e)
        {
            DateTime dateOfDayBefore = dayToDisplay.Date.AddDays(-1);
            if (daysRepository.HasDay(dateOfDayBefore))
            {
                Day dayBefore = daysRepository.Get(dateOfDayBefore);
                int daysSinceDayBefore = GetDaysBetweenDates(dateOfDayBefore, currentUser.JoinDate);

                DisplayDayData(dayBefore, daysSinceDayBefore);
            }
            else
            {
                
            }
        }

        private void SaveDay(object sender, EventArgs e)
        {
            dayToDisplay = daysService.UpdateExistingDay(dayToDisplay.Id, view.Thoughts);
            daysRepository.Update(dayToDisplay);
        //    historyService.AddHistoryEvent();
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

        public int GetDaysBetweenDates(DateTime newerDate, DateTime olderDate)
        {
            double daysBetweenDates = (newerDate - olderDate).TotalDays;
            return (int) daysBetweenDates;
        }
    }
}
