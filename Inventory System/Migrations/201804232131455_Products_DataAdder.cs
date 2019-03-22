namespace Inventory_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Products_DataAdder : DbMigration
    {
        public override void Up()
        {
            Sql("Update Products set CategoriesId=1 where Id=3");
        }
        
        public override void Down()
        {
        }
    }
}
