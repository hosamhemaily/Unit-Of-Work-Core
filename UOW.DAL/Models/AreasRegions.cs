using System;
using System.Collections.Generic;

namespace UOW.DAL.Models
{
    public partial class AreasRegions
    {
        public long Id { get; set; }
        public long AreaId { get; set; }
        public long RegionId { get; set; }

        public virtual AreasEn Area { get; set; }
        public virtual Regions Region { get; set; }
    }
}
