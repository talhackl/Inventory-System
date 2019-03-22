using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Inventory_System.Models.Coder_Created;

namespace Inventory_System.Controllers
{
    public class CustomersController : Controller
    {
        //
        // GET: /Customers/
        public ActionResult GetCustomers()
        {
            if (User.IsInRole(RoleManager.CanManageData))
                return View("GetCustomers");
            else
                return View("ReadOnlyList");
        }
        [Authorize(Roles=RoleManager.CanManageData)]
        public ActionResult SaveCustomers()
        {
            return View();
        }

        [Authorize(Roles = RoleManager.CanManageData)]
        public ActionResult UpdateCustomer()
        {
            return View();
        }
	}
}