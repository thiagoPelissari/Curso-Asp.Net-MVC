namespace MaromFit.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCpfToApplicationUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Cpf", c => c.String(nullable: false, maxLength: 11));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "Cpf");
        }
    }
}
