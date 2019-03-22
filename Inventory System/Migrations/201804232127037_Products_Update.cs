namespace Inventory_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Products_Update : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "CategoriesId", c => c.Int(nullable: true));
            CreateIndex("dbo.Products", "CategoriesId");
            AddForeignKey("dbo.Products", "CategoriesId", "dbo.Categories", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "CategoriesId", "dbo.Categories");
            DropIndex("dbo.Products", new[] { "CategoriesId" });
            DropColumn("dbo.Products", "CategoriesId");
        }
    }
}
