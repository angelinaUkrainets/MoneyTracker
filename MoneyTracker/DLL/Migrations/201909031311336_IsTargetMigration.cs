namespace DLL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IsTargetMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Categories", "IsTarget", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Categories", "IsTarget");
        }
    }
}
