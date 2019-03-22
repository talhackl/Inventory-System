namespace Inventory_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataCateogory : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into Categories (Name) values('Smart Phone')");
            Sql("Insert into Categories (Name) values('Laptop')");
            Sql("Insert into Categories (Name) values('Workstation')");
            Sql("Insert into Categories (Name) values('Server')");
        }
        
        public override void Down()
        {
        }
    }
}
