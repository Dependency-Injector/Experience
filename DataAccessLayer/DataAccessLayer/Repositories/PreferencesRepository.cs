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

        public Preferences Get(int preferencesId)
        {
            return context.Preferences.AsNoTracking().FirstOrDefault(p => p.Id == preferencesId);
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
            return context.Preferences.AsNoTracking().FirstOrDefault(where);
        }

        public void Delete(Preferences day)
        {
            throw new NotImplementedException();
        }

        public void Add(Preferences preferences)
        {
            using (EntitiesContext entities = new EntitiesContext())
            {
                entities.Preferences.Add(preferences);
                entities.Entry(preferences).State = EntityState.Added;

                if(preferences.Owner != null)
                    entities.Entry(preferences.Owner).State = EntityState.Unchanged;

                entities.SaveChanges();
            }
        }

        public void Update(Preferences preferences)
        {
            using (EntitiesContext entitites = new EntitiesContext())
            {
                var oldPreferences = entitites.Preferences.Find(preferences.Id);
                entitites.Preferences.Attach(oldPreferences);

                entitites.Entry(oldPreferences).CurrentValues.SetValues(preferences);
                
                entitites.Entry(oldPreferences).State = EntityState.Modified;
                entitites.SaveChanges();


            } 
        }
        
        public IEnumerable<Preferences> GetAll()
        {
            return context.Preferences.AsNoTracking();
        }
    }
}
