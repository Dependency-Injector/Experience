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
    public class TasksRepository : ITasksRepository
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
            //context.Database.Connection.Open();
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
            using (EntitiesContext entities = new EntitiesContext())
            {
                entities.Tasks.Add(task);
                entities.Entry(task).State = EntityState.Added;

                if(task.Parent != null)
                    entities.Entry(task.Parent).State = EntityState.Unchanged;
                
                if(task.SkillToTrain != null)
                    entities.Entry(task.SkillToTrain).State = EntityState.Unchanged;

                if(task.Owner != null)
                    entities.Entry(task.Owner).State = EntityState.Unchanged;

                entities.SaveChanges();
            }
        }

        public void Update(Task task)
        {
            using (EntitiesContext entities = new EntitiesContext())
            {
                var oldTask = entities.Tasks.Find(task.Id);
                entities.Tasks.Attach(oldTask);

                entities.Entry(oldTask).CurrentValues.SetValues(task);

                if (task.SkillToTrain != null)
                    oldTask.SkillToTrain = entities.Skills.Find(task.SkillToTrain.Id);

                if (task.Parent != null)
                    oldTask.Parent = entities.Tasks.Find(task.Parent.Id);

                entities.Entry(oldTask).State = EntityState.Modified;
                
                entities.SaveChanges();
            }
        }

        public void Delete(Task day)
        {
            using (EntitiesContext entities = new EntitiesContext())
            {
                entities.Tasks.Attach(day);
                entities.Tasks.Remove(day);
                entities.Entry(day).State = EntityState.Deleted;
                entities.SaveChanges();
            }
        }

        public bool HasTasks()
        {
            return context.Tasks.Any();
        }
        
    }
}
