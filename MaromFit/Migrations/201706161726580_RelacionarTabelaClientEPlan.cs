namespace MaromFit.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RelacionarTabelaClientEPlan : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clients", "Mail", c => c.String());
            AddColumn("dbo.Clients", "BirthDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Clients", "SubscribeDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Clients", "PlanId", c => c.Int(nullable: false));
            CreateIndex("dbo.Clients", "PlanId");
            AddForeignKey("dbo.Clients", "PlanId", "dbo.Plans", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Clients", "PlanId", "dbo.Plans");
            DropIndex("dbo.Clients", new[] { "PlanId" });
            DropColumn("dbo.Clients", "PlanId");
            DropColumn("dbo.Clients", "SubscribeDate");
            DropColumn("dbo.Clients", "BirthDate");
            DropColumn("dbo.Clients", "Mail");
        }
    }
}
