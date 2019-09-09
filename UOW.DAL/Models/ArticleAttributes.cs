using System;
using System.Collections.Generic;

namespace UOW.DAL.Models
{
    public partial class ArticleAttributes
    {
        public long Id { get; set; }
        public long ArticleId { get; set; }
        public long AttributeId { get; set; }
        public string Value { get; set; }
        public DateTime ApplyDate { get; set; }

        public virtual Articles Article { get; set; }
        public virtual Attributes Attribute { get; set; }
    }
}
