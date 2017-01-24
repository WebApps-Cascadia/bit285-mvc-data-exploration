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

        //GET: Create - sends the view with the little boxes
        [HttpGet]
        public ActionResult Create()
        {
            return View(); // Show the form (the little boxes)
        }


        //Post: Create - Get the data; Work with the model to update the database with data from the forms
        [HttpPost]
        public ActionResult Create(Customer myCustomer)
        {
            //Add new customer to my set of Customers
            db.Customers.Add(myCustomer);
            //Updates the database
            db.SaveChanges();
            return View("Index", db.Customers); // Show the updated Index Page
        }
    }
}