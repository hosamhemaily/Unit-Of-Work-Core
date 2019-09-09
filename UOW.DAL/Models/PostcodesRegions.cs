using System;
using System.Collections.Generic;

namespace UOW.DAL.Models
{
    public partial class PostcodesRegions
    {
        public long Id { get; set; }
        public long PostcodeId { get; set; }
        public long RegionId { get; set; }

        public virtual Postcodes Postcode { get; set; }
        public virtual Regions Region { get; set; }
    }
}
