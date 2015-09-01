namespace tripManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ClientGroups",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        clientID = c.Int(nullable: false),
                        groupID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Clients", t => t.clientID, cascadeDelete: false)
                .ForeignKey("dbo.Groups", t => t.groupID, cascadeDelete: false)
                .Index(t => t.clientID)
                .Index(t => t.groupID);
            
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        phoneNumber = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Groups",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        capacity = c.Int(nullable: false),
                        isBus = c.Boolean(nullable: false),
                        hasSizeLimit = c.Boolean(nullable: false),
                        tripID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Trips", t => t.tripID, cascadeDelete: true)
                .Index(t => t.tripID);
            
            CreateTable(
                "dbo.Reservations",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        tripID = c.Int(nullable: false),
                        clientID = c.Int(nullable: false),
                        ticketID = c.Int(nullable: false),
                        priceToPay = c.Single(nullable: false),
                        pricePaid = c.Single(nullable: false),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Clients", t => t.clientID, cascadeDelete: false)
                .ForeignKey("dbo.Trips", t => t.tripID, cascadeDelete: false)
                .Index(t => t.tripID)
                .Index(t => t.clientID);
            
            CreateTable(
                "dbo.Trips",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        price = c.Single(nullable: false),
                        Date = c.DateTime(nullable: false),
                        notes = c.String(),
                        hasChangablePrice = c.Boolean(nullable: false),
                        isFrozen = c.Boolean(nullable: false),
                        isDeleted = c.Boolean(nullable: false),
                        nextTicketID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.TripGroups",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        tripID = c.Int(nullable: false),
                        groupID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Groups", t => t.groupID, cascadeDelete: false)
                .ForeignKey("dbo.Trips", t => t.tripID, cascadeDelete: false)
                .Index(t => t.tripID)
                .Index(t => t.groupID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TripGroups", "tripID", "dbo.Trips");
            DropForeignKey("dbo.TripGroups", "groupID", "dbo.Groups");
            DropForeignKey("dbo.Reservations", "tripID", "dbo.Trips");
            DropForeignKey("dbo.Groups", "tripID", "dbo.Trips");
            DropForeignKey("dbo.Reservations", "clientID", "dbo.Clients");
            DropForeignKey("dbo.ClientGroups", "groupID", "dbo.Groups");
            DropForeignKey("dbo.ClientGroups", "clientID", "dbo.Clients");
            DropIndex("dbo.TripGroups", new[] { "groupID" });
            DropIndex("dbo.TripGroups", new[] { "tripID" });
            DropIndex("dbo.Reservations", new[] { "clientID" });
            DropIndex("dbo.Reservations", new[] { "tripID" });
            DropIndex("dbo.Groups", new[] { "tripID" });
            DropIndex("dbo.ClientGroups", new[] { "groupID" });
            DropIndex("dbo.ClientGroups", new[] { "clientID" });
            DropTable("dbo.TripGroups");
            DropTable("dbo.Trips");
            DropTable("dbo.Reservations");
            DropTable("dbo.Groups");
            DropTable("dbo.Clients");
            DropTable("dbo.ClientGroups");
        }
    }
}
