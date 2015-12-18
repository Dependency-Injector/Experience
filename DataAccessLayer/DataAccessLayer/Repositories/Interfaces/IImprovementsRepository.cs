using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Model.Entities;

namespace DataAccessLayer.Repositories.Interfaces
{
    public interface IImprovementsRepository : IRepository<Improvement>
    {
        Improvement First(Expression<Func<Improvement, bool>> where);
        Improvement Single(Expression<Func<Improvement, bool>> where);
        Improvement Get(int improvementId);
        IEnumerable<Improvement> GetAll();
        IEnumerable<Improvement> Find(Expression<Func<Improvement, bool>> where);
        void Add(Improvement Improvement);
        void Delete(Improvement Improvement);
        void Update(Improvement Improvement);
    }
}
