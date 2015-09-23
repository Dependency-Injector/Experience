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
    public class SkillsRepository : ISkillsRepository
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
            return context.Skills.AsNoTracking().Where(@where);
        }

        public Skill Single(Expression<Func<Skill, bool>> @where)
        {
            return context.Skills.AsNoTracking().Single(@where);
        }

        public Skill First(Expression<Func<Skill, bool>> @where)
        {
            return context.Skills.AsNoTracking().First(where);
        }

        public void Delete(Skill skill)
        {
            using (EntitiesContext entities = new EntitiesContext())
            {
                entities.Skills.Attach(skill);
                entities.Skills.Remove(skill);
                entities.Entry(skill).State = EntityState.Deleted;
                entities.SaveChanges();
            }
        }

        public void Add(Skill skill)
        {
            using (EntitiesContext entities = new EntitiesContext())
            {
                entities.Skills.Add(skill);
                entities.Entry(skill).State = EntityState.Added;
                
                if(skill.Owner != null)
                    entities.Entry(skill.Owner).State = EntityState.Unchanged;

                entities.SaveChanges();
            }
        }

        public void Update(Skill skill)
        {
            //TODO
            using (EntitiesContext entities = new EntitiesContext())
            {
                entities.Skills.Attach(skill);
                entities.Entry(skill).State = EntityState.Modified;
                entities.SaveChanges();
            }
        }
        
        public IEnumerable<Skill> GetAll()
        {
            return context.Skills.AsNoTracking();
        }

        public Skill Get(int skillId)
        {
            return First(s => s.Id == skillId);
        }
    }
}
