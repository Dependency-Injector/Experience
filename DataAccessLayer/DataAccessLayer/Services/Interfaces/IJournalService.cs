using System;
using System.Collections.Generic;
using Model.Entities;

namespace DataAccessLayer.Services.Interfaces
{
    public interface IJournalService
    {
        Day CreateNewDay(int? ownerId, DateTime date);
        Day CreateNewDay(int? ownerId, DateTime date, string thoughts);
        void SaveDay(Day dayToSave);
        Day UpdateExistingDay(int dayId, string thoughts);
        IEnumerable<Day> GetDaysForUser(int id);
    }
}