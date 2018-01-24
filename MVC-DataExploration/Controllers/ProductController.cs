using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVC_DataExploration.Models;

namespace MVC_DataExploration.Controllers
{
    public class ProductController : Controller
    {
        private MyDBContext db = new MyDBContext();

        // GET: Product
        public ActionResult Index()
        {
            return View(db.Product);
        }
    }
}