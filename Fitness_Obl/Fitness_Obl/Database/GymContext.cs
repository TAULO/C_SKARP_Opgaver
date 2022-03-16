using Fitness_Obl.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness_Obl.Database
{
    internal class GymContext : DbContext
    {
        public GymContext() : base("FitnessDB")
        {

        }
        public DbSet<Fitnesscenter> FitnesscenterSet { get; set; }
        public DbSet<Member> MemberSet { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
