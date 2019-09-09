using System;
using System.Collections.Generic;

namespace UOW.DAL.Models
{
    public partial class UserPermissions
    {
        public long Id { get; set; }
        public long PermissionId { get; set; }
        public long ProfileId { get; set; }

        public virtual Permissions Permission { get; set; }
        public virtual UserProfiles Profile { get; set; }
    }
}
