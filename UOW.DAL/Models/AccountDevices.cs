using System;
using System.Collections.Generic;

namespace UOW.DAL.Models
{
    public partial class AccountDevices
    {
        public long Id { get; set; }
        public long AccountId { get; set; }
        public string DeviceId { get; set; }
        public string Name { get; set; }
        public bool? IsActive { get; set; }
        public DateTime DateAdded { get; set; }
        public Guid RegisteredBy { get; set; }
        public string Notes { get; set; }
        public DateTime ModifiedOn { get; set; }
        public Guid ModifiedBy { get; set; }

        public virtual Accounts Account { get; set; }
    }
}
