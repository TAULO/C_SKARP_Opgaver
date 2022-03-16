using FitnessOpg.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessOpg.Controller
{
    public class Create
    {
        public Fitnesscenter CreateFitnesscenter(string name, double monthlyPrice, DateTime openingTime, DateTime closingTime)
        {
            if (name == null) throw new ArgumentNullException("Name can not be null");
            if (name.Length <= 0) throw new ArgumentException("Name can not be empty");
            if (monthlyPrice <= 0) throw new ArgumentException("Price must be greater than 0");

            return new Fitnesscenter(name, monthlyPrice, openingTime, closingTime);
        }

        public void Updatefitnesscenter(Fitnesscenter center, string name, double monthlyPrice, DateTime openingTime, DateTime closingTime)
        {
            if (name == null) throw new ArgumentNullException("Name can not be null");
            if (name.Length <= 0) throw new ArgumentException("Name can not be empty");
            if (monthlyPrice <= 0) throw new ArgumentException("Price must be greater than 0");
            
            center.FitnessName = name;
            center.MonthlyPrice = monthlyPrice;
            center.OpeningTime = openingTime;
            center.ClosingTime = closingTime;
        }
    }
}
