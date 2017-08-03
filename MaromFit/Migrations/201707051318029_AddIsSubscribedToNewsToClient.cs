namespace MaromFit.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddIsSubscribedToNewsToClient : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clients", "IsSubscribedToNews", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Clients", "IsSubscribedToNews");
        }
    }
}
