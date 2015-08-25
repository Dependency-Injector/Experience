using System;
using BussinessLogicLayer.Interfaces;
using DataAccessLayer.Repositories;
using DataAccessLayer.Repositories.Interfaces;
using DataAccessLayer.Services;
using MetroFramework;
using Model.Entities;

namespace BussinessLogicLayer.Presenters
{
    public class DayPresenter
    {
        private readonly IDayView view;
        private readonly IDaysRepository daysRepository;
        private readonly DaysService daysService;
        private Day displayedDay;

        public DayPresenter(IDayView view, IDaysRepository daysRepository)
        {
            this.view = view;
            this.daysRepository = daysRepository;

            this.daysRepository = new DaysRepository();
            daysService = new DaysService();

            Initialize();
        }

        private void Initialize()
        {
            try
            {
                AttachEvents();
                displayedDay = daysRepository.Get(DateTime.Now);
                if (displayedDay != null)
                {
                    DisplayDayData(displayedDay);
                }
                else
                {
                    displayedDay = CreateNewDay(DateTime.Now);
                    daysRepository.Add(displayedDay);
                    DisplayDayData(displayedDay);
                }
            }
            catch (Exception e)
            {
                MetroMessageBox.Show(view.Window, e.Message);
            }
        }

        private void AttachEvents()
        {
            view.NewDay += NewDay;
            view.PreviousDay += PreviousDay;
            view.NextDay += NextDay;
            view.SaveDay += SaveDay;
            view.NewDay += NewDay;
        }

        private void NextDay(object sender, EventArgs e)
        {
            DateTime dateOfDayAhead = displayedDay.Date.AddDays(+1);
            if (daysRepository.HasDay(dateOfDayAhead))
            {
                Day dayAhead = daysRepository.Get(dateOfDayAhead);
                DisplayDayData(dayAhead);
            }
            else
            {

            }
        }

        private void PreviousDay(object sender, EventArgs e)
        {
            DateTime dateOfDayBefore = displayedDay.Date.AddDays(-1);
            if (daysRepository.HasDay(dateOfDayBefore))
            {
                Day dayBefore = daysRepository.Get(dateOfDayBefore);
                DisplayDayData(dayBefore);
            }
            else
            {
                
            }
        }

        private void SaveDay(object sender, EventArgs e)
        {
            displayedDay = daysService.UpdateExistingDay(displayedDay.Id, view.Thoughts);
            daysRepository.Update(displayedDay);
        //    historyService.AddHistoryEvent();
        }

        private void NewDay(object sender, EventArgs e)
        {
            
        }

        private Day CreateNewDay(DateTime when)
        {
            Day newDay = new Day();
            newDay.Date = when;
            newDay.Thoughts = String.Empty;
            return newDay;
        }

        private void DisplayDayData(Day day)
        {
            view.Date = day.Date;
            view.Thoughts = day.Thoughts;
        }
    }
}
