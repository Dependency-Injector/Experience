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
    public class WorkUnitsRepository : IWorkUnitsRepository
    {
        private readonly EntitiesContext context;

        public WorkUnitsRepository()
        {
            context = new EntitiesContext();
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
                entities.WorkUnits.Add(workUnit);
                entities.Entry(workUnit).State = EntityState.Added;
                
                if(workUnit.Task != null)
                    entities.Entry(workUnit.Task).State = EntityState.Unchanged;
                
                entities.SaveChanges();
            }
        }

        public void Update(WorkUnit workUnit)
        {
            using (EntitiesContext entities = new EntitiesContext())
            {
                entities.WorkUnits.Attach(workUnit);
                entities.Entry(workUnit).State = EntityState.Modified;
                entities.Entry(workUnit.Task).State = EntityState.Modified;
                entities.SaveChanges();
            }
        }

        public void Delete(WorkUnit day)
        {
            using (EntitiesContext entities = new EntitiesContext())
            {
                entities.WorkUnits.Attach(day);
                entities.WorkUnits.Remove(day);
                entities.Entry(day).State = EntityState.Deleted;
                entities.SaveChanges();
            }
        }

        public bool HasWorkUnits()
        {
            return context.WorkUnits.Any();
        }
    }
}
