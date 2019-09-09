using System;
using System.Collections.Generic;

namespace UOW.DAL.Models
{
    public partial class ValueTypes
    {
        public ValueTypes()
        {
            WorkflowStageItems = new HashSet<WorkflowStageItems>();
        }

        public int ValueTypeId { get; set; }
        public string TypeName { get; set; }

        public virtual ICollection<WorkflowStageItems> WorkflowStageItems { get; set; }
    }
}
