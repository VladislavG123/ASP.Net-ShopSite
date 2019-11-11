using ShopSite.DataAccess;
using ShopSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShopSite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            using (var context = new ShopContext())
            {
                ViewBag.Products = context.Products.ToList();
            }

            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateProduct(string name, int price, string description)
        {
            using (var context = new ShopContext())
            {
                context.Products.Add(new Product() { Name = name, Description = description, Price = price });
                context.SaveChanges();
                ViewBag.Products = context.Products.ToList();
            }

            return View("Index");
        }
    }
}