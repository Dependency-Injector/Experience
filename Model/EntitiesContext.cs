using System;
using System.Data.Entity;
using Model.Entities;

namespace Model
{
    public class EntitiesContext : DbContext
    {
        public EntitiesContext() : base("name=EntitiesDatabase")
        {
        }

        public EntitiesContext(String connectionString) : base(connectionString)
        {
            
        }

        public DbSet<Task> Tasks { get; set; }
        public DbSet<WorkUnit> WorkUnits { get; set; }
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Preferences> Preferences { get; set; }
        public DbSet<HistoryEvent> HistoryEvents { get; set; }
        public DbSet<Day> Days { get; set; }
        public DbSet<Improvement> Improvements { get; set; }
    }
}
