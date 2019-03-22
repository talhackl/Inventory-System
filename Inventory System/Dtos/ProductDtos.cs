using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Inventory_System.Models.Coder_Created;

namespace Inventory_System.Dtos
{
    public class ProductDtos
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public long Price { get; set; }

        public Categories Categories { get; set; }
        public int CategoriesId { get; set; }
    }
}