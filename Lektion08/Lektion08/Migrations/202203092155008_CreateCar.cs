namespace Lektion08.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateCar : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Car",
                c => new
                    {
                        CarID = c.Int(nullable: false, identity: true),
                        Brand = c.String(),
                        Horsepower = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CarID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Car");
        }
    }
}
