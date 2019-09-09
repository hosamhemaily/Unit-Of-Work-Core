using System;
using System.Collections.Generic;

namespace UOW.DAL.Models
{
    public partial class AccountPermissions
    {
        public long AccountPermissionId { get; set; }
        public long AccountId { get; set; }
        public long PermissionId { get; set; }

        public virtual Accounts Account { get; set; }
        public virtual Permissions Permission { get; set; }
    }
}
