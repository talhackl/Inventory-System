namespace Inventory_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Orders : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrderDate = c.DateTime(nullable: false),
                        TotalAmount = c.Long(nullable: false),
                        Customers_Id = c.Int(),
                        Products_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.Customers_Id)
                .ForeignKey("dbo.Products", t => t.Products_Id)
                .Index(t => t.Customers_Id)
                .Index(t => t.Products_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "Products_Id", "dbo.Products");
            DropForeignKey("dbo.Orders", "Customers_Id", "dbo.Customers");
            DropIndex("dbo.Orders", new[] { "Products_Id" });
            DropIndex("dbo.Orders", new[] { "Customers_Id" });
            DropTable("dbo.Orders");
        }
    }
}
