using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Model.Entities;

namespace DataAccessLayer.Repositories.Interfaces
{
    public interface IWorkUnitsRepository : IRepository<WorkUnit>
    {
        void Add(WorkUnit workUnit);
        void Delete(WorkUnit day);
        IEnumerable<WorkUnit> Find(Expression<Func<WorkUnit, bool>> where);
        WorkUnit First(Expression<Func<WorkUnit, bool>> where);
        WorkUnit Get(int workUnitId);
        IEnumerable<WorkUnit> GetAll();
        bool HasWorkUnits();
        WorkUnit Single(Expression<Func<WorkUnit, bool>> where);
        void Update(WorkUnit workUnit);
    }
}