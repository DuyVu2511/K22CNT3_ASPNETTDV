using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TDVK22CNT3Lesson10.Models;

namespace TDVK22CNT3Lesson10.Controllers
{
    public class TDVHomeController : Controller
    {
        public ActionResult TDVIndex()
        {
            //Kieu du lieu trong session
            if (Session["TDVAccount"] != null)
            {
                var tdvAccount = Session["TDVAccount"] as TDVAccount;
                ViewBag.FullName = tdvAccount.TDVFullName;
            }
            return View();
        }

        public ActionResult TDVAbout()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult TDVContact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}