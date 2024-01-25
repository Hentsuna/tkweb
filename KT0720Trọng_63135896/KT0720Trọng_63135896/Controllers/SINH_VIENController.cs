using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using KT0720Trọng_63135896.Models;
using System.IO;

namespace KT0720Trọng_63135896.Controllers
{
    public class SINH_VIENController : Controller
    {
        private KT0720_63135896Entities db = new KT0720_63135896Entities();

        // GET: SINH_VIEN
        public async Task<ActionResult> Index()
        {
            var sINH_VIEN = db.SINH_VIEN.Include(s => s.LOP);
            return View(await sINH_VIEN.ToListAsync());
        }

        // GET: SINH_VIEN/Details/5
        public async Task<ActionResult> Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SINH_VIEN sINH_VIEN = await db.SINH_VIEN.FindAsync(id);
            if (sINH_VIEN == null)
            {
                return HttpNotFound();
            }
            return View(sINH_VIEN);
        }

        // GET: SINH_VIEN/Create
        public ActionResult Create()
        {
            ViewBag.Ma_lop = new SelectList(db.LOPs, "Ma_lop", "Ten_lop");
            return View();
        }

        // POST: SINH_VIEN/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Ma_sv,Ho_sv,Ten_sv,Ngay_sinh,Gioi_tinh,Anh_sv,Dia_chi,Ma_lop")] SINH_VIEN sINH_VIEN)
        {
            if (ModelState.IsValid)
            {
                var img = Request.Files["anh"];//lay thong tin file
                if (img.ContentLength != 0)
                {
                    string[] FileExtentions = new string[] { ".jpg", ".jpeg", ".png", ".gif" };
                    //kiem tra tap tin co hay khong
                    if (FileExtentions.Contains(img.FileName.Substring(img.FileName.LastIndexOf("."))))//lay phan mo rong cua tap tin
                    {
                        string imgName = sINH_VIEN.Ma_sv + img.FileName.Substring(img.FileName.LastIndexOf("."));
                        sINH_VIEN.Anh_sv = imgName;
                        //upload hinh
                        string PathDir = "~/Image/";
                        string PathFile = Path.Combine(Server.MapPath(PathDir), imgName);
                        img.SaveAs(PathFile);
                    }
                }//ket thuc phan upload hinh anh
                db.SINH_VIEN.Add(sINH_VIEN);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.Ma_lop = new SelectList(db.LOPs, "Ma_lop", "Ten_lop", sINH_VIEN.Ma_lop);
            return View(sINH_VIEN);
        }

        // GET: SINH_VIEN/Edit/5
        public async Task<ActionResult> Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SINH_VIEN sINH_VIEN = await db.SINH_VIEN.FindAsync(id);
            if (sINH_VIEN == null)
            {
                return HttpNotFound();
            }
            ViewBag.Ma_lop = new SelectList(db.LOPs, "Ma_lop", "Ten_lop", sINH_VIEN.Ma_lop);
            return View(sINH_VIEN);
        }

        // POST: SINH_VIEN/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Ma_sv,Ho_sv,Ten_sv,Ngay_sinh,Gioi_tinh,Anh_sv,Dia_chi,Ma_lop")] SINH_VIEN sINH_VIEN)
        {
            if (ModelState.IsValid)
            {
                var img = Request.Files["img"];//lay thong tin file
                if (img.ContentLength != 0)
                {
                    string[] FileExtentions = new string[] { ".jpg", ".jpeg", ".png", ".gif" };
                    //kiem tra tap tin co hay khong
                    if (FileExtentions.Contains(img.FileName.Substring(img.FileName.LastIndexOf("."))))//lay phan mo rong cua tap tin
                    {
                        string imgName = sINH_VIEN.Ma_sv + img.FileName.Substring(img.FileName.LastIndexOf("."));
                        sINH_VIEN.Anh_sv = imgName;
                        //upload hinh
                        string PathDir = "~/Image/";
                        string PathFile = Path.Combine(Server.MapPath(PathDir), imgName);
                        img.SaveAs(PathFile);
                    }
                }//ket thuc phan upload hinh anh
                db.Entry(sINH_VIEN).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.Ma_lop = new SelectList(db.LOPs, "Ma_lop", "Ten_lop", sINH_VIEN.Ma_lop);
            return View(sINH_VIEN);
        }

        // GET: SINH_VIEN/Delete/5
        public async Task<ActionResult> Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SINH_VIEN sINH_VIEN = await db.SINH_VIEN.FindAsync(id);
            if (sINH_VIEN == null)
            {
                return HttpNotFound();
            }
            return View(sINH_VIEN);
        }

        // POST: SINH_VIEN/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(string id)
        {
            SINH_VIEN sINH_VIEN = await db.SINH_VIEN.FindAsync(id);
            db.SINH_VIEN.Remove(sINH_VIEN);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public ActionResult GioiThieu_63135896()
        {
            return View();
        }

        public ActionResult TimKiem_63135896(string Ma_sv = "", string Ten_sv = "")
        {
            List<SINH_VIEN> sinhvien = db.SINH_VIEN.Where(m => m.Ma_sv.ToString().Contains(Ma_sv.ToString())).ToList();
            if (Ten_sv != "")
            {
                sinhvien = db.SINH_VIEN.Where(m => m.Ten_sv.Contains(Ten_sv.ToString().ToLower())).ToList();
            }
            ViewData.Model = sinhvien;
            return View();

        }
    }
}
