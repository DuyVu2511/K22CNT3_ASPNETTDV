using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab04.Models;

namespace TDV.Lab04.Controllers
{
    public class TDVCustomerController : Controller
    {
        // GET: TDVCustomer
        public ActionResult Index()
        {
            return View();
        }
        // GET: /Customer/CustomerDetail (action trả về thông tin chi tiết 1 khách hàng cho view CustomerDetail
        public ActionResult TDVCustomerDetail()
        {
            //tạo một đối tượng Customer
            TDVCustomer cus = new TDVCustomer()
            {
                CustomerId = "KH001",
                FullName = "Tran Duy Vu",
                Address = "Hà Nội",
                Email = "duyvutran2004@gmail.com",
                Phone = "0912345678",
                Balance = 9990000
            };
            //cách 1 gán dữ liệu vào ViewBag để chuyển tới View
            //ViewBag.customer = cus;
            //return View();
            //có thể truyền dữ liệu qua đối tượng model để chuyển tới View
            return View(cus);
        }
        //GET /Product/CustomerList (action trả về danh sách khách hàng cho view CustomerList)
        public ActionResult TDVCustomerList()
                {
        //tạo một danh sách khách hàng
        List<TDVCustomer> listcustomer = new List<TDVCustomer>(){
        new TDVCustomer(){ CustomerId = "KH001",
            FullName = "Tran Duy Vu",
            Address = "Hà Nội",Email = "duyvutran2004@gmail.com",
            Phone = "0912345678",Balance = 9990000},
        new TDVCustomer(){ CustomerId = "KH002", FullName = "Đỗ Thị Cúc",
            Address = "Hà Nội",Email = "cucdt@gmail.com",
            Phone = "0986.767.444",Balance = 2200000},
        new TDVCustomer(){ CustomerId = "KH003",
            FullName = "Nguyễn Tuấn Thắng",
            Address = "Nam Định",Email = "thangnt@gmail.com",
            Phone = "0924.656.542",Balance = 1200000},
        new TDVCustomer(){ CustomerId = "KH004", FullName = "Lê Ngọc Hải",
            Address = "Hà Nội",Email = "hailn@gmail.com",
            Phone = "0996.555.267",Balance = 6200000 }
        };
            //gán dữ liệu vào ViewBag để chuyển qua View
            ViewBag.listcustomer = listcustomer;
            return View();
        }
    }
}