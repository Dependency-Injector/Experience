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
    public class ProfileRepository : IRepository<Profile>
    {
        private readonly EntitiesContext context;

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
            throw new NotImplementedException();
        }

        public Profile First(Expression<Func<Profile, bool>> @where)
        {
            throw new NotImplementedException();
        }

        public void Delete(Profile entity)
        {
            throw new NotImplementedException();
        }

        public void Add(Profile entity)
        {
            throw new NotImplementedException();
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
            return context.Profiles.Any();
        }
    }
}
