using System;
using System.Collections.Generic;

namespace UOW.DAL.Models
{
    public partial class JobProcesses
    {
        public JobProcesses()
        {
            ActionPlans = new HashSet<ActionPlans>();
            JobProcessAttributes = new HashSet<JobProcessAttributes>();
            JobProcessMedias = new HashSet<JobProcessMedias>();
            JobProcessOptions = new HashSet<JobProcessOptions>();
        }

        public long JobProcessId { get; set; }
        public long JobId { get; set; }
        public long StageId { get; set; }
        public long StageItemId { get; set; }
        public long StageItemStatusId { get; set; }
        public long SeverityId { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public long OptionId { get; set; }
        public string Recommendation { get; set; }
        public bool? IsArchive { get; set; }
        public bool? IsApproved { get; set; }
        public Guid AssignedTo { get; set; }
        public Guid ApprovedBy { get; set; }
        public bool? Completed { get; set; }
        public DateTime? CompletedOn { get; set; }
        public decimal Cost { get; set; }
        public string Notes { get; set; }
        public long FloorPlanId { get; set; }
        public decimal PinX { get; set; }
        public decimal PinY { get; set; }
        public string Location { get; set; }
        public string WhoIsResponsible { get; set; }
        public DateTime? ByWhen { get; set; }

        public virtual Jobs Job { get; set; }
        public virtual WorkflowStageItemOptions Option { get; set; }
        public virtual Severities Severity { get; set; }
        public virtual WorkflowStageItems StageItem { get; set; }
        public virtual StageItemStatuses StageItemStatus { get; set; }
        public virtual ICollection<ActionPlans> ActionPlans { get; set; }
        public virtual ICollection<JobProcessAttributes> JobProcessAttributes { get; set; }
        public virtual ICollection<JobProcessMedias> JobProcessMedias { get; set; }
        public virtual ICollection<JobProcessOptions> JobProcessOptions { get; set; }
    }
}
