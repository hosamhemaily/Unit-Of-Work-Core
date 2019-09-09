using System;
using System.Collections.Generic;

namespace UOW.DAL.Models
{
    public partial class AspNetRoles
    {
        public AspNetRoles()
        {
            AccountsRoles = new HashSet<AccountsRoles>();
            RoleClaims = new HashSet<RoleClaims>();
            UserRoles = new HashSet<UserRoles>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string NormalizedName { get; set; }
        public string ConcurrencyStamp { get; set; }
        public string Discriminator { get; set; }

        public virtual ICollection<AccountsRoles> AccountsRoles { get; set; }
        public virtual ICollection<RoleClaims> RoleClaims { get; set; }
        public virtual ICollection<UserRoles> UserRoles { get; set; }
    }
}
