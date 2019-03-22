using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
using Inventory_System.Models.Coder_Created;

namespace Inventory_System.Models
{
    public class DataBaseFile : IdentityDbContext<ApplicationUser>
    {
        //Creating User's Created Class's Property//
        public DbSet<Products> Products { get; set; }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<Categories> Categories { get; set; }


        public DataBaseFile()
            : base("DefaultConnection")
        {
        }

    }
}