﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_DataExploration.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index(db.Products)
        
        {
            return View();
        }
    }
}