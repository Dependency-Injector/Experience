using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using DataAccessLayer.Model;

namespace DataAccessLayer.Repositories
{
    public class TasksRepository : IRepository<Task>
    {
        private readonly EntitiesContext context;

        public TasksRepository()
        {
            context = new EntitiesContext();
            context.Database.Connection.Open();
        }

        public Task Get(int taskId)
        {
            return context.Tasks.AsNoTracking().First(t => t.Id == taskId);
        }
        public IEnumerable<Task> GetAll()
        {
            return context.Tasks.AsNoTracking();
        }
        public IEnumerable<Task> Find(Expression<Func<Task, bool>> @where)
        {
            return context.Tasks.AsNoTracking().Where(where);
        }
        public Task Single(Expression<Func<Task, bool>> @where)
        {
            return context.Tasks.AsNoTracking().Single(where);
        }
        public Task First(Expression<Func<Task, bool>> @where)
        {
            return context.Tasks.AsNoTracking().First(where);
        }
        public void Add(Task task)
        {
            using (EntitiesContext context = new EntitiesContext())
            {
                context.Tasks.Add(task);
                context.Entry(task).State = EntityState.Added;
                context.SaveChanges();
            }
        }
        public void Update(Task task)
        {
            using (EntitiesContext context = new EntitiesContext())
            {
                context.Tasks.Attach(task);
                context.Entry(task).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
        public void Delete(Task task)
        {
            using (EntitiesContext context = new EntitiesContext())
            {
                context.Tasks.Attach(task);
                context.Tasks.Remove(task);
                context.Entry(task).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public bool HasTasks()
        {
            return context.Tasks.Any();
        }
        
    }
}
