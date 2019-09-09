using System;
using System.Collections.Generic;

namespace UOW.DAL.Models
{
    public partial class EmailOptions
    {
        public EmailOptions()
        {
            CustomerEmailOpts = new HashSet<CustomerEmailOpts>();
        }

        public long EmailOptionId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<CustomerEmailOpts> CustomerEmailOpts { get; set; }
    }
}
