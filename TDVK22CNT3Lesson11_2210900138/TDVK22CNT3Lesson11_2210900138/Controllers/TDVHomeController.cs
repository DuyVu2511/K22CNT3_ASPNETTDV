using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TDVK22CNT3Lesson11_2210900138.Controllers
{
    public class TDVHomeController : Controller
    {
        public ActionResult TDVIndex()
        {
            return View();
        }

        public ActionResult TDVAbout()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult TDVContact()
        {
            ViewBag.msv = "2210900138";
            ViewBag.fullname = "Tran Duy Vu";
            return View();
        }
    }
}