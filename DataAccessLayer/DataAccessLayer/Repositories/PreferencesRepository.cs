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
    public class PreferencesRepository : IPreferencesRepository
    {
        private readonly EntitiesContext context;

        public PreferencesRepository()
        {
            context = new EntitiesContext();
            context.Database.Connection.Open();    
        }
        
        public IEnumerable<Preferences> Find(Expression<Func<Preferences, bool>> @where)
        {
            return context.Preferences.AsNoTracking().Where(where);
        }

        public Preferences Single(Expression<Func<Preferences, bool>> @where)
        {
            return context.Preferences.AsNoTracking().Single(where);
        }

        public Preferences First(Expression<Func<Preferences, bool>> @where)
        {
            return context.Preferences.AsNoTracking().First(where);
        }

        public void Delete(Preferences day)
        {
            throw new NotImplementedException();
        }

        public void Add(Preferences entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Preferences preferences)
        {
            using (EntitiesContext entitites = new EntitiesContext())
            {
                entitites.Preferences.Attach(preferences);
                entitites.Entry(preferences).State = EntityState.Modified;
                entitites.SaveChanges();
            }
        }
        
        public IEnumerable<Preferences> GetAll()
        {
            return context.Preferences.AsNoTracking();
        }
    }
}
