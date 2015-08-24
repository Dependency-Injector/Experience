using System;
using System.Linq;
using BussinessLogicLayer.Interfaces;
using DataAccessLayer.Repositories;
using DataAccessLayer.Services;
using MetroFramework;
using Model.Entities;

namespace BussinessLogicLayer.Presenters
{
    public class DayPresenter
    {
        private readonly IDayView view;
        private DayRepository dayRepository;
        private DaysService daysService;
        private Day displayedDay;

        public DayPresenter(IDayView view)
        {
            this.view = view;
            dayRepository = new DayRepository();
            daysService = new DaysService();

            Initialize();
        }

        private void Initialize()
        {
            try
            {
                AttachEvents();
                displayedDay = dayRepository.Get(DateTime.Now);
                if (displayedDay != null)
                {
                    DisplayDayData(displayedDay);
                }
                else
                {
                    displayedDay = CreateNewDay(DateTime.Now);
                    dayRepository.Add(displayedDay);
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
            if (dayRepository.HasDay(dateOfDayAhead))
            {
                Day dayAhead = dayRepository.Get(dateOfDayAhead);
                DisplayDayData(dayAhead);
            }
            else
            {

            }
        }

        private void PreviousDay(object sender, EventArgs e)
        {
            DateTime dateOfDayBefore = displayedDay.Date.AddDays(-1);
            if (dayRepository.HasDay(dateOfDayBefore))
            {
                Day dayBefore = dayRepository.Get(dateOfDayBefore);
                DisplayDayData(dayBefore);
            }
            else
            {
                
            }
        }

        private void SaveDay(object sender, EventArgs e)
        {
            displayedDay = daysService.UpdateExistingDay(displayedDay.Id, view.Thoughts);
            dayRepository.Update(displayedDay);
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
