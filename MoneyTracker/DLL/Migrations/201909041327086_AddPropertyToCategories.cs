namespace DLL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPropertyToCategories : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Categories", "ImageSource", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Categories", "ImageSource");
        }
    }
}
