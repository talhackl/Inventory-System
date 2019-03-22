using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading;
using AutoMapper;
using Inventory_System.Models.Coder_Created;
using Inventory_System.Dtos;
using Inventory_System.Models;

namespace Inventory_System.App_Start
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            //Domain To Dtos

            Mapper.CreateMap<Products , ProductDtos>();
            Mapper.CreateMap<Customers, CustomerDtos>();
            Mapper.CreateMap<Order, OrderDtos>();


            //Dtos To Domain

            Mapper.CreateMap<ProductDtos, Products>();
            Mapper.CreateMap<CustomerDtos,Customers>();
            Mapper.CreateMap<OrderDtos, Order>();
        }



    }
}