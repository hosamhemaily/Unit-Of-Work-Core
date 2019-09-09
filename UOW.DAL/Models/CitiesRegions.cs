using System;
using System.Collections.Generic;

namespace UOW.DAL.Models
{
    public partial class CitiesRegions
    {
        public long Id { get; set; }
        public long CityId { get; set; }
        public long RegionId { get; set; }

        public virtual CitiesEn City { get; set; }
        public virtual Regions Region { get; set; }
    }
}
