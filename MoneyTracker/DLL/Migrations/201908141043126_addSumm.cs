namespace DLL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addSumm : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Categories", "Summ", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Categories", "Summ");
        }
    }
}
