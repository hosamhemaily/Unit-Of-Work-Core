using System;
using System.Collections.Generic;

namespace UOW.DAL.Models
{
    public partial class Accounts
    {
        public Accounts()
        {
            AccountDevices = new HashSet<AccountDevices>();
            AccountPermissions = new HashSet<AccountPermissions>();
            AccountingGroups = new HashSet<AccountingGroups>();
            AccountsRoles = new HashSet<AccountsRoles>();
            Applications = new HashSet<Applications>();
            JobsAccount = new HashSet<Jobs>();
            JobsCustomer = new HashSet<Jobs>();
            Offices = new HashSet<Offices>();
            Services = new HashSet<Services>();
            Transactions = new HashSet<Transactions>();
            Users = new HashSet<Users>();
            Workflows = new HashSet<Workflows>();
        }

        public long AccountId { get; set; }
        public long ParentAccountId { get; set; }
        public long CategoryId { get; set; }
        public string AccountName { get; set; }
        public string SageAccRef { get; set; }
        public double ChargeRate { get; set; }
        public double Discount { get; set; }
        public double DiscountPerc { get; set; }
        public DateTime CreatedOn { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public Guid ModifiedBy { get; set; }
        public Guid AccountManager { get; set; }
        public int LicensedDevicesCount { get; set; }
        public bool Active { get; set; }
        public bool? IsDeleted { get; set; }
        public long StatusId { get; set; }
        public DateTime ContractSignedOn { get; set; }
        public string AmadeusApiSecret { get; set; }
        public string AmadeusApiKey { get; set; }

        public virtual Categories Category { get; set; }
        public virtual ICollection<AccountDevices> AccountDevices { get; set; }
        public virtual ICollection<AccountPermissions> AccountPermissions { get; set; }
        public virtual ICollection<AccountingGroups> AccountingGroups { get; set; }
        public virtual ICollection<AccountsRoles> AccountsRoles { get; set; }
        public virtual ICollection<Applications> Applications { get; set; }
        public virtual ICollection<Jobs> JobsAccount { get; set; }
        public virtual ICollection<Jobs> JobsCustomer { get; set; }
        public virtual ICollection<Offices> Offices { get; set; }
        public virtual ICollection<Services> Services { get; set; }
        public virtual ICollection<Transactions> Transactions { get; set; }
        public virtual ICollection<Users> Users { get; set; }
        public virtual ICollection<Workflows> Workflows { get; set; }
    }
}
