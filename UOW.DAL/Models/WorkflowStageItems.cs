using System;
using System.Collections.Generic;

namespace UOW.DAL.Models
{
    public partial class WorkflowStageItems
    {
        public WorkflowStageItems()
        {
            JobProcesses = new HashSet<JobProcesses>();
            ProcessItems = new HashSet<ProcessItems>();
            WorkflowStageItemAttributes = new HashSet<WorkflowStageItemAttributes>();
            WorkflowStageItemOptions = new HashSet<WorkflowStageItemOptions>();
            WorkflowTriggers = new HashSet<WorkflowTriggers>();
        }

        public long WorkflowStageItemId { get; set; }
        public long WorkflowStageId { get; set; }
        public string Name { get; set; }
        public string Subject { get; set; }
        public string Instructions { get; set; }
        public string CompliantValue { get; set; }
        public string NonCompliantValue { get; set; }
        public string NotApplicable { get; set; }
        public int ValueTypeId { get; set; }
        public long TargetStageId { get; set; }
        public int SortOrder { get; set; }
        public double SeverityRate { get; set; }
        public string Reference { get; set; }

        public virtual ValueTypes ValueType { get; set; }
        public virtual WorkflowStages WorkflowStage { get; set; }
        public virtual ICollection<JobProcesses> JobProcesses { get; set; }
        public virtual ICollection<ProcessItems> ProcessItems { get; set; }
        public virtual ICollection<WorkflowStageItemAttributes> WorkflowStageItemAttributes { get; set; }
        public virtual ICollection<WorkflowStageItemOptions> WorkflowStageItemOptions { get; set; }
        public virtual ICollection<WorkflowTriggers> WorkflowTriggers { get; set; }
    }
}
