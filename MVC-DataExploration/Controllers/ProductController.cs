using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace MVC_DataExploration.Controllers
{
    public class ProductController : Controller
    {
        private MyDBContext db = new MyDBContext();
        // GET: Product
        public ActionResult Index()
        {         
            return View(db.Products);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Product myProduct)
        {
            db.Products.Add(myProduct);

            db.SaveChanges();

            return View("Index", db.Products);
        }
    }
}