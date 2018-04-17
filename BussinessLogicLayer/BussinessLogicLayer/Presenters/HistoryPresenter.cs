using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using BussinessLogicLayer.Events;
using BussinessLogicLayer.GridRowTemplates;
using BussinessLogicLayer.Interfaces;
using DataAccessLayer.Repositories.Interfaces;
using DataAccessLayer.Utilities;
using Model.Entities;
using Model.Enums;
using Utilities;

namespace BussinessLogicLayer.Presenters
{
    public class HistoryPresenter : IPresenter
    {
        private readonly IHistoryView view;
        private readonly IHistoryEventsRepository historyRepository;
        private readonly IProfileRepository profilesRepository;

        private Profile currentUser;
        public event EventHandler<ShowNotificationEvent> NotificationAppeared;

        public HistoryPresenter(IHistoryView view, IHistoryEventsRepository historyEventsRepository, IProfileRepository profilesRepository)
        {
            this.view = view;
            this.historyRepository = historyEventsRepository;
            this.profilesRepository = profilesRepository;
        }

        #region Private methods

        public void Initialize()
        {
            try
            {
                AttachEvents();
                currentUser = profilesRepository.Get(Globals.DmitruUserId);
                GetAndDisplayHistoryEventsList();
            }
            catch (Exception e)
            {
                Logger.Exception(e);
            }
        }

        private void AttachEvents()
        {
            view.ShowHideExperienceEvents += ViewOnShowHideExperienceEvents;
            view.ShowHideTaskEvents += ViewOnShowHideTaskEvents;
            view.ShowHideWorkUnitEvents += ViewOnShowHideWorkUnitEvents;
            view.ShowHideProfileAndSkillEvents += ViewOnShowHideProfileAndSkillEvents;
        }

        private void GetAndDisplayHistoryEventsList()
        {
            var historyEvents = ObtainHistoryEvents();
            List<HistoryEvent> historyEventsList = FilterHistoryEvents(historyEvents, view.DisplayExperienceEvents,
                view.DisplayTaskEvents, view.DisplayWorkUnitEvents, view.DisplayProfileAndSkillsEvents);
            DisplayHistoryEvents(historyEventsList);
        }

        private IEnumerable<HistoryEvent> ObtainHistoryEvents()
        {
            return historyRepository.Find(e => e.Owner.Id == currentUser.Id);
        }
        
        private List<HistoryEvent> FilterHistoryEvents(IEnumerable<HistoryEvent> events, bool showExperienceEvents, bool showTaskEvents, bool showWorkUnitsEvents, bool showProfilenAndSkillsEvents)
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

            if (!showProfilenAndSkillsEvents)
            {
                events = events.Where(
                    e =>
                        e.Type != HistoryEventType.ProfileCreated &&
                        e.Type != HistoryEventType.ProfileEdited &&
                        e.Type != HistoryEventType.ProfileRemoved &&
                        e.Type != HistoryEventType.SkillCreated &&
                        e.Type != HistoryEventType.SkillEdited &&
                        e.Type != HistoryEventType.SkillRemoved);
            }

            return events.ToList();
        }

        private void DisplayHistoryEvents(List<HistoryEvent> historyEvents)
        {
            view.HistoryEventsGridItems = GetHistoryEventsGridItems(historyEvents);
        }

        private IList<HistoryEventGridItem> GetHistoryEventsGridItems(List<HistoryEvent> historyEvents)
        {
            List<HistoryEventGridItem> historyEventsGridItems = new List<HistoryEventGridItem>();

            foreach (var historyEvent in historyEvents)
            {
                String whenOccured = historyEvent.Occured.ToString("M");
                String whatHappened = historyEvent.Type.ToString();
                String description = historyEvent.Description;

                historyEventsGridItems.Add(new HistoryEventGridItem(whenOccured, whatHappened, description));
            }

            return historyEventsGridItems;
        }

        #endregion

        #region Event handlers

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

        public void OnViewDisplayed()
        {
            GetAndDisplayHistoryEventsList();
        }

        #endregion

    }
}
