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
    public class ImprovementsRepository : IImprovementsRepository
    {
        private readonly EntitiesContext context;

        public ImprovementsRepository()
        {
            context = new EntitiesContext();
        }

        public ImprovementsRepository(String connectionString)
        {
            context = new EntitiesContext(connectionString);
            context.Database.Connection.Open();
        }
        
        public void Add(Improvement improvement)
        {
            using (EntitiesContext entities = new EntitiesContext())
            {
                entities.Improvements.Add(improvement);
                entities.Entry(improvement).State = EntityState.Added;

                if (improvement.Owner != null)
                    entities.Entry(improvement.Owner).State = EntityState.Unchanged;

                if(improvement.AssociatedSkill != null)
                    entities.Entry(improvement.AssociatedSkill).State = EntityState.Unchanged;

                entities.SaveChanges();
            }
        }

        public void Update(Improvement improvement)
        {
            using (EntitiesContext entities = new EntitiesContext())
            {
                var oldImprovement = entities.Improvements.Find(improvement.Id);
                entities.Improvements.Attach(oldImprovement);
                entities.Entry(oldImprovement).CurrentValues.SetValues(improvement);
                entities.Entry(oldImprovement).State = EntityState.Modified;
                entities.SaveChanges();
            }
        }

        public void Delete(Improvement improvement)
        {
            using (var entities = new EntitiesContext())
            {
                entities.Improvements.Remove(improvement);
                entities.Entry(improvement).State = EntityState.Deleted;
                entities.SaveChanges();
            }
        }

        public Improvement Get(int improvementId)
        {
            return context.Improvements.AsNoTracking().First(d => d.Id == improvementId);
        }
        
        public IEnumerable<Improvement> Find(Expression<Func<Improvement, bool>> where)
        {
            return context.Improvements.AsNoTracking().Where(@where);
        }

        public Improvement First(Expression<Func<Improvement, bool>> where)
        {
            return context.Improvements.AsNoTracking().First(@where);
        }

        public IEnumerable<Improvement> GetAll()
        {
            return context.Improvements.AsNoTracking();
        }

        public Improvement Single(Expression<Func<Improvement, bool>> where)
        {
            return context.Improvements.AsNoTracking().Single(@where);
        }
    }
}
