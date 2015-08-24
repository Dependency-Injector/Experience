using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using Model;
using Model.Entities;

namespace DataAccessLayer.Repositories
{
    public class TasksRepository : IRepository<Task>
    {
        private readonly EntitiesContext context;

        public TasksRepository(String connectionString)
        {
            context = new EntitiesContext(connectionString);
            context.Database.Connection.Open();
        }

        public TasksRepository()
        {
            context = new EntitiesContext();
            context.Database.Connection.Open();
        }

        public Task Get(int taskId)
        {
            return context.Tasks.AsNoTracking().FirstOrDefault(t => t.Id == taskId);
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

                if(task.Parent != null)
                    context.Entry(task.Parent).State = EntityState.Unchanged;
                
                if(task.SkillToTrain != null)
                    context.Entry(task.SkillToTrain).State = EntityState.Unchanged;

                context.SaveChanges();
            }
        }
        public void Update(Task task)
        {
            using (EntitiesContext context = new EntitiesContext())
            {
                var oldTask = context.Tasks.Find(task.Id);
                context.Tasks.Attach(oldTask);

                context.Entry(oldTask).CurrentValues.SetValues(task);

                if (task.SkillToTrain != null)
                    oldTask.SkillToTrain = context.Skills.Find(task.SkillToTrain.Id);

                if (task.Parent != null)
                    oldTask.Parent = context.Tasks.Find(task.Parent.Id);

                context.Entry(oldTask).State = EntityState.Modified;
                
                context.SaveChanges();
            }
        }
        public void Delete(Task day)
        {
            using (EntitiesContext context = new EntitiesContext())
            {
                context.Tasks.Attach(day);
                context.Tasks.Remove(day);
                context.Entry(day).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public bool HasTasks()
        {
            return context.Tasks.Any();
        }
        
    }
}
