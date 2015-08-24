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
    public class SkillsRepository : IRepository<Skill>
    {
        private readonly EntitiesContext context;

        public SkillsRepository()
        {
            context = new EntitiesContext();
            context.Database.Connection.Open();    
        }

        public SkillsRepository(string connectionString)
        {
            context = new EntitiesContext(connectionString);
            context.Database.Connection.Open();
        }

        public IEnumerable<Skill> Find(Expression<Func<Skill, bool>> @where)
        {
            throw new NotImplementedException();
        }

        public Skill Single(Expression<Func<Skill, bool>> @where)
        {
            throw new NotImplementedException();
        }

        public Skill First(Expression<Func<Skill, bool>> @where)
        {
            return context.Skills.AsNoTracking().First(where);
        }

        public void Delete(Skill day)
        {
            throw new NotImplementedException();
        }

        public void Add(Skill entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Skill skill)
        {
            using (EntitiesContext context = new EntitiesContext())
            {
                context.Skills.Attach(skill);
                context.Entry(skill).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
        
        public IEnumerable<Skill> GetAll()
        {
            return context.Skills.AsNoTracking();
        }
    }
}
