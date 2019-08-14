namespace DLL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deleteFirstUse : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Users", "IsFirstEnter");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "IsFirstEnter", c => c.Boolean(nullable: false));
        }
    }
}
