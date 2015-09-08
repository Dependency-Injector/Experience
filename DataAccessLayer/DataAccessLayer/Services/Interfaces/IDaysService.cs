using System;
using Model.Entities;

namespace DataAccessLayer.Services.Interfaces
{
    public interface IDaysService
    {
        Day CreateNewDay(int? ownerId, DateTime date);
        Day CreateNewDay(int? ownerId, DateTime date, string thoughts);
        void SaveDay(Day dayToSave);
        Day UpdateExistingDay(int dayId, string thoughts);
    }
}