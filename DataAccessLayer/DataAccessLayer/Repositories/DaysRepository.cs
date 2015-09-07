using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using DataAccessLayer.Repositories.Interfaces;
using Model;
using Model.Entities;

namespace DataAccessLayer.Repositories
{
    public class DaysRepository : IDaysRepository
    {
        private readonly EntitiesContext context;

        public DaysRepository(String connectionString)
        {
            context = new EntitiesContext(connectionString);
            context.Database.Connection.Open();
        }

        public DaysRepository()
        {
            context = new EntitiesContext();
            context.Database.Connection.Open();
        }

        public void Add(Day day)
        {
            using (EntitiesContext entities = new EntitiesContext())
            {
                entities.Days.Add(day);
                entities.Entry(day).State = EntityState.Added;

                if (day.Owner != null)
                    entities.Entry(day.Owner).State = EntityState.Unchanged;

                entities.SaveChanges();
            }
        }

        public void Update(Day day)
        {
            using (EntitiesContext entities = new EntitiesContext())
            {
                var oldDay = entities.Days.Find(day.Id);
                entities.Days.Attach(oldDay);
                entities.Entry(oldDay).CurrentValues.SetValues(day);
                entities.Entry(oldDay).State = EntityState.Modified;
                entities.SaveChanges();
            }
        }

        public void Delete(Day day)
        {
            using (var entities = new EntitiesContext())
            {
                entities.Days.Remove(day);
                entities.Entry(day).State = EntityState.Deleted;
                entities.SaveChanges();
            }
        }

        public Day Get(int dayId)
        {
            return context.Days.AsNoTracking().First(d => d.Id == dayId);
        }

        public Day GetByDate(int ownerId, DateTime date)
        {
            var days = Find(d => d.Owner.Id == ownerId);
            foreach (var day in days)
            {
                if (day.Date.Date == date.Date)
                {
                    return day;
                }
            }
            return null;
        }

        public IEnumerable<Day> Find(Expression<Func<Day, bool>> where)
        {
            return context.Days.AsNoTracking().Where(@where);
        }

        public Day First(Expression<Func<Day, bool>> where)
        {
            return context.Days.AsNoTracking().First(@where);
        }

        public IEnumerable<Day> GetAll()
        {
            return context.Days.AsNoTracking();
        }

        public Day Single(Expression<Func<Day, bool>> where)
        {
            return context.Days.AsNoTracking().Single(@where);
        }

        public bool HasDay(int ownerId, DateTime dateOfDay)
        {
            if (GetByDate(ownerId, dateOfDay) == null)
                return false;
            else
            {
                return true;
            }
        }
    }
}
