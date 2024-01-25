using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Đàm_Viết_Trọng.Models
{
    public class Item
    {
        public int id { get; set; }
        public string name { get; set; }
        public string Image { get; set; }
        public Item (int i, string n, string img)
        { id = i; name = n; Image = img; }
    }
}