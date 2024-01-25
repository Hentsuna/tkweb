using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_Topic1.Models;
using System.IO;

namespace Web_Topic1.Controllers
{
    public class DangKyController : Controller
    {
        // GET: DangKy
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(HttpPostedFileBase AnhDD, Sinhvien sv)
        {
            //Lấy đường dẫn
            string Avatar = System.IO.Path.GetFileName(AnhDD.FileName);
            //Lưu đường dẫn
            var path = Server.MapPath("/Images/" + Avatar);
            AnhDD.SaveAs(path);
            string fSave = Server.MapPath("/App_Data/emp.txt");
            string[] emInfo = { sv.MSSV, sv.Hoten, Avatar };
            System.IO.File.WriteAllLines(fSave, emInfo);
            ViewBag.MSSV = emInfo[0];
            ViewBag.Hoten = emInfo[1];
            ViewBag.AnhDD = "/Images/" + emInfo[2];
            return View("Confirm");
        }
        public ActionResult Confirm(Sinhvien sv)
        {  return View(); }
    }
}