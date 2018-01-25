using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_DataExploration.Controllers
{
    public class ProductController : Controller
    {
        // GET: ProductController
        public ActionResult Index(Models.Product mp)
        {
            return View();
        }
    }
}