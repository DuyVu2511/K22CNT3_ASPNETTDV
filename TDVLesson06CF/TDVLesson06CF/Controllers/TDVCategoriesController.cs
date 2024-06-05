
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TDVLesson06CF.Models;

namespace TDVLesson06CF.Controllers
{
    public class TDVCategoriesController : Controller
    {
        private static TDVBookStore tdvDb;
        public TDVCategoriesController()
        {
            tdvDb = new TDVBookStore();
        }
        // GET: TDVCategories
        public ActionResult TDVIndex()
        {

            /*
             * Khoi tao DbContext:
             * EF se tim thong tin ket noi trong file machinee.config cua NET Framework tren may
             * 
             * */
            //TDVBookStore tdvDb = new TDVBookStore();
            var tdvCategories = tdvDb.TDVCategories.ToList();
            return View(tdvCategories);
        }
        public ActionResult TDVCreate()
        {
            var tdvCategory = new TDVCategory();
            return View(tdvCategory);
        }
        [HttpPost]
        public ActionResult TDVCreate(TDVCategory tdvCategory)
        {
            tdvDb.TDVCategories.Add(tdvCategory);
            tdvDb.SaveChanges();
            return RedirectToAction("TDVIndex");
        }
    }
}