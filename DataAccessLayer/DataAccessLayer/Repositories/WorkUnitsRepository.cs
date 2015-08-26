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
    public class WorkUnitsRepository : IRepository<WorkUnit>, IWorkUnitsRepository
    {
        private readonly EntitiesContext context;
        
        public WorkUnitsRepository()
        {
            context = new EntitiesContext();
            context.Database.Connection.Open();
        }
        public WorkUnitsRepository(string connectionString)
        {
            context = new EntitiesContext(connectionString);
            context.Database.Connection.Open();
        }

        public WorkUnit Get(int workUnitId)
        {
            return context.WorkUnits.AsNoTracking().FirstOrDefault(t => t.Id == workUnitId);
        }
        public IEnumerable<WorkUnit> GetAll()
        {
            return context.WorkUnits.AsNoTracking();
        }
        public IEnumerable<WorkUnit> Find(Expression<Func<WorkUnit, bool>> @where)
        {
            return context.WorkUnits.AsNoTracking().Where(where);
        }
        public WorkUnit Single(Expression<Func<WorkUnit, bool>> @where)
        {
            return context.WorkUnits.AsNoTracking().Single(where);
        }
        public WorkUnit First(Expression<Func<WorkUnit, bool>> @where)
        {
            return context.WorkUnits.AsNoTracking().First(where);
        }
        public void Add(WorkUnit workUnit)
        {
            using (EntitiesContext entities = new EntitiesContext())
            {
                
                for (int i = 0; i < workUnit.Task.WorkUnits.Count; i++)
                {
                    entities.Entry(workUnit.Task.WorkUnits.ElementAt(i)).State = EntityState.Unchanged;
                }

                entities.WorkUnits.Add(workUnit);
                entities.Entry(workUnit).State = EntityState.Added;
                entities.Entry(workUnit.Task).State = EntityState.Unchanged;
                
                entities.SaveChanges();
            }
        }
        public void Update(WorkUnit workUnit)
        {
            using (EntitiesContext context = new EntitiesContext())
            {
                context.WorkUnits.Attach(workUnit);
                context.Entry(workUnit).State = EntityState.Modified;
                context.Entry(workUnit.Task).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
        public void Delete(WorkUnit day)
        {
            using (EntitiesContext context = new EntitiesContext())
            {
                context.WorkUnits.Attach(day);
                context.WorkUnits.Remove(day);
                context.Entry(day).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public bool HasWorkUnits()
        {
            return context.WorkUnits.Any();
        }
    }
}
