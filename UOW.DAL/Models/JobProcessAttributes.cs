using System;
using System.Collections.Generic;

namespace UOW.DAL.Models
{
    public partial class JobProcessAttributes
    {
        public long Id { get; set; }
        public long JobProcessId { get; set; }
        public long AttributeId { get; set; }
        public string Value { get; set; }

        public virtual Attributes Attribute { get; set; }
        public virtual JobProcesses JobProcess { get; set; }
    }
}
