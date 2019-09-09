using System;
using System.Collections.Generic;

namespace UOW.DAL.Models
{
    public partial class Airlines
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Iatadesignator { get; set; }
        public int? Code { get; set; }
        public string Icaodesignator { get; set; }
        public string Country { get; set; }
    }
}
