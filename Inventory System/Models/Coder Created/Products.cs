using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Inventory_System.Models.Coder_Created
{
    public class Products
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public long Price { get; set; }

        public Categories Categories { get; set; }
        public int CategoriesId { get; set; }

    }
}