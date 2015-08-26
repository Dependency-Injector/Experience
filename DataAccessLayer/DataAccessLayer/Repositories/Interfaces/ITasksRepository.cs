using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Model.Entities;

namespace DataAccessLayer.Repositories.Interfaces
{
    public interface ITasksRepository : IRepository<Task>
    {
        void Delete(Task day);
        IEnumerable<Task> Find(Expression<Func<Task, bool>> where);
        Task First(Expression<Func<Task, bool>> where);
        Task Get(int taskId);
        IEnumerable<Task> GetAll();
        bool HasTasks();
        Task Single(Expression<Func<Task, bool>> where);
        void Update(Task task);
    }
}