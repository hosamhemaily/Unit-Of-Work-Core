using System;
using System.Collections.Generic;

namespace UOW.DAL.Models
{
    public partial class WorkflowStages
    {
        public WorkflowStages()
        {
            WorkflowStageItems = new HashSet<WorkflowStageItems>();
            WorkflowTriggers = new HashSet<WorkflowTriggers>();
        }

        public long WorkflowStageId { get; set; }
        public long WorkflowId { get; set; }
        public long DepartmentId { get; set; }
        public string Name { get; set; }
        public long ParentId { get; set; }
        public long TargetStageId { get; set; }
        public int SortOrder { get; set; }
        public string Note { get; set; }
        public string Reference { get; set; }

        public virtual ApplicationDepartments Department { get; set; }
        public virtual Workflows Workflow { get; set; }
        public virtual ICollection<WorkflowStageItems> WorkflowStageItems { get; set; }
        public virtual ICollection<WorkflowTriggers> WorkflowTriggers { get; set; }
    }
}
