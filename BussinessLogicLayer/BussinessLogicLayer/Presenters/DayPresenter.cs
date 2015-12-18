using System;
using System.Linq;
using BussinessLogicLayer.Interfaces;
using DataAccessLayer.Repositories.Interfaces;
using DataAccessLayer.Services.Interfaces;
using DataAccessLayer.Utilities;
using Model.Entities;
using Model.Enums;
using Utilities;

namespace BussinessLogicLayer.Presenters
{
    public class DayPresenter : IPresenter
    {
        private readonly IDayView view;
        private readonly IDaysRepository daysRepository;
        private readonly IProfileRepository profileRepository;
        private readonly IDaysService daysService;
        private readonly IImprovementsService improvementsService;
        private readonly IProfileService profileService;

        private Day dayBeingDisplayed;
        private Profile currentUser;

        public DayPresenter(IDayView view, IDaysRepository daysRepository, IProfileRepository profileRepository, IDaysService daysService, IImprovementsService improvementsService, IProfileService profileService)
        {
            this.view = view;
            this.daysRepository = daysRepository;
            this.profileRepository = profileRepository;
            this.daysService = daysService;
            this.improvementsService = improvementsService;
            this.profileService = profileService;
        }

        public void Initialize()
        {
            try
            {
                AttachEvents();

                currentUser = GetCurrentUser();
                view.DaySelectorMinDate = currentUser.JoinDate.Date;
                view.DaySelectorMaxDate = DateTime.Now.Date.AddDays(1).AddMilliseconds(-1);

                dayBeingDisplayed = daysRepository.GetByDate(currentUser.Id, DateTime.Now);
                if (dayBeingDisplayed == null)
                {
                    dayBeingDisplayed = daysService.CreateNewDay(currentUser.Id, DateTime.Now, view.Thoughts);
                }

                DisplayDayData(dayBeingDisplayed, currentUser.GetDaysSinceFirstDay());

                SetDisplayMode(DisplayMode.View);
                ShowNextPreviousDayButtons(currentUser.GetDaysSinceFirstDay());
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
            view.SaveDayChanges += SaveDayChanges;
            view.EditDay += EditDay;
            view.DateChanged += SelectedDateChanged;
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

            if (daysSinceFirstDay >= 1)
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

        private Day GetDayOrCreateNew(DateTime date)
        {
            Day day = null;

            if (daysRepository.HasDay(currentUser.Id, date))
                day = daysRepository.GetByDate(currentUser.Id, date);
            else
                day = daysService.CreateNewDay(currentUser.Id, date);

            return day;
        }

        #region Events

        private void ShowNextDay(object sender, EventArgs e)
        {
            DateTime dateOfDayAhead = dayBeingDisplayed.Date.AddDays(1);
            dayBeingDisplayed = GetDayOrCreateNew(dateOfDayAhead);
            int daysSinceDayAhead = GetDaysBetweenDates(dateOfDayAhead, currentUser.JoinDate);

            DisplayDayData(dayBeingDisplayed, daysSinceDayAhead);
            ShowNextPreviousDayButtons(currentUser.GetDaysSinceFirstDay(dateOfDayAhead));
        }

        private void ShowPreviousDay(object sender, EventArgs e)
        {
            DateTime dateOfDayBefore = dayBeingDisplayed.Date.AddDays(-1);
            dayBeingDisplayed = GetDayOrCreateNew(dateOfDayBefore);
            int daysSinceDayBefore = GetDaysBetweenDates(dateOfDayBefore, currentUser.JoinDate);

            DisplayDayData(dayBeingDisplayed, daysSinceDayBefore);
            ShowNextPreviousDayButtons(currentUser.GetDaysSinceFirstDay(dateOfDayBefore));
        }

        private void SelectedDateChanged(object sender, DateTime selectedDate)
        {
            dayBeingDisplayed = GetDayOrCreateNew(selectedDate);
            int dayNumber = GetDaysBetweenDates(selectedDate, currentUser.JoinDate);

            DisplayDayData(dayBeingDisplayed, dayNumber);
            ShowNextPreviousDayButtons(currentUser.GetDaysSinceFirstDay(selectedDate));
        }

        private void SaveDayChanges(object sender, EventArgs e)
        {
            int writtenWordsCount = view.Thoughts.Count(Char.IsWhiteSpace);
            
            // Diary entry for such day already exists - updating
            if (daysRepository.HasDay(currentUser.Id, dayBeingDisplayed.Date))
            {
                Day dayBeforeEdit = daysRepository.Get(dayBeingDisplayed.Id);
                int previousWordsCount = writtenWordsCount - dayBeforeEdit.Thoughts.Count(Char.IsWhiteSpace);
                writtenWordsCount = previousWordsCount;

                dayBeingDisplayed = daysService.UpdateExistingDay(dayBeingDisplayed.Id, view.Thoughts);
                daysRepository.Update(dayBeingDisplayed);
            }
            // Saving diary entry for the first time for such day
            else
            {
                dayBeingDisplayed.Thoughts = view.Thoughts;
                daysService.SaveDay(dayBeingDisplayed);
            }

            // If user wrote at least '20' words, give him XP for this
            if (writtenWordsCount > ExperienceDefaultValues.MinimumDiaryEntryWords)
            {
                double baseXpForDiaryUpdate = (double)writtenWordsCount / ExperienceDefaultValues.DiaryEntryxWordsFor1XP;
                double randomMultiplier = Dice.Roll(ExperienceDefaultValues.DiaryUpdateRandomMin, ExperienceDefaultValues.DiaryUpdateRandomMax);

                int xpForDiaryUpdate = (int)(baseXpForDiaryUpdate*randomMultiplier);
                int ownerId = dayBeingDisplayed.Owner.Id;

                Improvement improvement = improvementsService.CreateNewImprovement(ownerId, ImprovementType.ExperienceGained, ImprovementOrigin.DiaryUpdate, xpForDiaryUpdate, dayBeingDisplayed.Id);
                improvementsService.SaveImprovement(improvement);
                profileService.UserGainedExperience(dayBeingDisplayed.Owner.Id, xpForDiaryUpdate);
            }

            SetDisplayMode(DisplayMode.View);
            ShowNextPreviousDayButtons(currentUser.GetDaysSinceFirstDay(dayBeingDisplayed.Date));
        }

        private void EditDay(object sender, EventArgs e)
        {
            SetDisplayMode(DisplayMode.Edit);
        }

        #endregion

        public void OnViewDisplayed()
        {
            // TODO
        }
    }
}
