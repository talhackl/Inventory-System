using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Inventory_System.Dtos
{
    public class CustomerDtos
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNo { get; set; }
        public int HaveAmount { get; set; }

    }
}