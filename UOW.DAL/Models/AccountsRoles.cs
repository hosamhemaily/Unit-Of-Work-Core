using System;
using System.Collections.Generic;

namespace UOW.DAL.Models
{
    public partial class AccountsRoles
    {
        public long Id { get; set; }
        public long AccountId { get; set; }
        public Guid RoleId { get; set; }

        public virtual Accounts Account { get; set; }
        public virtual AspNetRoles Role { get; set; }
    }
}
