using System;
using System.Collections.Generic;

namespace UOW.DAL.Models
{
    public partial class WorkflowStageItemAttributes
    {
        public long Id { get; set; }
        public long StageItemId { get; set; }
        public long AttributeId { get; set; }
        public string Value { get; set; }

        public virtual WorkflowStageItems StageItem { get; set; }
    }
}
