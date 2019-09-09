using System;
using System.Collections.Generic;

namespace UOW.DAL.Models
{
    public partial class WorkflowAttributes
    {
        public long Id { get; set; }
        public long WorkflowId { get; set; }
        public long AttributeId { get; set; }
        public string Value { get; set; }
    }
}
