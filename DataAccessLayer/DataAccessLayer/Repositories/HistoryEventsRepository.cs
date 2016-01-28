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
    public class HistoryEventsRepository : IHistoryEventsRepository
    {
        private readonly EntitiesContext context;

        public HistoryEventsRepository()
        {
            context = new EntitiesContext();
        }
        public HistoryEventsRepository(String connectionString)
        {
            context = new EntitiesContext(connectionString);
            context.Database.Connection.Open();
        }
        
        public IEnumerable<HistoryEvent> Find(Expression<Func<HistoryEvent, bool>> @where)
        {
            return context.HistoryEvents.AsNoTracking().Where(where);
        }

        public HistoryEvent Single(Expression<Func<HistoryEvent, bool>> @where)
        {
            return context.HistoryEvents.AsNoTracking().Single(where);
        }

        public HistoryEvent First(Expression<Func<HistoryEvent, bool>> @where)
        {
            return context.HistoryEvents.AsNoTracking().First(where);
        }

        public void Delete(HistoryEvent historyEvent)
        {
            using (var entities = new EntitiesContext())
            {
                entities.HistoryEvents.Remove(historyEvent);
                entities.Entry(historyEvent).State = EntityState.Deleted;
                entities.SaveChanges();
            }
        }

        public void Add(HistoryEvent historyEvent)
        {
            using (EntitiesContext context = new EntitiesContext())
            {
                context.HistoryEvents.Add(historyEvent);
                context.Entry(historyEvent).State = EntityState.Added;

                if (historyEvent.Owner != null)
                    context.Entry(historyEvent.Owner).State = EntityState.Unchanged;

                context.SaveChanges();
            }
        }

        public void Update(HistoryEvent HistoryEvent)
        {
            using (EntitiesContext context = new EntitiesContext())
            {
                context.HistoryEvents.Attach(HistoryEvent);
                context.Entry(HistoryEvent).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public IEnumerable<HistoryEvent> GetAll()
        {
            return context.HistoryEvents.AsNoTracking();
        }
    }
}
