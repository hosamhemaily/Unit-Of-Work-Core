using System;
using System.Collections.Generic;

namespace UOW.DAL.Models
{
    public partial class CitiesEn
    {
        public CitiesEn()
        {
            AreasEn = new HashSet<AreasEn>();
            CitiesRegions = new HashSet<CitiesRegions>();
        }

        public long CityEnId { get; set; }
        public long CountyId { get; set; }
        public string Name { get; set; }

        public virtual CountiesEn County { get; set; }
        public virtual ICollection<AreasEn> AreasEn { get; set; }
        public virtual ICollection<CitiesRegions> CitiesRegions { get; set; }
    }
}
