using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_DataExploration.Models;

namespace MVC_DataExploration.Controllers
{
    public class CustomerController : Controller
    {
        private MyDbContext db = new MyDbContext();

        [HttpPost]
        public ActionResult create(Customer customer)
        {
            db.Customers.Add(customer);
            db.SaveChanges();
            return View("Index", db.Customers);
        }

        [HttpGet]
        public ActionResult create()
        {
            return View();
        }

        public ActionResult Index()
        {
            return View(db.Customers);
        }
    }
}