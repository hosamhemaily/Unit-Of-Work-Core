using System;
using System.Collections.Generic;

namespace UOW.DAL.Models
{
    public partial class Attributes
    {
        public Attributes()
        {
            AreaAttributes = new HashSet<AreaAttributes>();
            ArticleAttributes = new HashSet<ArticleAttributes>();
            JobProcessAttributes = new HashSet<JobProcessAttributes>();
            MediaFileAttributes = new HashSet<MediaFileAttributes>();
            WorkflowTriggers = new HashSet<WorkflowTriggers>();
        }

        public long AttributeId { get; set; }
        public long CategoryId { get; set; }
        public string Name { get; set; }
        public int ValueTypeId { get; set; }
        public bool? Fixed { get; set; }
        public string DefaultValue { get; set; }
        public string DropdownType { get; set; }
        public long AttributeGroupId { get; set; }
        public double TaxValue { get; set; }

        public virtual AttributeGroups AttributeGroup { get; set; }
        public virtual Categories Category { get; set; }
        public virtual ICollection<AreaAttributes> AreaAttributes { get; set; }
        public virtual ICollection<ArticleAttributes> ArticleAttributes { get; set; }
        public virtual ICollection<JobProcessAttributes> JobProcessAttributes { get; set; }
        public virtual ICollection<MediaFileAttributes> MediaFileAttributes { get; set; }
        public virtual ICollection<WorkflowTriggers> WorkflowTriggers { get; set; }
    }
}
