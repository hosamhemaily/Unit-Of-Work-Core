using System;
using System.Collections.Generic;

namespace UOW.DAL.Models
{
    public partial class CustomerEmailOpts
    {
        public long CustomerEmailOptId { get; set; }
        public long CustomerId { get; set; }
        public long EmailOptionId { get; set; }

        public virtual Customers Customer { get; set; }
        public virtual EmailOptions EmailOption { get; set; }
    }
}
