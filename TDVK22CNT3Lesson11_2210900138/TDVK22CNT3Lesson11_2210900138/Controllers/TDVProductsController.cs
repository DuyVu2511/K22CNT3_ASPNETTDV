using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TDVK22CNT3Lesson11_2210900138.Models;

namespace TDVK22CNT3Lesson11_2210900138.Controllers
{
    public class TDVProductsController : Controller
    {
        private TDVK22CNT3Lesson11DbEntities db = new TDVK22CNT3Lesson11DbEntities();

        // GET: TDVProducts
        public ActionResult TDVIndex()
        {
            var tDVProducts = db.TDVProducts.Include(t => t.TDVCategory);
            return View(tDVProducts.ToList());
        }

        // GET: TDVProducts/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TDVProduct tDVProduct = db.TDVProducts.Find(id);
            if (tDVProduct == null)
            {
                return HttpNotFound();
            }
            return View(tDVProduct);
        }

        // GET: TDVProducts/Create
        public ActionResult Create()
        {
            ViewBag.TDVCateId = new SelectList(db.TDVCategories, "TDVId", "TDVCateName");
            return View();
        }

        // POST: TDVProducts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TDVId2210900138,TDVProName,TDVQty,TDVPrice,TDVCateId,TDVActive")] TDVProduct tDVProduct)
        {
            if (ModelState.IsValid)
            {
                db.TDVProducts.Add(tDVProduct);
                db.SaveChanges();
                return RedirectToAction("TDVIndex");
            }

            ViewBag.TDVCateId = new SelectList(db.TDVCategories, "TDVId", "TDVCateName", tDVProduct.TDVCateId);
            return View(tDVProduct);
        }

        // GET: TDVProducts/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TDVProduct tDVProduct = db.TDVProducts.Find(id);
            if (tDVProduct == null)
            {
                return HttpNotFound();
            }
            ViewBag.TDVCateId = new SelectList(db.TDVCategories, "TDVId", "TDVCateName", tDVProduct.TDVCateId);
            return View(tDVProduct);
        }

        // POST: TDVProducts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TDVId2210900138,TDVProName,TDVQty,TDVPrice,TDVCateId,TDVActive")] TDVProduct tDVProduct)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tDVProduct).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("TDVIndex");
            }
            ViewBag.TDVCateId = new SelectList(db.TDVCategories, "TDVId", "TDVCateName", tDVProduct.TDVCateId);
            return View(tDVProduct);
        }

        // GET: TDVProducts/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TDVProduct tDVProduct = db.TDVProducts.Find(id);
            if (tDVProduct == null)
            {
                return HttpNotFound();
            }
            return View(tDVProduct);
        }

        // POST: TDVProducts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            TDVProduct tDVProduct = db.TDVProducts.Find(id);
            db.TDVProducts.Remove(tDVProduct);
            db.SaveChanges();
            return RedirectToAction("TDVIndex");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
