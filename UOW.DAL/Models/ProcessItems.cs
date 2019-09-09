using System;
using System.Collections.Generic;

namespace UOW.DAL.Models
{
    public partial class ProcessItems
    {
        public long Id { get; set; }
        public long ProcessId { get; set; }
        public long StageItemId { get; set; }
        public long? WorkflowStageItemId { get; set; }

        public virtual Processes Process { get; set; }
        public virtual WorkflowStageItems WorkflowStageItem { get; set; }
    }
}
