using System;
using System.Collections.Generic;

namespace UOW.DAL.Models
{
    public partial class CustomerElectronicMarktOpts
    {
        public long CustomerElectronicMarktOptId { get; set; }
        public long CustomerId { get; set; }
        public long ElectronicMarketingOptionId { get; set; }

        public virtual Customers Customer { get; set; }
        public virtual ElectronicMarketingOptions ElectronicMarketingOption { get; set; }
    }
}
