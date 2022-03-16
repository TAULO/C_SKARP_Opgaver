using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness_Obl.Model
{
    internal class Fitnesscenter
    {
        public int ID { get; set; }
        public string FitnessName { get; set; }
        public double MonthlyPrice { get; set; }
        public DateTime OpeningTime { get; set; }
        public DateTime ClosingTime { get; set; }

        public ICollection<Member> Members { get; set; }
        public Fitnesscenter() { }
        public Fitnesscenter(string name, double monthlyPrice, DateTime openingTime, DateTime closingTime)
        {
            FitnessName = name;
            MonthlyPrice = monthlyPrice;
            OpeningTime = openingTime;
            ClosingTime = closingTime;
            this.Members = new HashSet<Member>();
        }

        public override string ToString()
        {
            return FitnessName + " " + MonthlyPrice + " " + OpeningTime.ToString() + " " + ClosingTime.ToString();
        }
    }
}
