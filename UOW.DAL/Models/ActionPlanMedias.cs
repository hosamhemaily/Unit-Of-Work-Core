using System;
using System.Collections.Generic;

namespace UOW.DAL.Models
{
    public partial class ActionPlanMedias
    {
        public long ActionPlanMediaId { get; set; }
        public long MediaFileId { get; set; }
        public long ActionPlanId { get; set; }

        public virtual ActionPlans ActionPlan { get; set; }
        public virtual MediaFiles MediaFile { get; set; }
    }
}
