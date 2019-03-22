using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Inventory_System.Models.Coder_Created;
namespace Inventory_System.Controllers
{
    public class OrderController : Controller
    {
        //
        // GET: /Order/
        public ActionResult GetOrders()
        {
            if (User.IsInRole(RoleManager.CanManageData))
                return View("GetOrders");
            else
                return View("ReadOnlyList");
        }

        [Authorize(Roles = RoleManager.CanManageData)]
        public ActionResult NewOrder()
        {
            return View();
        }

        [Authorize(Roles = RoleManager.CanManageData)]
        public ActionResult OrderDetails()
        {
            return View();
        }
	}
}