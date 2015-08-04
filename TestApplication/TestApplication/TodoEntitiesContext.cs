using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApplication
{
    public class TodoEntitiesContext : DbContext
    {
        public DbSet<Task> Tasks { get; set; }
    }
}
