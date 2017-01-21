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

        //Get Create - send the view with the little  boxes
        [HttpGet]
        public ActionResult Create()
        {
            return View(); //Show the form (the little boxes)
        }

        //POST Create - Get the data, Work with the model to update the database with data from the form.
        [HttpPost]
        public ActionResult Create(Customer myCustomer)
        {
            //Add the new coustomer to my set Customers
            db.Customers.Add(myCustomer);

            //Update the database
            db.SaveChanges();   
            return View("Index", db.Customers); // Show the updaded Index page
        }
    }
}