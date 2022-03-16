namespace FitnessOpg.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Fitnesscenters",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FitnessName = c.String(),
                        MonthlyPrice = c.Double(nullable: false),
                        OpeningTime = c.DateTime(nullable: false),
                        ClosingTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Members",
                c => new
                    {
                        MemberID = c.Int(nullable: false, identity: true),
                        MemberName = c.String(),
                        MemberBirth = c.DateTime(nullable: false),
                        MemberMail = c.String(),
                    })
                .PrimaryKey(t => t.MemberID);
            
            CreateTable(
                "dbo.TraningMachines",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        MachineName = c.String(),
                        MachineVersion = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.MemberFitnesscenters",
                c => new
                    {
                        Member_MemberID = c.Int(nullable: false),
                        Fitnesscenter_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Member_MemberID, t.Fitnesscenter_ID })
                .ForeignKey("dbo.Members", t => t.Member_MemberID, cascadeDelete: true)
                .ForeignKey("dbo.Fitnesscenters", t => t.Fitnesscenter_ID, cascadeDelete: true)
                .Index(t => t.Member_MemberID)
                .Index(t => t.Fitnesscenter_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MemberFitnesscenters", "Fitnesscenter_ID", "dbo.Fitnesscenters");
            DropForeignKey("dbo.MemberFitnesscenters", "Member_MemberID", "dbo.Members");
            DropIndex("dbo.MemberFitnesscenters", new[] { "Fitnesscenter_ID" });
            DropIndex("dbo.MemberFitnesscenters", new[] { "Member_MemberID" });
            DropTable("dbo.MemberFitnesscenters");
            DropTable("dbo.TraningMachines");
            DropTable("dbo.Members");
            DropTable("dbo.Fitnesscenters");
        }
    }
}
