using System;
using System.Collections.Generic;

namespace UOW.DAL.Models
{
    public partial class CountiesEn
    {
        public CountiesEn()
        {
            CitiesEn = new HashSet<CitiesEn>();
            CountiesRegions = new HashSet<CountiesRegions>();
        }

        public long CountyEnId { get; set; }
        public long CountryId { get; set; }
        public string Name { get; set; }

        public virtual CountriesEn Country { get; set; }
        public virtual ICollection<CitiesEn> CitiesEn { get; set; }
        public virtual ICollection<CountiesRegions> CountiesRegions { get; set; }
    }
}
