namespace DLL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Cancel : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Categories", "IsTarget");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Categories", "IsTarget", c => c.Boolean(nullable: false));
        }
    }
}
