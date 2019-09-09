using System;
using System.Collections.Generic;

namespace UOW.DAL.Models
{
    public partial class Offices
    {
        public Offices()
        {
            Articles = new HashSet<Articles>();
            Customers = new HashSet<Customers>();
            Users = new HashSet<Users>();
        }

        public long OfficeId { get; set; }
        public long AccountId { get; set; }
        public string OfficeName { get; set; }
        public long AddressId { get; set; }
        public DateTime CreationOn { get; set; }
        public Guid CreatedBy { get; set; }
        public long CategoryId { get; set; }
        public DateTime ModifiedOn { get; set; }
        public Guid ModifiedBy { get; set; }
        public bool? IsHeadOffice { get; set; }
        public bool? Active { get; set; }
        public bool? IsOnline { get; set; }
        public string Email { get; set; }
        public string TelephoneNumbers { get; set; }
        public bool? SendNotifications { get; set; }
        public string NotificationEmails { get; set; }
        public string Website { get; set; }
        public string Comment { get; set; }

        public virtual Accounts Account { get; set; }
        public virtual Addresses Address { get; set; }
        public virtual ICollection<Articles> Articles { get; set; }
        public virtual ICollection<Customers> Customers { get; set; }
        public virtual ICollection<Users> Users { get; set; }
    }
}
