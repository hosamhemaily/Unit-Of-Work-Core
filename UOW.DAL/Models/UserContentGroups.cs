using System;
using System.Collections.Generic;

namespace UOW.DAL.Models
{
    public partial class UserContentGroups
    {
        public long Id { get; set; }
        public long ContentGroupId { get; set; }
        public Guid UserId { get; set; }
        public Guid? ApplicationUserId { get; set; }

        public virtual Users ApplicationUser { get; set; }
        public virtual ContentGroups ContentGroup { get; set; }
    }
}
