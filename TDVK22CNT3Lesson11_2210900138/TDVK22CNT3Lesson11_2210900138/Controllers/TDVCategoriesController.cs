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
    public class TDVCategoriesController : Controller
    {
        private TDVK22CNT3Lesson11DbEntities db = new TDVK22CNT3Lesson11DbEntities();

        // GET: TDVCategories
        public ActionResult TDVIndex()
        {
            return View(db.TDVCategories.ToList());
        }

        // GET: TDVCategories/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TDVCategory tDVCategory = db.TDVCategories.Find(id);
            if (tDVCategory == null)
            {
                return HttpNotFound();
            }
            return View(tDVCategory);
        }

        // GET: TDVCategories/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TDVCategories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TDVId,TDVCateName,TDVStatus")] TDVCategory tDVCategory)
        {
            if (ModelState.IsValid)
            {
                db.TDVCategories.Add(tDVCategory);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tDVCategory);
        }

        // GET: TDVCategories/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TDVCategory tDVCategory = db.TDVCategories.Find(id);
            if (tDVCategory == null)
            {
                return HttpNotFound();
            }
            return View(tDVCategory);
        }

        // POST: TDVCategories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TDVId,TDVCateName,TDVStatus")] TDVCategory tDVCategory)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tDVCategory).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tDVCategory);
        }

        // GET: TDVCategories/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TDVCategory tDVCategory = db.TDVCategories.Find(id);
            if (tDVCategory == null)
            {
                return HttpNotFound();
            }
            return View(tDVCategory);
        }

        // POST: TDVCategories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TDVCategory tDVCategory = db.TDVCategories.Find(id);
            db.TDVCategories.Remove(tDVCategory);
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
    }
}
