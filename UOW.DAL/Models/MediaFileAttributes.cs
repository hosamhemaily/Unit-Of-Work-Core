using System;
using System.Collections.Generic;

namespace UOW.DAL.Models
{
    public partial class MediaFileAttributes
    {
        public long Id { get; set; }
        public long MediaFileId { get; set; }
        public long AttributeId { get; set; }
        public string Value { get; set; }

        public virtual Attributes Attribute { get; set; }
        public virtual MediaFiles MediaFile { get; set; }
    }
}
