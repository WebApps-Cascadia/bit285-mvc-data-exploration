using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_DataExploration.Controllers
{
    public class ProductController : Controller
    {
        MyDbContext 


        // GET: Product
        public ActionResult Index()
        {
            return View(MyDBDontext.db.Products);
        }
    }
}