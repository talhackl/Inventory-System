namespace Inventory_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProductsDataAdd : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into Products (Name,Quantity,Price) Values('Hp Pavilion 15',20,40000)");
            Sql("Insert into Products (Name,Quantity,Price) Values('Hp Ultra Folio',30,50000)");
            Sql("Insert into Products (Name,Quantity,Price) Values('I Phone 6',20,30000)");
        }
        
        public override void Down()
        {
        }
    }
}
