using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessOpg.Model
{
    public class Fitnesscenter
    {
        public int ID { get; set; }
        public string FitnessName { get; set; }
        public double MonthlyPrice { get; set; }
        public DateTime OpeningTime { get; set; }
        public DateTime ClosingTime { get; set; }

        public virtual ICollection<Member> Members { get; }
        public Fitnesscenter() { }
        public Fitnesscenter(string name, double monthlyPrice, DateTime openingTime, DateTime closingTime)
        {
            FitnessName = name;
            MonthlyPrice = monthlyPrice;
            OpeningTime = openingTime;
            ClosingTime = closingTime;
            Members = new HashSet<Member>();
        }

        public override string ToString()
        {
            return FitnessName + Environment.NewLine + MonthlyPrice + " kr." + Environment.NewLine + "0" + OpeningTime.Hour + ":00"+ "-" + ClosingTime.Hour + ":00";
        }
    }
}
