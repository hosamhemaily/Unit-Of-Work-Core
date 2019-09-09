using System;
using System.Collections.Generic;

namespace UOW.DAL.Models
{
    public partial class ApplicationDepartments
    {
        public ApplicationDepartments()
        {
            Permissions = new HashSet<Permissions>();
            WorkflowStages = new HashSet<WorkflowStages>();
        }

        public long ApplicationDepartmentId { get; set; }
        public long ApplicationId { get; set; }
        public long ParentId { get; set; }
        public string DepartmentName { get; set; }
        public string DisplayName { get; set; }
        public string Controller { get; set; }
        public string Action { get; set; }
        public long LogoId { get; set; }
        public string Logo { get; set; }
        public byte[] LogoData { get; set; }
        public int SortOrder { get; set; }
        public bool? Enabled { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public Guid ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual Applications Application { get; set; }
        public virtual ICollection<Permissions> Permissions { get; set; }
        public virtual ICollection<WorkflowStages> WorkflowStages { get; set; }
    }
}
