namespace DLL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CardCash : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "CardBalance", c => c.Double(nullable: false));
            AddColumn("dbo.Users", "CashBalance", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "CashBalance");
            DropColumn("dbo.Users", "CardBalance");
        }
    }
}
