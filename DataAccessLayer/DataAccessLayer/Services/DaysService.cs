﻿using System;
using DataAccessLayer.Repositories;
using Model.Entities;
using Model.Enums;

namespace DataAccessLayer.Services
{
    public class DaysService
    {
        private DaysRepository daysRepository;
        private ProfileRepository profileRepository;
        private HistoryService historyService;

        public DaysService()
        {
            daysRepository = new DaysRepository();
            profileRepository = new ProfileRepository();
            historyService = new HistoryService();
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
            historyService.AddHistoryEvent(HistoryEventType.DaySaved, dayToSave.Id);
        }

        public Day UpdateExistingDay(int dayId, string thoughts)
        {
            Day day = daysRepository.Get(dayId);
            day.Thoughts = thoughts;

            historyService.AddHistoryEvent(HistoryEventType.DayUpdated, day.Id);

            return day;
        }
    }
}
