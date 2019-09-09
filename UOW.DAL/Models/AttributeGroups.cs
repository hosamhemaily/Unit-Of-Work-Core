using System;
using System.Collections.Generic;

namespace UOW.DAL.Models
{
    public partial class AttributeGroups
    {
        public AttributeGroups()
        {
            Attributes = new HashSet<Attributes>();
        }

        public long AttributeGroupId { get; set; }
        public string Name { get; set; }
        public long SortOrder { get; set; }

        public virtual ICollection<Attributes> Attributes { get; set; }
    }
}
