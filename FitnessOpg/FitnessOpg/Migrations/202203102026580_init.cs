namespace FitnessOpg.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Fitnesscenters", newName: "Fitnesscenter");
            RenameTable(name: "dbo.Members", newName: "Member");
            RenameTable(name: "dbo.TraningMachines", newName: "TraningMachine");
            RenameTable(name: "dbo.MemberFitnesscenters", newName: "MemberFitnesscenter");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.MemberFitnesscenter", newName: "MemberFitnesscenters");
            RenameTable(name: "dbo.TraningMachine", newName: "TraningMachines");
            RenameTable(name: "dbo.Member", newName: "Members");
            RenameTable(name: "dbo.Fitnesscenter", newName: "Fitnesscenters");
        }
    }
}
