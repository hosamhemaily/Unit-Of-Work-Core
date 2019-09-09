using System;
using System.Collections.Generic;

namespace UOW.DAL.Models
{
    public partial class AreaAttributes
    {
        public long Id { get; set; }
        public long AreaId { get; set; }
        public long AttributeId { get; set; }
        public string Value { get; set; }

        public virtual AreasEn Area { get; set; }
        public virtual Attributes Attribute { get; set; }
    }
}
