using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Model.Entities;

namespace DataAccessLayer.Repositories.Interfaces
{
    public interface IJournalRepository : IRepository<Day>
    {
        Day First(Expression<Func<Day, bool>> where);
        Day Single(Expression<Func<Day, bool>> where);
        Day Get(int dayId);
        Day GetByDate(int ownerId, DateTime date);
        IEnumerable<Day> GetAll();
        IEnumerable<Day> Find(Expression<Func<Day, bool>> where);
        void Add(Day day);
        void Delete(Day day);
        void Update(Day day);
        bool HasDay(int ownerId, DateTime dateOfDay);
    }
}
