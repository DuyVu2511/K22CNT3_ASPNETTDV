using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TDVK22CNT3Lesson10.Models;

namespace TDVK22CNT3Lesson10.Controllers
{
    public class TDVAccountsController : Controller
    {
        private TDVK22CNT3Lesson10Entities db = new TDVK22CNT3Lesson10Entities();

        // GET: TDVAccounts
        public ActionResult Index()
        {
            return View(db.TDVAccounts.ToList());
        }

        // GET: TDVAccounts/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TDVAccount tDVAccount = db.TDVAccounts.Find(id);
            if (tDVAccount == null)
            {
                return HttpNotFound();
            }
            return View(tDVAccount);
        }

        // GET: TDVAccounts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TDVAccounts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TDVId,TDVUserName,TDVPassword,TDVFullName,TDVEmail,TDVActive")] TDVAccount tDVAccount)
        {
            if (ModelState.IsValid)
            {
                db.TDVAccounts.Add(tDVAccount);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tDVAccount);
        }

        // GET: TDVAccounts/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TDVAccount tDVAccount = db.TDVAccounts.Find(id);
            if (tDVAccount == null)
            {
                return HttpNotFound();
            }
            return View(tDVAccount);
        }

        // POST: TDVAccounts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TDVId,TDVUserName,TDVPassword,TDVFullName,TDVEmail,TDVActive")] TDVAccount tDVAccount)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tDVAccount).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tDVAccount);
        }

        // GET: TDVAccounts/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TDVAccount tDVAccount = db.TDVAccounts.Find(id);
            if (tDVAccount == null)
            {
                return HttpNotFound();
            }
            return View(tDVAccount);
        }

        // POST: TDVAccounts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            TDVAccount tDVAccount = db.TDVAccounts.Find(id);
            db.TDVAccounts.Remove(tDVAccount);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
        //Login
        public ActionResult TDVLogin()
        {
            var tdvModel = new TDVAccount();
            return View(tdvModel);
        }
        [HttpPost]
        public ActionResult TDVLogin(TDVAccount tdvAccount)
        {
            var tdvCheck = db.TDVAccounts.Where(x => x.TDVUserName.Equals(tdvAccount.TDVUserName) && x.TDVPassword.Equals(tdvAccount.TDVPassword)).FirstOrDefault();
            if(tdvCheck != null)
            {
                // Luu session
                Session["TDVAccount"] = tdvCheck;
                return Redirect("/");
            }
            return View(tdvAccount);
        }
    }
}
