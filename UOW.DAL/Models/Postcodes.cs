using System;
using System.Collections.Generic;

namespace UOW.DAL.Models
{
    public partial class Postcodes
    {
        public Postcodes()
        {
            Addresses = new HashSet<Addresses>();
            PostcodesRegions = new HashSet<PostcodesRegions>();
        }

        public long PostcodeId { get; set; }
        public long AreaId { get; set; }
        public string StreetName { get; set; }
        public int MeterNumber { get; set; }
        public string FullPostcode { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }

        public virtual AreasEn Area { get; set; }
        public virtual ICollection<Addresses> Addresses { get; set; }
        public virtual ICollection<PostcodesRegions> PostcodesRegions { get; set; }
    }
}
