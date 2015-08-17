using System;
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
            ObtainHistoryEvents();
            DisplayHistoryEvents();
        }

        private void DisplayHistoryEvents()
        {
            foreach (HistoryEvent evt in historyEvents)
            {
                
            }
        }

        private void ObtainHistoryEvents()
        {
            historyEvents = historyRepository.GetAll().ToList();
        }
    }
}
