using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using BussinessLogicLayer.Interfaces;
using DataAccessLayer.Repositories.Interfaces;
using Model.Entities;

namespace BussinessLogicLayer.Presenters
{
    public class HistoryPresenter
    {
        private readonly IHistoryView view;
        private readonly IHistoryEventsRepository historyRepository;
        private List<HistoryEvent> historyEvents;
         
        public HistoryPresenter(IHistoryView view, IHistoryEventsRepository historyEventsRepository)
        {
            this.view = view;
            this.historyRepository = historyEventsRepository;

            Initialize();
        }

        private void Initialize()
        {
            historyEvents = ObtainHistoryEvents();
            DisplayHistoryEvents(this.historyEvents);
        }

        private void DisplayHistoryEvents(List<HistoryEvent> historyEvents)
        {
            view.HistoryEventsRows = GetHistoryEventsInRows(historyEvents);
        }

        private List<HistoryEvent> ObtainHistoryEvents()
        {
            return historyRepository.GetAll().ToList();
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
