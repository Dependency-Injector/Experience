using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Model.Entities;

namespace DataAccessLayer.Repositories.Interfaces
{
    public interface IHistoryEventsRepository : IRepository<HistoryEvent>
    {
        void Add(HistoryEvent historyEvent);
        void Delete(HistoryEvent day);
        IEnumerable<HistoryEvent> Find(Expression<Func<HistoryEvent, bool>> where);
        HistoryEvent First(Expression<Func<HistoryEvent, bool>> where);
        IEnumerable<HistoryEvent> GetAll();
        HistoryEvent Single(Expression<Func<HistoryEvent, bool>> where);
        void Update(HistoryEvent HistoryEvent);
    }
}