using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ThiGKTrong_63135896.Models;

namespace ThiGKTrong_63135896.Controllers
{
    public class SinhVien_63135896Controller : Controller
    {
        private ThiGK_63135896Entities db = new ThiGK_63135896Entities();

        // GET: SinhVien_63135896
        public ActionResult DanhSach()
        {
            var dIEMDULICHes = db.DIEMDULICHes.Include(d => d.TINH_THANHPHO);
            return View(dIEMDULICHes.ToList());
        }

        // GET: SinhVien_63135896/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DIEMDULICH dIEMDULICH = db.DIEMDULICHes.Find(id);
            if (dIEMDULICH == null)
            {
                return HttpNotFound();
            }
            return View(dIEMDULICH);
        }

        // GET: SinhVien_63135896/Create
        public ActionResult ThemMoi()
        {
            ViewBag.Matinh_Thanhpho = new SelectList(db.TINH_THANHPHO, "Matinh", "Tentinh");
            return View();
        }

        // POST: SinhVien_63135896/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ThemMoi([Bind(Include = "Madiemdl,Tendiemdl,Ngaycapnhat,Mota,Anhdaidien,Matinh_Thanhpho")] DIEMDULICH dIEMDULICH)
        {
            if (ModelState.IsValid)
            {
                db.DIEMDULICHes.Add(dIEMDULICH);
                db.SaveChanges();
                return RedirectToAction("DanhSach");
            }

            ViewBag.Matinh_Thanhpho = new SelectList(db.TINH_THANHPHO, "Matinh", "Tentinh", dIEMDULICH.Matinh_Thanhpho);
            return View(dIEMDULICH);
        }

        // GET: SinhVien_63135896/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DIEMDULICH dIEMDULICH = db.DIEMDULICHes.Find(id);
            if (dIEMDULICH == null)
            {
                return HttpNotFound();
            }
            ViewBag.Matinh_Thanhpho = new SelectList(db.TINH_THANHPHO, "Matinh", "Tentinh", dIEMDULICH.Matinh_Thanhpho);
            return View(dIEMDULICH);
        }

        // POST: SinhVien_63135896/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Madiemdl,Tendiemdl,Ngaycapnhat,Mota,Anhdaidien,Matinh_Thanhpho")] DIEMDULICH dIEMDULICH)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dIEMDULICH).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("DanhSach");
            }
            ViewBag.Matinh_Thanhpho = new SelectList(db.TINH_THANHPHO, "Matinh", "Tentinh", dIEMDULICH.Matinh_Thanhpho);
            return View(dIEMDULICH);
        }

        // GET: SinhVien_63135896/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DIEMDULICH dIEMDULICH = db.DIEMDULICHes.Find(id);
            if (dIEMDULICH == null)
            {
                return HttpNotFound();
            }
            return View(dIEMDULICH);
        }

        // POST: SinhVien_63135896/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            DIEMDULICH dIEMDULICH = db.DIEMDULICHes.Find(id);
            db.DIEMDULICHes.Remove(dIEMDULICH);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult GioiThieu_63135896()
        {
            return View();
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
