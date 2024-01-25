using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web_Topic1.Models
{
    public class SubjectModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public byte Num { get; set; }
        public SubjectModel(string i, string s, byte n)
        {
            Id = i; Name = s; Num = n;
        }

    }
}