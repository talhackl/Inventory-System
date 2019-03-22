namespace Inventory_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CustomersDataAdder : DbMigration
    {
        public override void Up()
        {
            Sql("insert into customers (Name,PhoneNo,HaveAmount) values('Talha Hafeez','03070501323',40000)");
        }
        
        public override void Down()
        {
        }
    }
}
