using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TDVLesson09.Models;

namespace TDVLesson09.Controllers
{
    public class TDVMonHocsController : Controller
    {
        private TDVK22CNT3Lesson09DbEntities2 db = new TDVK22CNT3Lesson09DbEntities2();

        // GET: TDVMonHocs
        public ActionResult TDVIndex()
        {
            return View(db.TDVMonHocs.ToList());
        }

        // GET: TDVMonHocs/Details/5
        public ActionResult TDVDetails(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TDVMonHoc tDVMonHoc = db.TDVMonHocs.Find(id);
            if (tDVMonHoc == null)
            {
                return HttpNotFound();
            }
            return View(tDVMonHoc);
        }

        // GET: TDVMonHocs/Create
        public ActionResult TDVCreate()
        {
            return View();
        }

        // POST: TDVMonHocs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult TDVCreate([Bind(Include = "TDVMaMH,TDVTenMH,TDVSotiet")] TDVMonHoc tDVMonHoc)
        {
            if (ModelState.IsValid)
            {
                db.TDVMonHocs.Add(tDVMonHoc);
                db.SaveChanges();
                return RedirectToAction("TDVIndex");
            }

            return View(tDVMonHoc);
        }

        // GET: TDVMonHocs/Edit/5
        public ActionResult TDVEdit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TDVMonHoc tDVMonHoc = db.TDVMonHocs.Find(id);
            if (tDVMonHoc == null)
            {
                return HttpNotFound();
            }
            return View(tDVMonHoc);
        }

        // POST: TDVMonHocs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult TDVEdit([Bind(Include = "TDVMaMH,TDVTenMH,TDVSotiet")] TDVMonHoc tDVMonHoc)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tDVMonHoc).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("TDVIndex");
            }
            return View(tDVMonHoc);
        }

        // GET: TDVMonHocs/Delete/5
        public ActionResult TDVDelete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TDVMonHoc tDVMonHoc = db.TDVMonHocs.Find(id);
            if (tDVMonHoc == null)
            {
                return HttpNotFound();
            }
            return View(tDVMonHoc);
        }

        // POST: TDVMonHocs/Delete/5
        [HttpPost, ActionName("TDVDelete")]
        [ValidateAntiForgeryToken]
        public ActionResult TDVDeleteConfirmed(string id)
        {
            TDVMonHoc tDVMonHoc = db.TDVMonHocs.Find(id);
            db.TDVMonHocs.Remove(tDVMonHoc);
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
