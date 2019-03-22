using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Inventory_System.Dtos;
using Inventory_System.Models.Coder_Created;

namespace Inventory_System.Dtos
{
    public class OrderDtos
    {
        public int CustomerId { get; set; }
        public List<int> ProductIds { get; set; }
    }
}