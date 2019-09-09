using System;
using System.Collections.Generic;

namespace UOW.DAL.Models
{
    public partial class RenderMedias
    {
        public int RenderMediaId { get; set; }
        public int ArticleId { get; set; }
        public int MediaId { get; set; }
        public int OrderInVideo { get; set; }
        public string Url { get; set; }
        public string Caption { get; set; }
        public int Category { get; set; }
    }
}
