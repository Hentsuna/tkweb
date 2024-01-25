using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web_Topic1.Models
{
    public class List
    {
        public string Name { get; set; }
        public string Class { get; set; }
        public List(string n, string c) 
        {
            Name = n;
            Class = c;
        }
    }
}