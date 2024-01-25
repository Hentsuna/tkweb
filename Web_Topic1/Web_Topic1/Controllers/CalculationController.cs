using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_Topic1.Models;

namespace Web_Topic1.Controllers
{
    public class CalculationController : Controller
    {
        // GET: Calculation
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult UseRequest()
        { return View(); }
        [HttpPost]
        public ActionResult UseRequest(string pt)
        {
            double a = double.Parse(Request["a"]);//Chuyển đổi chuỗi sang số thực
            double b = double.Parse(Request["b"]);
            pt = Request["pt"].ToString();
            switch (pt)
            {
                case "+": ViewBag.KQ = a + b; break;
                case "-": ViewBag.KQ = a - b; break;
                case "*": ViewBag.KQ = a * b; break;
                case "/":
                    if (b == 0) ViewBag.KQ = "Không chia được cho 0";
                    else ViewBag.KQ = a / b; break;
            }
            return View();
        }

        public ActionResult PTBac1() 
        { return View(); }
        [HttpPost]
        public ActionResult PTBac1(double a, double b)
        {
            a = double.Parse(Request["a"]);
            b = double.Parse(Request["b"]);
            if (a == 0)
            {
                ViewBag.KQ = "Vo so nghiem";
            }
            else ViewBag.KQ = -b / a;
            return View();
        }

        public ActionResult UseArguments()
        { return View(); }
        [HttpPost]
        public ActionResult UseArguments(double a, double b, string pt = "+")
        {
            switch (pt)
            {
                case "+": ViewBag.KQ = a + b; break;
                case "-": ViewBag.KQ = a - b; break;
                case "*": ViewBag.KQ = a * b; break;
                case "/":
                    if (b == 0) ViewBag.KQ = "Không chia được cho 0";
                    else ViewBag.KQ = a / b; break;
            }
            return View();
        }

        public ActionResult UseRequestForm()
        { return View(); }
        [HttpPost]
        public ActionResult UseRequestForm(double a, double b, string pt = "+")
        {
            a = double.Parse(Request.Form["a"]);
            b = double.Parse(Request.Form["b"]);
            pt = Request.Form["pt"].ToString();
            switch (pt)
            {
                case "+": ViewBag.KQ = a + b; break;
                case "-": ViewBag.KQ = a - b; break;
                case "*": ViewBag.KQ = a * b; break;
                case "/":
                    if (b == 0) ViewBag.KQ = "Không chia được cho 0";
                    else ViewBag.KQ = a / b; break;
            }
            return View();
        }

        public ActionResult UseModel() { return View(); }
        [HttpPost]
        public ActionResult UseModel(CalModels cal)
        {
            switch (cal.pt)
            {
                case "+": ViewBag.KQ = cal.a + cal.b; break;
                case "-": ViewBag.KQ = cal.a - cal.b; break;
                case "*": ViewBag.KQ = cal.a * cal.b; break;
                case "/":
                    if (cal.b == 0) ViewBag.KQ = "Không chia được cho 0";
                    else ViewBag.KQ = cal.a / cal.b; break;
            }
            return View();
        }

        public ActionResult PTBac1Model() { return View(); }
        [HttpPost]
        public ActionResult PTBac1Model(CalModels cal)
        {
            if (cal.a == 0)
            {
                ViewBag.KQ = "Vo so nghiem";
            }
            else ViewBag.KQ = -(cal.b) / cal.a;
            return View();
        }

        public ActionResult PTBac1Action() { return View(); }
        [HttpPost]
        public ActionResult PTBac1Action(double a, double b) 
        {
            if (a == 0)
            {
                ViewBag.KQ = "Vo so nghiem";
            }
            else ViewBag.KQ = -b / a;
            return View();
        }

        public ActionResult PTBac1ReForm() { return View(); }
        [HttpPost]
        public ActionResult PtBac1ReForm(double a, double b) 
        {
            a = double.Parse(Request.Form["a"]);
            b = double.Parse(Request.Form["b"]);
            if (a == 0)
            {
                ViewBag.KQ = "Vo so nghiem";
            }
            else ViewBag.KQ = -b / a;
            return View();
        }

        public ActionResult UseFormCollection()
        { return View(); }
        [HttpPost]
        public ActionResult UseFormCollection(FormCollection f)
        {
            double a = double.Parse(f["a"]);//Chuyển đổi chuỗi sang số thực
            double b = double.Parse(f["b"]);
            string pt = f["pt"].ToString();
            switch (pt)
            {
                case "+": ViewBag.KQ = a + b; break;
                case "-": ViewBag.KQ = a - b; break;
                case "*": ViewBag.KQ = a * b; break;
                case "/":
                    if (b == 0) ViewBag.KQ = "Không chia được cho 0";
                    else ViewBag.KQ = a / b; break;
            }
            return View();
        }

        public ActionResult PTBac1FormCol() { return View(); }
        [HttpPost]
        public ActionResult PTBac1FormCol(FormCollection f)
        {
            double a = double.Parse(f["a"]);
            double b = double.Parse(f["b"]);
            if (a == 0)
            {
                ViewBag.KQ = "Vo so nghiem";
            }
            else ViewBag.KQ = -b / a;
            return View();
        }

        public ActionResult Cal()
        { return View(); }
        [HttpPost]
        public ActionResult Cal(string i)
        { return View(); }
    }
}