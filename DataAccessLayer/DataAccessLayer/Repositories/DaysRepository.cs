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
        private EntitiesContext context;

        public DaysRepository(String connectionString)
        {
            context = new EntitiesContext(connectionString);
            context.Database.Connection.Open();
        }

        public Day Get(int dayId)
        {
            return context.Days.First(d => d.Id == dayId);
        }

        public DaysRepository()
        {
            context = new EntitiesContext();
            context.Database.Connection.Open();
        }

        public void Add(Day day)
        {
            using (var entities = new EntitiesContext())
            {
                entities.Days.Add(day);
                entities.Entry(day).State = EntityState.Added;
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

        public void Update(Day day)
        {
            using (EntitiesContext entities = new EntitiesContext())
            {
                entities.Days.Attach(day);
                entities.Entry(day).State = EntityState.Modified;
                entities.SaveChanges();
            }
        }

        public Day Get(DateTime date)
        {
            var days = GetAll();
            foreach (var day in days)
            {
                if (day.Date.Date == date.Date)
                {
                    return day;
                }
            }
            return null;
}

        public bool HasDay(DateTime dateOfDay)
        {
            if (Get(dateOfDay) == null)
                return false;
            else
            {
                return true;
            }
        }
    }
}
