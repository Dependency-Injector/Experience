using System;
using BussinessLogicLayer.Interfaces;
using DataAccessLayer.Repositories.Interfaces;
using DataAccessLayer.Services;
using DataAccessLayer.Utilities;
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

        private Day dayBeingDisplayed;
        private Profile currentUser;

        public DayPresenter(IDayView view, IDaysRepository daysRepository, IProfileRepository profileRepository)
        {
            this.view = view;
            this.daysRepository = daysRepository;
            this.profileRepository = profileRepository;
            this.daysService = new DaysService();

            Initialize();
        }

        private void Initialize()
        {
            try
            {
                AttachEvents();

                if (ApplicationSettings.Current.IsAnyUserLoggedIn)
                {
                    currentUser = GetCurrentUser();

                    dayBeingDisplayed = daysRepository.GetByDate(currentUser.Id, DateTime.Now);
                    if (dayBeingDisplayed == null)
                    {
                        dayBeingDisplayed = daysService.CreateNewDay(currentUser.Id, DateTime.Now, view.Thoughts);
                    }

                    DisplayDayData(dayBeingDisplayed, currentUser.GetDaysSinceFirstDay());

                    ShowNextPreviousDayButtons(currentUser.GetDaysSinceFirstDay());
                    SetDisplayMode(DisplayMode.View);
                }
            }
            catch (Exception e)
            {
                Logger.Exception(e);
            }
        }

        private Profile GetCurrentUser()
        {
            Profile user = null;
            if (ApplicationSettings.Current.CurrentUserId.HasValue)
                user = profileRepository.Get(ApplicationSettings.Current.CurrentUserId.Value);

            return user;
        }

        private void AttachEvents()
        {
            view.ShowPreviousDay += ShowPreviousDay;
            view.ShowNextDay += ShowNextDay;
            view.SaveDay += SaveDay;
            view.SwitchDisplayMode += SwitchDisplayMode;
        }

        private void SetDisplayMode(DisplayMode displayMode)
        {
            if (displayMode == DisplayMode.Edit)
            {
                view.ShowEditButton = false;
                view.ShowSaveChangesButton = true;
                view.ThoughtsTextBoxEnabled = true;
                ShowPreviousDayButton(false);
                ShowNextDayButton(false);
            }
            else if (displayMode == DisplayMode.View)
            {
                view.ShowEditButton = true;
                view.ShowSaveChangesButton = false;
                view.ThoughtsTextBoxEnabled = false;
                ShowPreviousDayButton(true);
                ShowNextDayButton(true);
            }
        }

        private void ShowNextPreviousDayButtons(int daysSinceFirstDay)
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

        #region Events

        private void ShowNextDay(object sender, EventArgs e)
        {
            DateTime dateOfDayAhead = dayBeingDisplayed.Date.AddDays(1);
            if (daysRepository.HasDay(currentUser.Id, dateOfDayAhead))
                dayBeingDisplayed = daysRepository.GetByDate(currentUser.Id, dateOfDayAhead);
            else
                dayBeingDisplayed = daysService.CreateNewDay(currentUser.Id, dateOfDayAhead);
            int daysSinceDayAhead = GetDaysBetweenDates(dateOfDayAhead, currentUser.JoinDate);
           
            DisplayDayData(dayBeingDisplayed, daysSinceDayAhead);
            ShowNextPreviousDayButtons(currentUser.GetDaysSinceFirstDay(dateOfDayAhead));
        }

        private void ShowPreviousDay(object sender, EventArgs e)
        {
            DateTime dateOfDayBefore = dayBeingDisplayed.Date.AddDays(-1);
            if (daysRepository.HasDay(currentUser.Id, dateOfDayBefore))
                dayBeingDisplayed = daysRepository.GetByDate(currentUser.Id, dateOfDayBefore);
            else
                dayBeingDisplayed = daysService.CreateNewDay(currentUser.Id, dateOfDayBefore);
            int daysSinceDayBefore = GetDaysBetweenDates(dateOfDayBefore, currentUser.JoinDate);

            DisplayDayData(dayBeingDisplayed, daysSinceDayBefore);
            ShowNextPreviousDayButtons(currentUser.GetDaysSinceFirstDay(dateOfDayBefore));
        }

        private void SaveDay(object sender, EventArgs e)
        {
            if (daysRepository.HasDay(currentUser.Id, dayBeingDisplayed.Date))
            {
                dayBeingDisplayed = daysService.UpdateExistingDay(dayBeingDisplayed.Id, view.Thoughts);
                daysRepository.Update(dayBeingDisplayed);
            }
            else
            {
                dayBeingDisplayed.Thoughts = view.Thoughts;
                daysService.SaveDay(dayBeingDisplayed);
            }

            SetDisplayMode(DisplayMode.View);
        }

        private void SwitchDisplayMode(object sender, SwitchDisplayModeEventArgs e)
        {
            SetDisplayMode(e.DisplayMode);
        }

        #endregion

    }

    internal class UserNotLoggedException : Exception
    {
    }
}
