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
        
        //GET Create  - Sends view with boxes  to input
        [HttpGet]
        public ActionResult Create()
        {
            return View(); //Show the form
        }

        //POST Create - Work with the model to update database 
        [HttpPost]
        public ActionResult Create(Customer myCustomer)
        {
            //Add new customer to set of Customeers
            db.Customers.Add(myCustomer);
            //Updates the database
            db.SaveChanges();
            return View("Index", db.Customers); // Show updated Index Page
        }



    }
}