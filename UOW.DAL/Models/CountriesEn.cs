using System;
using System.Collections.Generic;

namespace UOW.DAL.Models
{
    public partial class CountriesEn
    {
        public CountriesEn()
        {
            CountiesEn = new HashSet<CountiesEn>();
        }

        public long CountryEnId { get; set; }
        public string CountryName { get; set; }
        public string Iso2 { get; set; }
        public string Iso3 { get; set; }
        public int IsoNo { get; set; }

        public virtual ICollection<CountiesEn> CountiesEn { get; set; }
    }
}
