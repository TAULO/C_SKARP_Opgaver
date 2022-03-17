using FitnessOpg.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessOpg.Database
{
    internal class GymContext : DbContext
    {
        public GymContext() : base("FitnesscenterDB")
        {
           
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
        public DbSet<Fitnesscenter> FitnesscenterSet { get; set; }
        public DbSet<Member> MemberSet { get; set; }
    }
}
