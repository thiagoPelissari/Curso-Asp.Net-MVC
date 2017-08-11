namespace MaromFit.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeDateTimeToNullableInClient : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Clients", "SubscribeDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Clients", "SubscribeDate", c => c.DateTime(nullable: false));
        }
    }
}
