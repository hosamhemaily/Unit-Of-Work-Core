using System;
using System.Collections.Generic;

namespace UOW.DAL.Models
{
    public partial class WorkflowStageAttributes
    {
        public long Id { get; set; }
        public long StageId { get; set; }
        public long AttributeId { get; set; }
        public string Value { get; set; }
    }
}
