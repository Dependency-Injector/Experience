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
    public class ProfileRepository : IProfileRepository
    {
        private readonly EntitiesContext context;

        public ProfileRepository(String connectionString)
        {
            context = new EntitiesContext(connectionString);
            context.Database.Connection.Open();
        }

        public ProfileRepository()
        {
            context = new EntitiesContext();
            context.Database.Connection.Open();    
        }

        public IEnumerable<Profile> GetAll()
        {
            return context.Profiles.AsNoTracking();
        }

        public IEnumerable<Profile> Find(Expression<Func<Profile, bool>> @where)
        {
            return context.Profiles.AsNoTracking().Where(@where);
        }

        public Profile Single(Expression<Func<Profile, bool>> @where)
        {
            return context.Profiles.AsNoTracking().Single(@where);
        }

        public Profile First(Expression<Func<Profile, bool>> @where)
        {
            return context.Profiles.AsNoTracking().FirstOrDefault(@where);
        }

        public void Delete(Profile profile)
        {
            using (var entities = new EntitiesContext())
            {
                entities.Profiles.Remove(profile);
                entities.Entry(profile).State = EntityState.Deleted;
                entities.SaveChanges();
            }
        }

        public void Add(Profile profile)
        {
            using (EntitiesContext entities = new EntitiesContext())
            {
                entities.Profiles.Add(profile);
                entities.Entry(profile).State = EntityState.Added;
                entities.SaveChanges();
            }
        }

        public void Update(Profile profile)
        {
            using (EntitiesContext context = new EntitiesContext())
            {
                context.Profiles.Attach(profile);
                context.Entry(profile).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public bool HasProfile()
        {
            return context.Profiles.AsNoTracking().Any();
        }

        public Profile Get(int profileId)
        {
            return context.Profiles.AsNoTracking().FirstOrDefault(p => p.Id == profileId);
        }
    }
}
