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

        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }
        // GET: 
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
      public  ActionResult Create(Customer customer)
        {
           try
            {
                db.Customers.Add(customer);
                db.SaveChanges();
                return RedirectToAction("Index", db.Customers);
           }
           catch
           {
               return View();
           }
          
        }
    }
}