using FitnessOpg.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessOpg.Database
{
    internal class GymInit : CreateDatabaseIfNotExists<GymContext>
    {
        protected override void Seed(GymContext context)
        {
            // hvert medlem kan være en del af mange fitnesscenter
            // hvert fitnesscenter kan have mange medlemmer
            Fitnesscenter fSkjern = new Fitnesscenter("Fitness Skjern", 150, new DateTime(2200, 1, 1, 5, 0, 0), new DateTime(2200, 1, 1, 22, 0, 0));
            Fitnesscenter fAarhus = new Fitnesscenter("Fitness Aarhus", 200, new DateTime(2200, 1, 1, 5, 0, 0), new DateTime(2200, 1, 1, 23, 0, 0));
            Fitnesscenter fKøbenhavn = new Fitnesscenter("Fitness København", 250, new DateTime(2200, 1, 1, 5, 0, 0), new DateTime(2200, 1, 1, 23, 0, 0));

            Member claus = new Member("Claus", new DateTime(1995, 2, 5), "claus@gmail.com");
            claus.FitnesscenterList.Add(fKøbenhavn);
            claus.FitnesscenterList.Add(fAarhus);
            claus.FitnesscenterList.Add(fSkjern);
            fSkjern.Members.Add(claus);
            fAarhus.Members.Add(claus);
            fKøbenhavn.Members.Add(claus);

            Member tobias = new Member("Tobias", new DateTime(1995, 1, 3), "Tobias@gmail.com");
            tobias.FitnesscenterList.Add(fKøbenhavn);
            tobias.FitnesscenterList.Add(fAarhus);
            tobias.FitnesscenterList.Add(fSkjern);
            fSkjern.Members.Add(tobias);
            fAarhus.Members.Add(tobias);
            fKøbenhavn.Members.Add(tobias);

            Member trine = new Member("Trine", new DateTime(2001, 1, 3), "Trine@gmail.com");
            trine.FitnesscenterList.Add(fKøbenhavn);
            trine.FitnesscenterList.Add(fAarhus);
            trine.FitnesscenterList.Add(fSkjern);
            fSkjern.Members.Add(trine);
            fAarhus.Members.Add(trine);
            fKøbenhavn.Members.Add(trine);

            Member liam = new Member("Liam", new DateTime(1981, 10, 9), "Liam@gmail.com");
            liam.FitnesscenterList.Add(fKøbenhavn);
            liam.FitnesscenterList.Add(fAarhus);
            liam.FitnesscenterList.Add(fSkjern);
            fSkjern.Members.Add(liam);
            fAarhus.Members.Add(liam);
            fKøbenhavn.Members.Add(liam);

            Member noah = new Member("Noah", new DateTime(2003, 3, 1), "Noah@gmail.com");
            noah.FitnesscenterList.Add(fKøbenhavn);
            noah.FitnesscenterList.Add(fAarhus);
            fAarhus.Members.Add(noah);
            fKøbenhavn.Members.Add(noah);

            Member oliver = new Member("Oliver", new DateTime(1980, 10, 9), "Oliver@gmail.com");
            oliver.FitnesscenterList.Add(fKøbenhavn);
            oliver.FitnesscenterList.Add(fAarhus);
            fAarhus.Members.Add(oliver);
            fKøbenhavn.Members.Add(oliver);

            Member william = new Member("Willaim", new DateTime(2000, 3, 8), "William@gmail.com");
            william.FitnesscenterList.Add(fKøbenhavn);
            fKøbenhavn.Members.Add(william);

            Member james = new Member("James", new DateTime(1989, 1, 1), "James@gmail.com");
            james.FitnesscenterList.Add(fKøbenhavn);
            fKøbenhavn.Members.Add(james);

            Member benjamin = new Member("Benjamin", new DateTime(1992, 5, 10), "Benjamin@gmail.com");
            benjamin.FitnesscenterList.Add(fKøbenhavn);
            fKøbenhavn.Members.Add(benjamin);

            Member lucas = new Member("Lucas", new DateTime(1993, 10, 5), "Lucas@gmail.com");
            lucas.FitnesscenterList.Add(fKøbenhavn);
            fKøbenhavn.Members.Add(lucas);

            Member henry = new Member("Henry", new DateTime(1977, 1, 2), "Henry@gmail.com");
            henry.FitnesscenterList.Add(fAarhus);
            fAarhus.Members.Add(oliver);

            Member alexander = new Member("Alexander", new DateTime(1990, 2, 5), "Alexander@gmail.com");
            alexander.FitnesscenterList.Add(fSkjern);
            fSkjern.Members.Add(alexander);

            context.FitnesscenterSet.Add(fSkjern);
            context.FitnesscenterSet.Add(fAarhus);
            context.FitnesscenterSet.Add(fKøbenhavn);

            context.MemberSet.Add(claus);
            context.MemberSet.Add(tobias);
            context.MemberSet.Add(trine);
            context.MemberSet.Add(liam);
            context.MemberSet.Add(noah);
            context.MemberSet.Add(oliver);
            context.MemberSet.Add(william);
            context.MemberSet.Add(james);
            context.MemberSet.Add(benjamin);
            context.MemberSet.Add(lucas);
            context.MemberSet.Add(henry);
            context.MemberSet.Add(alexander);

            context.SaveChanges();
        }
    }
}

