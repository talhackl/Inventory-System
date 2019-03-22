using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.Entity;
using Inventory_System.Models;
using Inventory_System.Dtos;
using Inventory_System.Models.Coder_Created;
using AutoMapper;

namespace Inventory_System.Controllers.Api
{
    public class ProductsController : ApiController
    {
        private DataBaseFile _context;

        public ProductsController()
        {
            _context = new DataBaseFile();
        }

        //GET
        [HttpGet]
        public IHttpActionResult getProducts()
        {
            var products= _context.Products.Include(product => product.Categories).ToList().Select(Mapper.Map<Products, ProductDtos>);
            return Ok(products);
        }


        //GET By Id
        [HttpGet]
        public IHttpActionResult getProductById(int id)
        {
            var product = _context.Products.SingleOrDefault(p => p.Id == id);
            if (product == null)
                return NotFound();
            return Ok(Mapper.Map<Products, ProductDtos>(product));
        }

        //SaveProduct
        [HttpPost]
        public IHttpActionResult saveProduct(ProductDtos productDtos)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var productInDb = Mapper.Map<ProductDtos, Products>(productDtos);
            _context.Products.Add(productInDb);
            _context.SaveChanges();
            productDtos.Id=productInDb.Id;
            return Created(new Uri(Request.RequestUri + "/" + productDtos.Id),productDtos);
        }

        //Edit Product
        [HttpPut]
        public void editProduct(int id, ProductDtos productDtos)
        {
            if (!ModelState.IsValid)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }
            var productInDb = _context.Products.Single(p => p.Id == id);
            if (productInDb == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            var product = Mapper.Map(productDtos, productInDb);
            _context.SaveChanges();
        }

        //Delete Product
        [HttpDelete]
        public void deleteProduct(int id)
        {
            var productInDb = _context.Products.Single(p => p.Id == id);
            if (productInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            _context.Products.Remove(productInDb);
            _context.SaveChanges();
        }
    }
}
