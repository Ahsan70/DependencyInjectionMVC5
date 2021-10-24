﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DIWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductRepo _productRepo;
        public HomeController(IProductRepo productRepo)
        {
            _productRepo = productRepo;
            
        }
        public ActionResult Index()
        {
            ViewBag.msg = _productRepo.GetName();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}