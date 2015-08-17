using System;
using DataAccessLayer.Repositories;
using Model.Entities;
using Model.Enums;

namespace DataAccessLayer.Services
{
    public class HistoryService
    {
        private HistoryEventsRepository historyRepository;

        public HistoryService()
        {
            historyRepository = new HistoryEventsRepository();
        }

        public void AddHistoryEvent(HistoryEventType type, int? associatedEntityId = null, String description = "")
        {
            HistoryEvent historyEvent = new HistoryEvent();
            historyEvent.Occured = DateTime.Now;
            historyEvent.Type = type;

            if(!String.IsNullOrEmpty(description))
                historyEvent.Description = description;

            if (associatedEntityId.HasValue)
                historyEvent.AssociatedEntityId = associatedEntityId.Value;

            historyRepository.Add(historyEvent);
        }
    }
}
