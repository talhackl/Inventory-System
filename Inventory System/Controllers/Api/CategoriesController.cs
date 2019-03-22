using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Inventory_System.Models;
using System.Data.Entity;

namespace Inventory_System.Controllers.Api
{
    public class CategoriesController : ApiController
    {
        private DataBaseFile _context;

        public CategoriesController()
        {
            _context = new DataBaseFile();
        }

        [HttpGet]
        public IHttpActionResult getCategories()
        {
            var categories = _context.Categories.ToList();
            return Ok(categories);
        }



    }
}
