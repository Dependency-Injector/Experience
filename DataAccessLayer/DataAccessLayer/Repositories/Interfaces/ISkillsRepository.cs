using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Model.Entities;

namespace DataAccessLayer.Repositories.Interfaces
{
    public interface ISkillsRepository : IRepository<Skill>
    {
        void Add(Skill entity);
        void Delete(Skill day);
        IEnumerable<Skill> Find(Expression<Func<Skill, bool>> where);
        Skill First(Expression<Func<Skill, bool>> where);
        Skill Get(int skillId);
        IEnumerable<Skill> GetAll();
        Skill Single(Expression<Func<Skill, bool>> where);
        void Update(Skill skill);
    }
}