using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion08.Database
{
    internal class CarInit : DropCreateDatabaseIfModelChanges<DatabaseContext>
    {
        protected override void Seed(DatabaseContext context)
        {
            context.Cars.Add(new Car("Ford T", 20));
            context.SaveChanges();
        }
    }
}
