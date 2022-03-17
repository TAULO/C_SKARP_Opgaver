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

        public Member CreateMember(string name, DateTime birth, string mail)
        {
            if (name == null) throw new ArgumentException("Name can not be null");
            if (name.Length <= 0) throw new ArgumentException("Name can not be empty");
            if (mail == null) throw new ArgumentException("Name can not be null");
            if (mail.Length <= 0) throw new ArgumentException("Name can not be empty");
            if(birth == null) throw new ArgumentNullException("Date can not be null");

            Member member = new Member(name, birth, mail);

            if (!member.IsOver16()) throw new ArgumentException("Member must be older than 16");

            return member;
        }

        public void UpdateMember(Member m, string name, DateTime birth, string mail)
        {
            if (name == null) throw new ArgumentException("Name can not be null");
            if (name.Length <= 0) throw new ArgumentException("Name can not be empty");
            if (mail == null) throw new ArgumentException("Name can not be null");
            if (mail.Length <= 0) throw new ArgumentException("Name can not be empty");
            if (birth == null) throw new ArgumentNullException("Date can not be null");

            m.MemberName = name;
            m.MemberBirth = birth;
            m.MemberMail = mail;

            if (!m.IsOver16()) throw new ArgumentException("Member must be older than 16");
        }
    }
}
