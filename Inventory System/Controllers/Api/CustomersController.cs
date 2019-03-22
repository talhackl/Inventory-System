using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AutoMapper;
using Inventory_System.Models;
using Inventory_System.Models.Coder_Created;
using Inventory_System.Dtos;

namespace Inventory_System.Controllers.Api
{
    public class CustomersController : ApiController
    {
        private DataBaseFile _context;
        public CustomersController()
        {
            _context = new DataBaseFile();
        }
        //GET
        [HttpGet]
        public IHttpActionResult getCustomers(string query=null)
        {
            var customers = _context.Customers.Select(Mapper.Map<Customers, CustomerDtos>).ToList();

            //if (!String.IsNullOrWhiteSpace(query))
            //    var customersQuery = _context.Customers.Where(c => c.Name.Contains(query));
                
            // var customerDtos = customersQuery.Select(Mapper.Map<Customers, CustomerDtos>).ToList();
            return Ok(customers);
        }

        //GET By Id
        [HttpGet]
        public IHttpActionResult getCustomerById(int id)
        {
            var customer = _context.Customers.Single(c => c.Id == id);
            if (customer == null)
            {
                return NotFound();
            }
            return Ok(Mapper.Map<Customers, CustomerDtos>(customer));
        }

        //SaveCustomer
        [HttpPost]
        public IHttpActionResult saveCustomer(CustomerDtos customerDtos)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            //var customrDb = _context.Customers.Single(c => c.Name==customerDtos.Name);
            var customerInDb = Mapper.Map<CustomerDtos, Customers>(customerDtos);
            _context.Customers.Add(customerInDb);
            _context.SaveChanges();
            customerDtos.Id= customerInDb.Id;
            return Created(new Uri(Request.RequestUri + "/" + customerDtos.Id), customerDtos);
        }

        //EditCustomer
        [HttpPut]
        public void editCustomer(int id, CustomerDtos customerDtos)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var customerInDb = _context.Customers.Single(c => c.Id == id);
            if (customerInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            Mapper.Map(customerDtos, customerInDb);
            _context.SaveChanges();
        }

        //DeleteCustomer
        [HttpDelete]
        public void deleteCustomer(int id)
        {
            var customer = _context.Customers.Single(c => c.Id == id);
            if (customer == null)
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            _context.Customers.Remove(customer);
            _context.SaveChanges();

        }
    }
}
