using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Model.Entities;

namespace DataAccessLayer.Repositories.Interfaces
{
    public interface IPreferencesRepository : IRepository<Preferences>
    {
        void Add(Preferences entity);
        void Delete(Preferences day);
        IEnumerable<Preferences> Find(Expression<Func<Preferences, bool>> where);
        Preferences First(Expression<Func<Preferences, bool>> where);
        IEnumerable<Preferences> GetAll();
        Preferences Single(Expression<Func<Preferences, bool>> where);
        void Update(Preferences preferences);
    }
}