using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Inventory_System.Models;
using Inventory_System.Models.Coder_Created;
using Inventory_System.Dtos;
using AutoMapper;

namespace Inventory_System.Controllers.Api
{
    public class OrderController : ApiController
    {
        private DataBaseFile _context;

        public OrderController()
        {
            _context = new DataBaseFile();
        }

        [HttpGet]
        public IHttpActionResult getOrders()
        {
            var orders = _context.Order.Include(o => o.Customers).Include(o => o.Products).ToList();
            return Ok(orders);
        }

        //[HttpGet]

        //public IHttpActionResult getorderByCustomer(int id)
        //{
        //    var order=_context.Order.Include
        //}

        [HttpPost]
        public IHttpActionResult saveOrder(OrderDtos orderDtos)
        {
            

            var customer = _context.Customers.Single(c => c.Id == orderDtos.CustomerId);
            //if (customer == null)
            //    return BadRequest("Customer Is Not Valid");

            var products = _context.Products.Where(p => orderDtos.ProductIds.Contains(p.Id)).ToList();

            //if (orderDtos.ProductIds.Count == 0)
            //    return BadRequest("NO Product Has Been Given");

            //if (products.Count != orderDtos.ProductIds.Count)
            //    return BadRequest("One Or More Movies Are Invalid");
            //var price = 0;
            foreach (var product in products)
            {
                if (product.Quantity == 0)
                {
                    return BadRequest("Product Is Not Availabe");
                }
                if (customer.HaveAmount == 0)
                    return BadRequest("Customer's Balance Is Nill");

                customer.HaveAmount = Convert.ToInt32(customer.HaveAmount - product.Price);
                product.Quantity--;
                
                var order = new Order
                {
                    Customers=customer,
                    Products=product,
                    OrderDate=DateTime.Now
                };
                _context.Order.Add(order);
            }
            _context.SaveChanges();
            return Ok();
        }

        [HttpDelete]
        public void deleteOrder(int id)
        {
            var order = _context.Order.Single(o => o.Id==id);
            if (order == null)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            _context.Order.Remove(order);
            _context.SaveChanges();
        }
    }
        
}
