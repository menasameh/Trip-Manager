namespace tripManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class d : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Groups", "Trip_ID", "dbo.Trips");
            DropIndex("dbo.Groups", new[] { "Trip_ID" });
            CreateTable(
                "dbo.TripGroups",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        tripID = c.Int(nullable: false),
                        groupID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Groups", t => t.groupID, cascadeDelete: true)
                .ForeignKey("dbo.Trips", t => t.tripID, cascadeDelete: true)
                .Index(t => t.tripID)
                .Index(t => t.groupID);
            
            DropColumn("dbo.Groups", "Trip_ID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Groups", "Trip_ID", c => c.Int());
            DropForeignKey("dbo.TripGroups", "tripID", "dbo.Trips");
            DropForeignKey("dbo.TripGroups", "groupID", "dbo.Groups");
            DropIndex("dbo.TripGroups", new[] { "groupID" });
            DropIndex("dbo.TripGroups", new[] { "tripID" });
            DropTable("dbo.TripGroups");
            CreateIndex("dbo.Groups", "Trip_ID");
            AddForeignKey("dbo.Groups", "Trip_ID", "dbo.Trips", "ID");
        }
    }
}
