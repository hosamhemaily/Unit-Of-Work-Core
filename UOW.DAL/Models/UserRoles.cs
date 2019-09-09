using System;
using System.Collections.Generic;

namespace UOW.DAL.Models
{
    public partial class UserRoles
    {
        public Guid UserId { get; set; }
        public Guid RoleId { get; set; }

        public virtual AspNetRoles Role { get; set; }
        public virtual Users User { get; set; }
    }
}
