using System;
using System.Collections.Generic;

namespace UOW.DAL.Models
{
    public partial class Airports
    {
        public long Id { get; set; }
        public string City { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string CountryAbbrev { get; set; }
        public int? WorldAreaCode { get; set; }
    }
}
