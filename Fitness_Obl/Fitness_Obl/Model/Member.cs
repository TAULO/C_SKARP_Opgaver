using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness_Obl.Model
{
    internal class Member
    {
        public int MemberID { get; set; }
        public string MemberName { get; set; }
        public DateTime MemberBirth { get; set; }
        public string MemberMail { get; set; }
        public ICollection<Fitnesscenter> FitnesscenterList { get; set; }
        public Member() { }

        public Member(string memberName, DateTime memberBirth, string memberMail)
        {
            MemberName = memberName;
            MemberBirth = memberBirth;
            MemberMail = memberMail;
            this.FitnesscenterList = new HashSet<Fitnesscenter>();
        }
    }
}
