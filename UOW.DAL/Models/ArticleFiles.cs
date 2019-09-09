using System;
using System.Collections.Generic;

namespace UOW.DAL.Models
{
    public partial class ArticleFiles
    {
        public long Id { get; set; }
        public long MediaFileId { get; set; }
        public long ArticleId { get; set; }
        public bool? IsDefault { get; set; }
        public bool? IsFloorPlan { get; set; }
        public bool IsShowreel { get; set; }
        public int ShowreelStatus { get; set; }
        public int OrderInVideo { get; set; }
        public int SortOrder { get; set; }

        public virtual Articles Article { get; set; }
        public virtual MediaFiles MediaFile { get; set; }
    }
}
