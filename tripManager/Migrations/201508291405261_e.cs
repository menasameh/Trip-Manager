namespace tripManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class e : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Groups", "hasSizeLimit", c => c.Boolean(nullable: false));
            AddColumn("dbo.Groups", "tripID", c => c.Int(nullable: false));
            CreateIndex("dbo.Groups", "tripID");
            AddForeignKey("dbo.Groups", "tripID", "dbo.Trips", "ID", cascadeDelete: false);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Groups", "tripID", "dbo.Trips");
            DropIndex("dbo.Groups", new[] { "tripID" });
            DropColumn("dbo.Groups", "tripID");
            DropColumn("dbo.Groups", "hasSizeLimit");
        }
    }
}
