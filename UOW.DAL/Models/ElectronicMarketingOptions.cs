using System;
using System.Collections.Generic;

namespace UOW.DAL.Models
{
    public partial class ElectronicMarketingOptions
    {
        public ElectronicMarketingOptions()
        {
            CustomerElectronicMarktOpts = new HashSet<CustomerElectronicMarktOpts>();
        }

        public long ElectronicMarketingOptionId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<CustomerElectronicMarktOpts> CustomerElectronicMarktOpts { get; set; }
    }
}
