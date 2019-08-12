namespace DLL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IsFirstUse : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "IsFirstEnter", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "IsFirstEnter");
        }
    }
}
