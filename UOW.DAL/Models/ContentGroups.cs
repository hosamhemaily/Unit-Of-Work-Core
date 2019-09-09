using System;
using System.Collections.Generic;

namespace UOW.DAL.Models
{
    public partial class ContentGroups
    {
        public ContentGroups()
        {
            Articles = new HashSet<Articles>();
            UserContentGroups = new HashSet<UserContentGroups>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public long SortOrder { get; set; }

        public virtual ICollection<Articles> Articles { get; set; }
        public virtual ICollection<UserContentGroups> UserContentGroups { get; set; }
    }
}
