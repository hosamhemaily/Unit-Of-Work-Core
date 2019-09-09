using System;
using System.Collections.Generic;

namespace UOW.DAL.Models
{
    public partial class UserProfiles
    {
        public UserProfiles()
        {
            Dashboards = new HashSet<Dashboards>();
            Messages = new HashSet<Messages>();
            UserMessages = new HashSet<UserMessages>();
            UserPermissions = new HashSet<UserPermissions>();
        }

        public long ProfileId { get; set; }
        public long AddressId { get; set; }
        public string Email { get; set; }
        public long DefaultLanguageId { get; set; }
        public long ApplicationId { get; set; }
        public long ThemeId { get; set; }
        public bool ReceiveEmails { get; set; }
        public string Password { get; set; }
        public Guid UserId { get; set; }
        public string Avatar { get; set; }

        public virtual Addresses Address { get; set; }
        public virtual Users User { get; set; }
        public virtual ICollection<Dashboards> Dashboards { get; set; }
        public virtual ICollection<Messages> Messages { get; set; }
        public virtual ICollection<UserMessages> UserMessages { get; set; }
        public virtual ICollection<UserPermissions> UserPermissions { get; set; }
    }
}
