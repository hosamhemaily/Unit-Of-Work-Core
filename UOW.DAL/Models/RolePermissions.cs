using System;
using System.Collections.Generic;

namespace UOW.DAL.Models
{
    public partial class RolePermissions
    {
        public long Id { get; set; }
        public Guid RoleId { get; set; }
        public long PermissionId { get; set; }

        public virtual Permissions Permission { get; set; }
    }
}
