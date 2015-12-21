using System;
using System.Data.Entity;
using Model.Entities;

namespace Model
{
    public interface IContext
    {
        DbSet<Task> Tasks { get; set; }
        DbSet<WorkUnit> WorkUnits { get; set; }
        DbSet<Profile> Profiles { get; set; }
        DbSet<Skill> Skills { get; set; }
        DbSet<Preferences> Preferences { get; set; }
        DbSet<HistoryEvent> HistoryEvents { get; set; }
        DbSet<Day> Days { get; set; }
        DbSet<Improvement> Improvements { get; set; }
    }

    public class EntitiesContext : DbContext, IContext
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
/*
    public class EntitiesContextTests : DbContext, IContext
    {
        public EntitiesContextTests() : base("name=EntitiesDatabaseTests")
        {
        }

        public EntitiesContextTests(String connectionString) : base(connectionString)
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
    }*/
}
