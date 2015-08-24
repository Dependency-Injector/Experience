using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessLogicLayer.Interfaces;
using DataAccessLayer.Repositories;
using Model.Entities;
using Model.Migrations;

namespace BussinessLogicLayer.Presenters
{
    public class HistoryPresenter
    {
        private readonly IHistoryView view;
        private HistoryEventsRepository historyRepository;
        private List<HistoryEvent> historyEvents;
         
        public HistoryPresenter(IHistoryView view)
        {
            this.view = view;
            historyRepository = new HistoryEventsRepository();

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
