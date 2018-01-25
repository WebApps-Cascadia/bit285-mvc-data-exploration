using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_DataExploration.Controllers
{
    public class ProductController : Controller
    {
        Models.Product Product;
        //I need something here to pass to the Index Method to return in the View() Parameter slot 
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }
    }
}

