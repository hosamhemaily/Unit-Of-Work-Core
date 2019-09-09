using System;
using System.Collections.Generic;

namespace UOW.DAL.Models
{
    public partial class ActionPlans
    {
        public ActionPlans()
        {
            ActionPlanMedias = new HashSet<ActionPlanMedias>();
        }

        public long ActionPlanId { get; set; }
        public long JobProcessId { get; set; }
        public long JobProcessStatusId { get; set; }
        public string Notes { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public Guid ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }

        public virtual JobProcesses JobProcess { get; set; }
        public virtual JobProcessStatuses JobProcessStatus { get; set; }
        public virtual ICollection<ActionPlanMedias> ActionPlanMedias { get; set; }
    }
}
