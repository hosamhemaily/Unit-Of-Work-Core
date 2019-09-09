using System;
using System.Collections.Generic;

namespace UOW.DAL.Models
{
    public partial class AreasEn
    {
        public AreasEn()
        {
            AreaAttributes = new HashSet<AreaAttributes>();
            AreasRegions = new HashSet<AreasRegions>();
            Postcodes = new HashSet<Postcodes>();
        }

        public long AreaEnId { get; set; }
        public long CityId { get; set; }
        public string Name { get; set; }

        public virtual CitiesEn City { get; set; }
        public virtual ICollection<AreaAttributes> AreaAttributes { get; set; }
        public virtual ICollection<AreasRegions> AreasRegions { get; set; }
        public virtual ICollection<Postcodes> Postcodes { get; set; }
    }
}
