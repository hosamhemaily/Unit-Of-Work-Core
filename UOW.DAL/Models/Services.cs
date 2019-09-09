using System;
using System.Collections.Generic;

namespace UOW.DAL.Models
{
    public partial class Services
    {
        public Services()
        {
            Jobs = new HashSet<Jobs>();
        }

        public long ServiceId { get; set; }
        public long AccountId { get; set; }
        public string ServiceName { get; set; }
        public string Description { get; set; }
        public string Notes { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public Guid ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsActive { get; set; }

        public virtual Accounts Account { get; set; }
        public virtual ICollection<Jobs> Jobs { get; set; }
    }
}
