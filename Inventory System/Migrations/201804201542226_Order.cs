namespace Inventory_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Order : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrderDate = c.DateTime(nullable: false),
                        CustomersId = c.Int(nullable: false),
                        TotalPrice = c.Long(nullable: false),
                        ProductsId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.CustomersId, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.ProductsId, cascadeDelete: true)
                .Index(t => t.CustomersId)
                .Index(t => t.ProductsId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "ProductsId", "dbo.Products");
            DropForeignKey("dbo.Orders", "CustomersId", "dbo.Customers");
            DropIndex("dbo.Orders", new[] { "ProductsId" });
            DropIndex("dbo.Orders", new[] { "CustomersId" });
            DropTable("dbo.Orders");
        }
    }
}
