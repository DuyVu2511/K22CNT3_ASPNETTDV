using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TDV.Lesson02.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products ~ http://localhost:port/products
        public ActionResult Index()
        {
            ViewBag.name = "Duy Vu - 2210900138";
            return View();
        }

        public ActionResult Details(int? id)
        {
            ViewBag.id = id;
            return View();
        }

        public string GetName()
        {
            return "Tran Duy Vu - 2210900138";
        }
        public JsonResult ListName()
        {
            string[] names = { "Hung", "Dung", "Sang", "Trong" };

            return Json(names, JsonRequestBehavior.AllowGet);
        }
    }
}