using System;
using System.Collections.Generic;

namespace UOW.DAL.Models
{
    public partial class Regions
    {
        public Regions()
        {
            AreasRegions = new HashSet<AreasRegions>();
            CitiesRegions = new HashSet<CitiesRegions>();
            CountiesRegions = new HashSet<CountiesRegions>();
            PostcodesRegions = new HashSet<PostcodesRegions>();
        }

        public long RegionId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<AreasRegions> AreasRegions { get; set; }
        public virtual ICollection<CitiesRegions> CitiesRegions { get; set; }
        public virtual ICollection<CountiesRegions> CountiesRegions { get; set; }
        public virtual ICollection<PostcodesRegions> PostcodesRegions { get; set; }
    }
}
