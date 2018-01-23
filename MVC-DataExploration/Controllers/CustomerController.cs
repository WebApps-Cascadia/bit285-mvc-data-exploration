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
            return View(db.Customers);
        }
        public ActionResult Create()
        {
            return View();
        }
        //POST: Customer
        [HttpPost]
        public ActionResult Create(Customer customer)
        {
            db.Customers.Add(customer);
            db.SaveChanges();
            return View("Index", db.Customers);
        }
    }
}