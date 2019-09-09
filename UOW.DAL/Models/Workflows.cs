using System;
using System.Collections.Generic;

namespace UOW.DAL.Models
{
    public partial class Workflows
    {
        public Workflows()
        {
            WorkflowStages = new HashSet<WorkflowStages>();
        }

        public long WorkflowId { get; set; }
        public long AccountId { get; set; }
        public long CategoryId { get; set; }
        public string Name { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public Guid ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string Reference { get; set; }

        public virtual Accounts Account { get; set; }
        public virtual ICollection<WorkflowStages> WorkflowStages { get; set; }
    }
}
