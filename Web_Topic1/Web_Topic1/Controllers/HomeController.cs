using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web_Topic1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public string Index(string id)
        {
            return ("Xin chap cac ban lop " + id);
        }

        public ActionResult Greeting() 
        {
            return View();
        }

        public ActionResult List()
        {
            return View();
        }

        public ActionResult cal(double a = 0, double b = 0, string pt = "+") 
        {
            switch (pt)
            {
                case "+": ViewBag.KQ = a + b; break;
                case "-": ViewBag.KQ = a - b; break;
                case "*": ViewBag.KQ = a * b; break;
                case "/":
                    if(b == 0) ViewBag.KQ = "Error";
                    else ViewBag.KQ = a / b;
                    break;
            }
            return View();
        }
    }
}