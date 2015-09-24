using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using BussinessLogicLayer.Interfaces;
using DataAccessLayer.Repositories.Interfaces;
using DataAccessLayer.Utilities;
using Model.Entities;
using Model.Enums;
using Utilities;

namespace BussinessLogicLayer.Presenters
{
    public class HistoryPresenter
    {
        private readonly IHistoryView view;
        private readonly IHistoryEventsRepository historyRepository;
        private readonly IProfileRepository profilesRepository;
        private Profile currentUser;
         
        public HistoryPresenter(IHistoryView view, IHistoryEventsRepository historyEventsRepository, IProfileRepository profilesRepository)
        {
            this.view = view;
            this.historyRepository = historyEventsRepository;
            this.profilesRepository = profilesRepository;

            Initialize();
        }

        private void Initialize()
        {
            try
            {
                if (ApplicationSettings.Current.IsAnyUserLoggedIn && ApplicationSettings.Current.CurrentUserId.HasValue)
                {
                    currentUser = profilesRepository.Get(ApplicationSettings.Current.CurrentUserId.Value);
                    
                    AttachEvents();
                    GetAndDisplayHistoryEventsList();
                }
            }
            catch (Exception e)
            {
                Logger.Exception(e);
            }
        }

        private void GetAndDisplayHistoryEventsList()
        {
            var historyEvents = ObtainHistoryEvents();
            List<HistoryEvent> historyEventsList = SelectWantedHistoryEvents(historyEvents, view.DisplayExperienceEvents, view.DisplayTaskEvents, view.DisplayWorkUnitEvents);
            DisplayHistoryEvents(historyEventsList);
        }

        private List<HistoryEvent> SelectWantedHistoryEvents(IEnumerable<HistoryEvent> events, bool showExperienceEvents, bool showTaskEvents, bool showWorkUnitsEvents)
        {
            if (!showExperienceEvents)
            {
                events = events.Where(
                    e =>
                        e.Type != HistoryEventType.ExperienceGained &&
                        e.Type != HistoryEventType.SkillExperienceGained &&
                        e.Type != HistoryEventType.LevelGained &&
                        e.Type != HistoryEventType.SkillLevelGained);
            }

            if (!showTaskEvents)
            {
                events = events.Where(
                   e =>
                       e.Type != HistoryEventType.TaskCreated &&
                       e.Type != HistoryEventType.TaskEdited &&
                       e.Type != HistoryEventType.TaskFinished &&
                       e.Type != HistoryEventType.TaskRemoved);
            }

            if (!showWorkUnitsEvents)
            {
                events = events.Where(
                   e =>
                       e.Type != HistoryEventType.WorkStarted &&
                       e.Type != HistoryEventType.WorkStopped);
            }

            return events.ToList();
        }

        private void AttachEvents()
        {
            view.ShowHideExperienceEvents += ViewOnShowHideExperienceEvents;
            view.ShowHideTaskEvents += ViewOnShowHideTaskEvents;
            view.ShowHideWorkUnitEvents += ViewOnShowHideWorkUnitEvents;
            view.ShowHideProfileAndSkillEvents += ViewOnShowHideProfileAndSkillEvents;
        }

        private void ViewOnShowHideProfileAndSkillEvents(object sender, EventArgs eventArgs)
        {
            GetAndDisplayHistoryEventsList();
        }

        private void ViewOnShowHideWorkUnitEvents(object sender, EventArgs args)
        {
            GetAndDisplayHistoryEventsList();
        }

        private void ViewOnShowHideTaskEvents(object sender, EventArgs args)
        {
            GetAndDisplayHistoryEventsList();
        }

        private void ViewOnShowHideExperienceEvents(object sender, EventArgs args)
        {
            GetAndDisplayHistoryEventsList();
        }

        private void DisplayHistoryEvents(List<HistoryEvent> historyEvents)
        {
            view.HistoryEventsRows = GetHistoryEventsInRows(historyEvents);
        }

        private IEnumerable<HistoryEvent> ObtainHistoryEvents()
        {
            return historyRepository.Find(e => e.Owner.Id == currentUser.Id);
        }

        private ICollection GetHistoryEventsInRows(List<HistoryEvent> historyEvents)
        {
            List<string[]> historyEventsInRows = new List<string[]>();

            foreach (var historyEvent in historyEvents)
            {
                String whenOccured = historyEvent.Occured.ToString("M");
                String whatHappened = historyEvent.Type.ToString();
                String description = historyEvent.Description;
                
                string[] historyEventRow = new string[]
                {
                    $"{whenOccured}",
                    $"{whatHappened}",
                    $"{description}"
                };

                historyEventsInRows.Add(historyEventRow);
            }

            return historyEventsInRows;
        }
    }
}
