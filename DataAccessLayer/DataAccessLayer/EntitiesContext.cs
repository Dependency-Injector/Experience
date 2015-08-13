using System.Data.Entity;
using DataAccessLayer.Model;

namespace DataAccessLayer
{
    public class EntitiesContext : DbContext
    {
        public EntitiesContext() : base("name=EntitiesDatabase")
        {
        }

        public DbSet<Task> Tasks { get; set; }
        public DbSet<WorkUnit> WorkUnits { get; set; }
        public DbSet<Profile> Profiles { get; set; }
    }
}
