using System;
using System.Collections.Generic;

namespace UOW.DAL.Models
{
    public partial class MarketingExclusionOptions
    {
        public MarketingExclusionOptions()
        {
            CustomerMarktExclusionOpts = new HashSet<CustomerMarktExclusionOpts>();
        }

        public long MarketingExclusionOptionId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<CustomerMarktExclusionOpts> CustomerMarktExclusionOpts { get; set; }
    }
}
