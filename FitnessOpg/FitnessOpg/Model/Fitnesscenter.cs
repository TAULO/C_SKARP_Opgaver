using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessOpg.Model
{
    public class Fitnesscenter : INotifyPropertyChanged
    {
        public int ID { get; set; }
        private string fitnessName;
        public string FitnessName { 
            set
            {
                fitnessName = value;
                INotifyPropertyChanged("FitnessName");
            } 
            get { return fitnessName; } 
        }
        public double MonthlyPrice { get; set; }
        public DateTime OpeningTime { get; set; }
        public DateTime ClosingTime { get; set; }

        public virtual ICollection<Member> Members { get; } = new HashSet<Member>();
        public Fitnesscenter() 
        {
        }
        public Fitnesscenter(string name, double monthlyPrice, DateTime openingTime, DateTime closingTime)
        {
            FitnessName = name;
            MonthlyPrice = monthlyPrice;
            OpeningTime = openingTime;
            ClosingTime = closingTime;
        }
        public event PropertyChangedEventHandler PropertyChanged;
        private void INotifyPropertyChanged(string v)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(v));
            }
        }


        public override string ToString()
        {
            return FitnessName + Environment.NewLine + MonthlyPrice + " kr." + Environment.NewLine + "0" + OpeningTime.Hour + ":00"+ "-" + ClosingTime.Hour + ":00";
        }
    }
}
