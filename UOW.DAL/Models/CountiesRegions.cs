using System;
using System.Collections.Generic;

namespace UOW.DAL.Models
{
    public partial class CountiesRegions
    {
        public long Id { get; set; }
        public long CountyId { get; set; }
        public long RegionId { get; set; }

        public virtual CountiesEn County { get; set; }
        public virtual Regions Region { get; set; }
    }
}
