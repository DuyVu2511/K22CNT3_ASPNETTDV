using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TDVLesson06CF.Models;

namespace TDVLesson06CF.Controllers
{
    public class TDVBooksController : Controller
    {
        private TDVBookStore db = new TDVBookStore();

        // GET: TDVBooks
        public ActionResult Index()
        {
            return View(db.TDVBooks.ToList());
        }

        // GET: TDVBooks/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TDVBook tDVBook = db.TDVBooks.Find(id);
            if (tDVBook == null)
            {
                return HttpNotFound();
            }
            return View(tDVBook);
        }

        // GET: TDVBooks/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TDVBooks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TDVId,TDVBookId,TDVTitle,TDVAuthor,TDVYear,TDVPulisher,TDVPicture,TDVCategoryId")] TDVBook tDVBook)
        {
            if (ModelState.IsValid)
            {
                db.TDVBooks.Add(tDVBook);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tDVBook);
        }

        // GET: TDVBooks/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TDVBook tDVBook = db.TDVBooks.Find(id);
            if (tDVBook == null)
            {
                return HttpNotFound();
            }
            return View(tDVBook);
        }

        // POST: TDVBooks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TDVId,TDVBookId,TDVTitle,TDVAuthor,TDVYear,TDVPulisher,TDVPicture,TDVCategoryId")] TDVBook tDVBook)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tDVBook).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tDVBook);
        }

        // GET: TDVBooks/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TDVBook tDVBook = db.TDVBooks.Find(id);
            if (tDVBook == null)
            {
                return HttpNotFound();
            }
            return View(tDVBook);
        }

        // POST: TDVBooks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TDVBook tDVBook = db.TDVBooks.Find(id);
            db.TDVBooks.Remove(tDVBook);
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
