using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Repositories;
using Model;
using Model.Entities;

namespace BussinessLogicLayer.Presenters
{
    public class DayRepository : IRepository<Day>
    {
        private EntitiesContext entities;

        public DayRepository(String connectionString)
        {
            entities = new EntitiesContext(connectionString);
            entities.Database.Connection.Open();
        }

        internal Day Get(int dayId)
        {
            return entities.Days.First(d => d.Id == dayId);
        }

        public DayRepository()
        {
            entities = new EntitiesContext();
            entities.Database.Connection.Open();
         
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

        public void Delete(Day entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Day> Find(System.Linq.Expressions.Expression<Func<Day, bool>> where)
        {
            return entities.Days.AsNoTracking().Where(@where);
        }

        public Day First(System.Linq.Expressions.Expression<Func<Day, bool>> where)
        {
            return entities.Days.AsNoTracking().First(@where);
        }

        public IEnumerable<Day> GetAll()
        {
            return entities.Days.AsNoTracking();
        }

        public Day Single(System.Linq.Expressions.Expression<Func<Day, bool>> where)
        {
            return entities.Days.AsNoTracking().Single(@where);
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
