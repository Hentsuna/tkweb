using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web_Topic1.Models
{
    public class Subject
    {
        public string Id {  get; set; }
        public string Name { get; set; }  
        public int Num { get; set; }
        public Subject(string i, string n, int nu) 
        {
            Id = i;Name = n;Num = nu;
        }
    }

    
}