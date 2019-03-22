namespace Inventory_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Products_DataAdder2 : DbMigration
    {
        public override void Up()
        {
            Sql("Update Products set CategoriesId=1 where Id=5");
            Sql("Update Products set CategoriesId=1 where Id=6");
            Sql("Update Products set CategoriesId=1 where Id=7");
            Sql("Update Products set CategoriesId=1 where Id=9");
            Sql("Update Products set CategoriesId=1 where Id=10");
        }
        
        public override void Down()
        {
        }
    }
}
