using System;
using System.Collections.Generic;

namespace UOW.DAL.Models
{
    public partial class Permissions
    {
        public Permissions()
        {
            AccountPermissions = new HashSet<AccountPermissions>();
            RolePermissions = new HashSet<RolePermissions>();
            UserPermissions = new HashSet<UserPermissions>();
        }

        public long PermissionId { get; set; }
        public long DepartmentId { get; set; }
        public string ActionName { get; set; }
        public string Name { get; set; }

        public virtual ApplicationDepartments Department { get; set; }
        public virtual ICollection<AccountPermissions> AccountPermissions { get; set; }
        public virtual ICollection<RolePermissions> RolePermissions { get; set; }
        public virtual ICollection<UserPermissions> UserPermissions { get; set; }
    }
}
