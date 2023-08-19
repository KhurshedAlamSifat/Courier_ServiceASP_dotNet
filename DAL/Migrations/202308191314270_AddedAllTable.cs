namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedAllTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Deliveries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ParcelID = c.Int(nullable: false),
                        DriverID = c.Int(nullable: false),
                        PickupDateTime = c.DateTime(nullable: false),
                        DeliveryDateTime = c.DateTime(nullable: false),
                        Status = c.String(),
                        Route = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Drivers", t => t.DriverID, cascadeDelete: true)
                .ForeignKey("dbo.Parcels", t => t.ParcelID, cascadeDelete: true)
                .Index(t => t.ParcelID)
                .Index(t => t.DriverID);
            
            CreateTable(
                "dbo.Drivers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Phone = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Availability = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Deliveries", "ParcelID", "dbo.Parcels");
            DropForeignKey("dbo.Deliveries", "DriverID", "dbo.Drivers");
            DropIndex("dbo.Deliveries", new[] { "DriverID" });
            DropIndex("dbo.Deliveries", new[] { "ParcelID" });
            DropTable("dbo.Drivers");
            DropTable("dbo.Deliveries");
        }
    }
}
