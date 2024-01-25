using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_Topic1.Models;

namespace Web_Topic1.Controllers
{
    public class SubjectController : Controller
    {
        // GET: Subject
        public ActionResult Index()
        {
            return View();
        }

        //
        public ContentResult Find(string id)
        {
            var ls = new List<Subject>()
            {
                new Subject("SOT355","Lap trinh Web",3),
                new Subject("SOT382","Tin hoc dai cuong",3),
                new Subject("AJD332","Giao duc the chat",2),
            };
            Subject s = new Subject("","",0);
            foreach (var i in ls)
            {
                if(id == i.Id)
                {
                    s = i;
                }
            }
            return Content(s.Id + s.Name + s.Num);
        }

        public ActionResult ViewBagObj(string Id)
        {
            ViewBag.Id = "";
            var sub = new List<SubjectModel>()
            {
                new SubjectModel("SOT355","Lap trinh Web",3),
                new SubjectModel("SOT382","Tin hoc dai cuong",3),
                new SubjectModel("AJD332","Giao duc the chat",2),
            };
            SubjectModel s = new SubjectModel("", "", 0);
            foreach(var i in sub)
            {
                if (i.Id == Id)
                {
                    ViewBag.Id = i.Id;
                    s = i;
                }
            }    
            ViewBag.Subject = s;
            return View();
        }        public ActionResult ViewBagList()
        {
            //var sub = new List<SubjectModel>()
            //@model List<Web_Topic1.Models.SubjectModel>
            var ls3 = new List<SubjectModel>()
            {
                new SubjectModel("SOT355","Lap trinh Web",3),
                new SubjectModel("SOT382","Tin hoc dai cuong",3),
                new SubjectModel("AJD332","Giao duc the chat",2),
                new SubjectModel("HTB234","Toan hoc dai cuong",3),
            };            ViewBag.List3 = ls3.FindAll(s=>s.Num == 3);            ViewBag.List = ls3;            return View();        }        public ActionResult List()
        {
            var list = new List<Subject>()
            {
                new Subject("SOT355","Lap trinh Web",3),
                new Subject("SOT382","Tin hoc dai cuong",3),
                new Subject("AJD332","Giao duc the chat",2),
                new Subject("HTB234","Toan hoc dai cuong",3),
            };

            var obj = new TwoList();
            obj.ls = list;
            obj.ls3 = list.FindAll(s => s.Num == 3);
            return View(obj);
        }

        public ActionResult ListRenderBody(string Id)
        {
            ViewBag.Id = "";
            var sub = new List<Subject>()
            {
                new Subject("SOT355","Lap trinh Web",3),
                new Subject("SOT382","Tin hoc dai cuong",3),
                new Subject("AJD332","Giao duc the chat",2),
            };
            Subject s = new Subject("", "", 0);
            foreach (var i in sub)
            {
                if (i.Id == Id)
                {
                    ViewBag.Id = i.Id;
                    s = i;
                }
            }
            ViewBag.Subject = s;
            return View();
        }
    }
}