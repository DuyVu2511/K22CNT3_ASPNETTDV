using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TDV.Lesson03.Controllers
{
    // <sumamry>
    // Author: Tran Duy Vu
    // Class: K22CNT3
    // </summary>
    public class TDVStudentController : Controller
    {
        // GET: TDVStudent
        public ActionResult Index()
        {
            //Truyen du lieu tu Controller -> View
            ViewBag.fullName = "Tran Duy Vu";
            ViewData["Birthday"] = "25/11/2004";
            TempData["Phone"] = "0915975936";
            return View();
        }

        public ActionResult Details()
        {
            string tdvStr = "";
            tdvStr += "<h3 Ho va ten: Tran Duy Vu </h3>";
            tdvStr += "<p> Ma so: 2210900138";
            tdvStr += "<p> Dia chi gmail: duyvutran2004@gmail.com";

            ViewBag.Details = tdvStr;

            return View("chiTiet");
        }

        public ActionResult NgonNguRazor()
        {
            string[] names = { "Tran Van A", "Nguyen Thi B", "Le Dai C", "Trinh Le D" };
            ViewBag.names = names;
            return View();
        }
        
        //HTMLHelper
        //GET: TDVStudent/AddNewStudent
        public ActionResult AddNewStudent()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddNewStudent(FormCollection form)
        {
            // lay du lieu tren form
            string fullname = form["fullName"];
            string masv = form["maSV"];
            string TaiKhoan = form["TaiKhoan"];
            string MatKhau = form["MatKhau"];

            string tdvStr = "<h3>" + fullname + "</h3>";
            tdvStr += "<p>" + masv;
            tdvStr += "<p> " + TaiKhoan;
            tdvStr += "<p> " + MatKhau;

            ViewBag.info = tdvStr;

            return View("Ketqua");
        }
    }
}