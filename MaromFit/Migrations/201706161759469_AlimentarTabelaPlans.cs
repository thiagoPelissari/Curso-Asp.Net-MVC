namespace MaromFit.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlimentarTabelaPlans : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Plans Values ('Plano A',60)");
            Sql("INSERT INTO Plans Values ('Plano B',80)");
            Sql("INSERT INTO Plans Values ('Plano C',100)");
        }
        
        public override void Down()
        {
        }
    }
}
