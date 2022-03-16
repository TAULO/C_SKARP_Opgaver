using System;
using System.Collections.Generic;

namespace FitnessOpg.Model
{
    public class Member
    {
        public int MemberID { get; set; }
        public string MemberName { get; set; }
        public DateTime MemberBirth { get; set; }
        public string MemberMail { get; set; }
        public ICollection<Fitnesscenter> FitnesscenterList { get; }
        public Member() 
        {
            FitnesscenterList = new List<Fitnesscenter>();
        }

        public Member(string memberName, DateTime memberBirth, string memberMail)
        {
            MemberName = memberName;
            MemberBirth = memberBirth;
            MemberMail = memberMail;
            FitnesscenterList = new List<Fitnesscenter>();
        }
        public bool IsOver16()
        {
            var now = DateTime.Now;
            if (now.Year - MemberBirth.Year > 16)
            {
                return true;
            } else if (now.Year - MemberBirth.Year >= 16 && now.Month >= MemberBirth.Month && now.Day >= MemberBirth.Day)
            {
                return true;
            }
            return false;
        }
      
        public override string ToString()
        {
            return MemberName + Environment.NewLine + MemberBirth.Day + "/" + MemberBirth.Month + "/" + MemberBirth.Year + Environment.NewLine + MemberMail;
        }
    }
}
