using System;
using System.Collections.Generic;

namespace UOW.DAL.Models
{
    public partial class JobProcessStatuses
    {
        public JobProcessStatuses()
        {
            ActionPlans = new HashSet<ActionPlans>();
        }

        public long JobProcessStatusId { get; set; }
        public string StatusTitle { get; set; }

        public virtual ICollection<ActionPlans> ActionPlans { get; set; }
    }
}
