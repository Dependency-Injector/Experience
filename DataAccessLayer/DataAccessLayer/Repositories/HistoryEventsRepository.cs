using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Model;
using Model.Entities;

namespace DataAccessLayer.Repositories
{
    public class HistoryEventsRepository : IRepository<HistoryEvent>
    {
        private readonly EntitiesContext context;

        public HistoryEventsRepository()
        {
            context = new EntitiesContext();
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

        public void Delete(HistoryEvent entity)
        {
            throw new NotImplementedException();
        }

        public void Add(HistoryEvent historyEvent)
        {
            using (EntitiesContext context = new EntitiesContext())
            {
                context.HistoryEvents.Add(historyEvent);
                context.Entry(historyEvent).State = EntityState.Added;
                
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
