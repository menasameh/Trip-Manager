namespace tripManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fg : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reservations", "ticketID", c => c.Int(nullable: false));
            AddColumn("dbo.Trips", "nextTicketID", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Trips", "nextTicketID");
            DropColumn("dbo.Reservations", "ticketID");
        }
    }
}
