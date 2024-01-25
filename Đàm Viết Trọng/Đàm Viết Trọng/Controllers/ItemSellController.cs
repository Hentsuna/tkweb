using Đàm_Viết_Trọng.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Đàm_Viết_Trọng.Controllers
{
    public class ItemSellController : Controller
    {
        // GET: ItemSell
        public ActionResult Index()
        {
            List<Item> items = new List<Item>()
            {
                new Item(00,"Solo Leveling","Image1"),
                new Item(01, "Rave","Image2"),
                new Item(02, "One Punch","Image3"),
            };
            return View(items);
        }
        public ActionResult Details()
        {
            List<Item> items = new List<Item>()
            {
                new Item(00,"Solo Leveling","Image1"),
            };
            return View(items);
        }
    }
}