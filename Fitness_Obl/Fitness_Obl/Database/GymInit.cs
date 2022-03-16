using Fitness_Obl.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness_Obl.Database
{
    internal class GymInit : DropCreateDatabaseIfModelChanges<GymContext>
    {
        protected override void Seed(GymContext context)
        {
            DateTime open = DateTime.Now;
            open.AddDays(1).AddHours(5);
            DateTime close = DateTime.Now;
            open.AddDays(1).AddHours(5);

            context.FitnesscenterSet.Add(new Fitnesscenter("FitnessAarhus", 200, open, close));
            context.FitnesscenterSet.Add(new Fitnesscenter("FitnessSkjern", 150, open, close));
            context.FitnesscenterSet.Add(new Fitnesscenter("FitnessKøbenhavn", 250, open, close));
            context.FitnesscenterSet.Add(new Fitnesscenter("FitnessKøbenhavn", 250, open, close));


            context.SaveChanges();
        }
    }
 }

