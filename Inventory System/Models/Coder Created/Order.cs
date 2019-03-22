using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Inventory_System.Models.Coder_Created
{
    public class Order
    {
        public int Id { get; set; }

        public Customers Customers { get; set; }
        public Products Products { get; set; }

        [Required]
        public DateTime OrderDate { get; set; }
       
    }
}