using System;
using System.Collections.Generic;
using System.Text;

namespace UOW.Model
{
    public class ArticleFilter:PageFilter
    {
        public int id { get; set; }

        public string name { get; set; }
    }
}
