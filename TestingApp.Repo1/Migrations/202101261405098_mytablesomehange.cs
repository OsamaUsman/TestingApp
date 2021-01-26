namespace TestingApp.Repo1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mytablesomehange : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "Name", c => c.String(nullable: false, maxLength: 50));
            DropColumn("dbo.Users", "UName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "UName", c => c.String(nullable: false, maxLength: 50));
            DropColumn("dbo.Users", "Name");
        }
    }
}
