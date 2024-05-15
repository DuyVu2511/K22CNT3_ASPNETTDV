using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TDV.Lesson04.Models;

namespace TDV.Lesson04.Models
{
    public class TDVCustomScraffdingController : Controller
    {
        //mockdata
        private static List<TDVCustomer> listCustomer = new List<TDVCustomer>()
                {
                    new TDVCustomer()
                    {
                        CustomerId = 1,
                        FirstName = "Tran Duy",
                        LastName = "Vu",
                        Address = "K22CNT3",
                        YearOfBirth = 2004
                    },
                    new TDVCustomer()
                    {
                        CustomerId = 2,
                        FirstName = "Tran Duy",
                        LastName = "Hung",
                        Address = "K22CNT3",
                        YearOfBirth = 2004
                    },
                        new TDVCustomer()
                        {
                        CustomerId = 3,
                        FirstName = "Tran Duy",
                        LastName = "Hung 1",
                        Address = "K22CNT3",
                        YearOfBirth = 2004
                    },
                       new TDVCustomer()
                    {
                        CustomerId = 4,
                        FirstName = "Tran Duy",
                        LastName = "Hung 2",
                        Address = "K22CNT3",
                        YearOfBirth = 2004
                    },
                };
        // GET: TDVCustomScraffding
        // listcustomer
        public ActionResult Index()
        {
            return View(listCustomer);
        }
        [HttpGet]
        public ActionResult TDVCreate()
        {
            var model = new TDVCustomer();
            return View(model);
        }
        [HttpPost]
        public ActionResult TDVCreate(TDVCustomer model)
        {
            //Them moi doi tuong khach hang vao ds du lieu
            listCustomer.Add(model);

            //return View(model);
            //Chuyen ve trang danh sach
            return RedirectToAction("Index");
        }   

        public ActionResult TDVEdit(int id)
        {
            var customer = listCustomer.FirstOrDefault(x => x.CustomerId == id);
            return View(customer);
        }
    }
}