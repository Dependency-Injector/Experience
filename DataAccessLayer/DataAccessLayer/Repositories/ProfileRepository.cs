using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Model;

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
            throw new NotImplementedException();
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

        public void Update(Profile entity)
        {
            throw new NotImplementedException();
        }

        public bool HasProfile()
        {
            return context.Profiles.Any();
        }
    }
}
