using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TDV.Lesson04.Models;

namespace TDV.Lesson04.Controllers
{
    public class TDVCustomerController : Controller
    {
        // GET: TDVCustomer
        public ActionResult Index()
        {
            return View();
        }

        // Action: TDVCustomerDetail
        public ActionResult TDVCustomerDetail()
        {
            // Tao doi tuong du lieu
            var customer = new TDVCustomer()
            {
                CustomerId = 1,
                FirstName = "Tran Duy",
                LastName = "Vu",
                Address = "K22CNT3",
                YearOfBirth = 2004
            };
            ViewBag.customer = customer;

            return View();

           
        }
        // Get: TDVListCustomer
        public ActionResult TDVListCustomer()
        {
            var list = new List<TDVCustomer>()
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
            //ViewBag.list = list; // Dua du lieu ra view bang doi tuong ViewBag
            return View(list);
        }

    }
}