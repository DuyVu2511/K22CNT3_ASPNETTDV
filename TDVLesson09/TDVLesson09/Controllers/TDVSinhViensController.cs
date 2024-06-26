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
    public class TDVSinhViensController : Controller
    {
        private TDVK22CNT3Lesson09DbEntities2 db = new TDVK22CNT3Lesson09DbEntities2();

        // GET: TDVSinhViens
        public ActionResult TDVIndex()
        {
            var tDVSinhViens = db.TDVSinhViens.Include(t => t.TDVKhoa);
            return View(tDVSinhViens.ToList());
        }

        // GET: TDVSinhViens/Details/5
        public ActionResult TDVDetails(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TDVSinhVien tDVSinhVien = db.TDVSinhViens.Find(id);
            if (tDVSinhVien == null)
            {
                return HttpNotFound();
            }
            return View(tDVSinhVien);
        }

        // GET: TDVSinhViens/Create
        public ActionResult TDVCreate()
        {
            ViewBag.TDVMaKH = new SelectList(db.TDVKhoas, "TDVMaKH", "TDVTenKH");
            return View();
        }

        // POST: TDVSinhViens/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult TDVCreate([Bind(Include = "TDVMaSV,TDVHoSV,TDVTenSV,TDVPhai,TDVNgaySinh,TDVNoiSinh,TDVMaKH,TDVHocBong,TDVDiemTrungBinh")] TDVSinhVien tDVSinhVien)
        {
            if (ModelState.IsValid)
            {
                db.TDVSinhViens.Add(tDVSinhVien);
                db.SaveChanges();
                return RedirectToAction("TDVIndex");
            }

            ViewBag.TDVMaKH = new SelectList(db.TDVKhoas, "TDVMaKH", "TDVTenKH", tDVSinhVien.TDVMaKH);
            return View(tDVSinhVien);
        }

        // GET: TDVSinhViens/Edit/5
        public ActionResult TDVEdit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TDVSinhVien tDVSinhVien = db.TDVSinhViens.Find(id);
            if (tDVSinhVien == null)
            {
                return HttpNotFound();
            }
            ViewBag.TDVMaKH = new SelectList(db.TDVKhoas, "TDVMaKH", "TDVTenKH", tDVSinhVien.TDVMaKH);
            return View(tDVSinhVien);
        }

        // POST: TDVSinhViens/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult TDVEdit([Bind(Include = "TDVMaSV,TDVHoSV,TDVTenSV,TDVPhai,TDVNgaySinh,TDVNoiSinh,TDVMaKH,TDVHocBong,TDVDiemTrungBinh")] TDVSinhVien tDVSinhVien)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tDVSinhVien).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("TDVIndex");
            }
            ViewBag.TDVMaKH = new SelectList(db.TDVKhoas, "TDVMaKH", "TDVTenKH", tDVSinhVien.TDVMaKH);
            return View(tDVSinhVien);
        }

        // GET: TDVSinhViens/Delete/5
        public ActionResult TDVDelete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TDVSinhVien tDVSinhVien = db.TDVSinhViens.Find(id);
            if (tDVSinhVien == null)
            {
                return HttpNotFound();
            }
            return View(tDVSinhVien);
        }

        // POST: TDVSinhViens/Delete/5
        [HttpPost, ActionName("TDVDelete")]
        [ValidateAntiForgeryToken]
        public ActionResult TDVDeleteConfirmed(string id)
        {
            TDVSinhVien tDVSinhVien = db.TDVSinhViens.Find(id);
            db.TDVSinhViens.Remove(tDVSinhVien);
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
