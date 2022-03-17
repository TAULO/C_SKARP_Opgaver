namespace FitnessOpg.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.TraningMachine");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.TraningMachine",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        MachineName = c.String(),
                        MachineVersion = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
    }
}
