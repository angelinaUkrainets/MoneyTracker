namespace DLL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Databasisdone : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Operations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Summ = c.Double(nullable: false),
                        CategoryId = c.Int(nullable: false),
                        WayOfPayId = c.Int(nullable: false),
                        IsProfit = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .ForeignKey("dbo.WayOfPays", t => t.WayOfPayId, cascadeDelete: true)
                .Index(t => t.CategoryId)
                .Index(t => t.WayOfPayId);
            
            CreateTable(
                "dbo.WayOfPays",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IsCashPayment = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Categories", "UserId", c => c.Int(nullable: false));
            CreateIndex("dbo.Categories", "UserId");
            AddForeignKey("dbo.Categories", "UserId", "dbo.Users", "ID", cascadeDelete: false);
            DropColumn("dbo.Categories", "Suma");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Categories", "Suma", c => c.Double(nullable: false));
            DropForeignKey("dbo.Categories", "UserId", "dbo.Users");
            DropForeignKey("dbo.Operations", "WayOfPayId", "dbo.WayOfPays");
            DropForeignKey("dbo.Operations", "CategoryId", "dbo.Categories");
            DropIndex("dbo.Operations", new[] { "WayOfPayId" });
            DropIndex("dbo.Operations", new[] { "CategoryId" });
            DropIndex("dbo.Categories", new[] { "UserId" });
            DropColumn("dbo.Categories", "UserId");
            DropTable("dbo.WayOfPays");
            DropTable("dbo.Operations");
        }
    }
}
