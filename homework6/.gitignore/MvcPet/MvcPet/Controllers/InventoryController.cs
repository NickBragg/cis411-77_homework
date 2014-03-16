using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcPet.Utilities;

namespace MvcPet.Controllers
{
    public class InventoryController : Controller
    {
        private InventoryDisplay invDisplay = new InventoryDisplay();
        //
        // GET: /Inventory/
        public ActionResult Index()
        {
            return View(invDisplay.GetPetList());
        }
	}
}