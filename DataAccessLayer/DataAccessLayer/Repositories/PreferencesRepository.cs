using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
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
            using (EntitiesContext context = new EntitiesContext())
            {
                context.Preferences.Attach(preferences);
                context.Entry(preferences).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
        
        public IEnumerable<Preferences> GetAll()
        {
            return context.Preferences.AsNoTracking();
        }
    }
}
