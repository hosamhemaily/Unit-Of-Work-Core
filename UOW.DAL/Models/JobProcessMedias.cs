using System;
using System.Collections.Generic;

namespace UOW.DAL.Models
{
    public partial class JobProcessMedias
    {
        public long JobProcessMediaId { get; set; }
        public long JobProcessId { get; set; }
        public long MediaFileId { get; set; }
        public bool? IsFloorPlan { get; set; }

        public virtual JobProcesses JobProcess { get; set; }
        public virtual MediaFiles MediaFile { get; set; }
    }
}
