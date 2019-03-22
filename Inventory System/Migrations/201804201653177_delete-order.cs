namespace Inventory_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deleteorder : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Orders", "CustomersId", "dbo.Customers");
            DropForeignKey("dbo.Orders", "ProductsId", "dbo.Products");
            DropIndex("dbo.Orders", new[] { "CustomersId" });
            DropIndex("dbo.Orders", new[] { "ProductsId" });
            DropTable("dbo.Orders");
        }
        
        public override void Down()
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
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.Orders", "ProductsId");
            CreateIndex("dbo.Orders", "CustomersId");
            AddForeignKey("dbo.Orders", "ProductsId", "dbo.Products", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Orders", "CustomersId", "dbo.Customers", "Id", cascadeDelete: true);
        }
    }
}
