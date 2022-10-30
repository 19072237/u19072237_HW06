using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BikeStoreSystem.Models;

namespace BikeStoreSystem.Controllers
{
    public class HomeController : Controller
    {

        private BikeStoresEntities db = new BikeStoresEntities();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Chart()
        {
            return View();
        }
    }
}