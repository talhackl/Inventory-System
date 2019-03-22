using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
using Inventory_System.Models.Coder_Created;
using System.ComponentModel.DataAnnotations;


namespace Inventory_System.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        [Required]
        public string PhoneNo { get; set; }


    }
}