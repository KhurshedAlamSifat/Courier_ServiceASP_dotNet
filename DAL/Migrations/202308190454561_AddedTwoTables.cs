namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedTwoTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Phone = c.String(nullable: false),
                        Address = c.String(nullable: false),
                        Password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Parcels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CustomerId = c.Int(nullable: false),
                        Type = c.String(nullable: false),
                        Weight = c.String(nullable: false),
                        Dimensions = c.String(nullable: false),
                        PickupAddress = c.String(nullable: false),
                        DestinationAddress = c.String(nullable: false),
                        Status = c.String(nullable: false),
                        TrackingNumber = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: true)
                .Index(t => t.CustomerId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Parcels", "CustomerId", "dbo.Customers");
            DropIndex("dbo.Parcels", new[] { "CustomerId" });
            DropTable("dbo.Parcels");
            DropTable("dbo.Customers");
        }
    }
}
