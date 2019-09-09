using System;
using System.Collections.Generic;

namespace UOW.DAL.Models
{
    public partial class JobProcessOptions
    {
        public JobProcessOptions()
        {
            JobProcessOptionMedias = new HashSet<JobProcessOptionMedias>();
        }

        public long JobProcessOptionId { get; set; }
        public long JobProcessId { get; set; }
        public long OptionId { get; set; }
        public long SeverityId { get; set; }
        public string NonConfirmity { get; set; }
        public string Location { get; set; }
        public string Responsible { get; set; }
        public DateTime DueDate { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }

        public virtual JobProcesses JobProcess { get; set; }
        public virtual WorkflowStageItemOptions Option { get; set; }
        public virtual Severities Severity { get; set; }
        public virtual ICollection<JobProcessOptionMedias> JobProcessOptionMedias { get; set; }
    }
}
