using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Inventory_System.Models;
using System.Data.Entity;
using Inventory_System.Models.Coder_Created;

namespace Inventory_System.Controllers
{
    public class ProductsController : Controller
    {
        //
        // GET: /Products/
        public ActionResult GetProducts()
        {
            if (User.IsInRole(RoleManager.CanManageData))
                return View("GetProducts");
            else
                return View("ReadOnlyList");
        }

        [Authorize(Roles=RoleManager.CanManageData)]
        public ActionResult SaveProducts()
        {
            return View();
        }
        [Authorize(Roles = RoleManager.CanManageData)]
        public ActionResult UpdateProduct()
        {

            return View();
        }
	}
}