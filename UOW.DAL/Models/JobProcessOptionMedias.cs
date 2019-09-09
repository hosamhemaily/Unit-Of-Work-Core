using System;
using System.Collections.Generic;

namespace UOW.DAL.Models
{
    public partial class JobProcessOptionMedias
    {
        public long Id { get; set; }
        public long JobProcessOptionId { get; set; }
        public long MediaFileId { get; set; }
        public bool? IsFloorPlan { get; set; }

        public virtual JobProcessOptions JobProcessOption { get; set; }
        public virtual MediaFiles MediaFile { get; set; }
    }
}
