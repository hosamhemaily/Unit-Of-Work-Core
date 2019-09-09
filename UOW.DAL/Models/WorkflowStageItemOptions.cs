using System;
using System.Collections.Generic;

namespace UOW.DAL.Models
{
    public partial class WorkflowStageItemOptions
    {
        public WorkflowStageItemOptions()
        {
            JobProcessOptions = new HashSet<JobProcessOptions>();
            JobProcesses = new HashSet<JobProcesses>();
        }

        public long Id { get; set; }
        public long WorkflowStageItemId { get; set; }
        public string Reference { get; set; }
        public string Value { get; set; }
        public string Recommendation { get; set; }

        public virtual WorkflowStageItems WorkflowStageItem { get; set; }
        public virtual ICollection<JobProcessOptions> JobProcessOptions { get; set; }
        public virtual ICollection<JobProcesses> JobProcesses { get; set; }
    }
}
