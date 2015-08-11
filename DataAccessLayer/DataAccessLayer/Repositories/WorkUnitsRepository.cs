using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using DataAccessLayer.Model;

namespace DataAccessLayer.Repositories
{
    public class WorkUnitsRepository : IRepository<WorkUnit>
    {
        private readonly EntitiesContext context;

        public WorkUnitsRepository()
        {
            context = new EntitiesContext();
            context.Database.Connection.Open();
        }

        public Task Get(int taskId)
        {
            return context.Tasks.AsNoTracking().First(t => t.Id == taskId);
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
            using (EntitiesContext context = new EntitiesContext())
            {
                context.WorkUnits.Add(workUnit);
                context.Entry(workUnit).State = EntityState.Added;
                context.Entry(workUnit.Task).State = EntityState.Modified;
                context.SaveChanges();
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
        public void Delete(WorkUnit workUnit)
        {
            using (EntitiesContext context = new EntitiesContext())
            {
                context.WorkUnits.Attach(workUnit);
                context.WorkUnits.Remove(workUnit);
                context.Entry(workUnit).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public bool HasWorkUnits()
        {
            return context.WorkUnits.Any();
        }
    }
}
