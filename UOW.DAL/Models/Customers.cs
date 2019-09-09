using System;
using System.Collections.Generic;

namespace UOW.DAL.Models
{
    public partial class Customers
    {
        public Customers()
        {
            CustomerElectronicMarktOpts = new HashSet<CustomerElectronicMarktOpts>();
            CustomerEmailOpts = new HashSet<CustomerEmailOpts>();
            CustomerMarktExclusionOpts = new HashSet<CustomerMarktExclusionOpts>();
        }

        public long CustomerId { get; set; }
        public string FullName { get; set; }
        public string Salutation { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateBirth { get; set; }
        public long Idtype { get; set; }
        public string Consent { get; set; }
        public bool CustomerConsented { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Fax { get; set; }
        public string Home { get; set; }
        public string Mobile { get; set; }
        public string PostCode { get; set; }
        public string PreferredContact { get; set; }
        public string Work { get; set; }
        public long? AvatarMediaFileId { get; set; }
        public string LoginName { get; set; }
        public string Password { get; set; }
        public long? OfficeId { get; set; }

        public virtual MediaFiles AvatarMediaFile { get; set; }
        public virtual Offices Office { get; set; }
        public virtual ICollection<CustomerElectronicMarktOpts> CustomerElectronicMarktOpts { get; set; }
        public virtual ICollection<CustomerEmailOpts> CustomerEmailOpts { get; set; }
        public virtual ICollection<CustomerMarktExclusionOpts> CustomerMarktExclusionOpts { get; set; }
    }
}
