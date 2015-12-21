using System;
using System.Collections.Generic;
using DataAccessLayer.Repositories.Interfaces;
using DataAccessLayer.Services.Interfaces;
using Model.Entities;

namespace DataAccessLayer.Services
{
    public class DaysService : IDaysService
    {
        private IDaysRepository daysRepository;
        private IProfileRepository profileRepository;
        
        public DaysService(IDaysRepository daysRepository, IProfileRepository profileRepository)
        {
            this.daysRepository = daysRepository;
            this.profileRepository = profileRepository;
        }

        public Day CreateNewDay(int? ownerId, DateTime date, String thoughts)
        {
            Day day = CreateNewDay(ownerId, date);
            day.Thoughts = thoughts;
            
            return day;
        }

        public Day CreateNewDay(int? ownerId, DateTime date)
        {
            Day day = new Day();
            day.Date = date;
            day.Thoughts = String.Empty;

            if (ownerId.HasValue)
            {
                day.Owner = profileRepository.Get(ownerId.Value);
                day.Number = day.Owner.GetDaysSinceFirstDay(day.Date);
            }

            return day;
        }

        public void SaveDay(Day dayToSave)
        {
            daysRepository.Add(dayToSave);
        }

        public Day UpdateExistingDay(int dayId, string thoughts)
        {
            Day day = daysRepository.Get(dayId);
            day.Thoughts = thoughts;
            return day;
        }

        public IEnumerable<Day> GetDaysForUser(int id)
        {
            return daysRepository.Find(d => d.Owner.Id == id);
        }
    }
}
