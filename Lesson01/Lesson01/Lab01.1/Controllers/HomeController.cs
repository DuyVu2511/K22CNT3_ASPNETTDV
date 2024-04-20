﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab01._1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            //Su dung ViewBag de dua du lieu ra View
            ViewBag.message = "Chao mung ban den voi ASP.NET MVC 5";
            return View();
        }
        public ActionResult About()
        {
            //Su dung ViewBag de dua du lieu ra View
            ViewBag.message = "Day la trang About";
            return View();
        }
    }
}