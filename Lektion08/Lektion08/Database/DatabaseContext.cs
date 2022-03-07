using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion08.Database
{
    internal class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("Cars")
        {
        }
        public DbSet<Car> Cars { get; set; }
    }
}
