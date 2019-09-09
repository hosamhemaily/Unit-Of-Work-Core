using System;
using System.Collections.Generic;

namespace UOW.DAL.Models
{
    public partial class Addresses
    {
        public Addresses()
        {
            Articles = new HashSet<Articles>();
            Offices = new HashSet<Offices>();
            UserProfiles = new HashSet<UserProfiles>();
        }

        public long AddressId { get; set; }
        public string Organisation { get; set; }
        public string BuildingNameOrNumber { get; set; }
        public int FloorNumber { get; set; }
        public long PostcodeId { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }

        public virtual Postcodes Postcode { get; set; }
        public virtual ICollection<Articles> Articles { get; set; }
        public virtual ICollection<Offices> Offices { get; set; }
        public virtual ICollection<UserProfiles> UserProfiles { get; set; }
    }
}
