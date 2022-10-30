using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using BikeStoreSystem.Models;
using PagedList.Mvc;
using PagedList;
using System.Data;
using System.Data.Entity;


namespace BikeStoreSystem.Controllers
{
    public class ordersController : Controller
    {



        private BikeStoresEntities db = new BikeStoresEntities();

        public ActionResult Index(int? i)
        {
            var Orders = db.order_items.Include(n => n.product).Include(n=>n.order);
            return View(Orders.ToList().ToPagedList(i ?? 1, 10));
        }
    }
}