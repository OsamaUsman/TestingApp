namespace TestingApp.Repo1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class secondone : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Products", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Products", "Descripton", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Products", "Descripton", c => c.String());
            AlterColumn("dbo.Products", "Name", c => c.String());
        }
    }
}
