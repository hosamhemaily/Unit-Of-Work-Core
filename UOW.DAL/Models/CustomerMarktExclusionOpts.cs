using System;
using System.Collections.Generic;

namespace UOW.DAL.Models
{
    public partial class CustomerMarktExclusionOpts
    {
        public int CustomerMarktExclusionOptId { get; set; }
        public long CustomerId { get; set; }
        public long MarketingExclusionOptionId { get; set; }

        public virtual Customers Customer { get; set; }
        public virtual MarketingExclusionOptions MarketingExclusionOption { get; set; }
    }
}
