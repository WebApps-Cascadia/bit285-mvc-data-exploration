using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//using System.Collections.ObjectModel.

namespace MVC_DataExploration.Controllers
{
    public class ProductController : Controller
    {
        //private MyDBContext db = new MyDBContext();
        
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }
    }
}