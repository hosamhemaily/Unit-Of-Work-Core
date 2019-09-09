using System;
using System.Collections.Generic;

namespace UOW.DAL.Models
{
    public partial class Processes
    {
        public Processes()
        {
            Jobs = new HashSet<Jobs>();
            ProcessItems = new HashSet<ProcessItems>();
        }

        public long ProcessId { get; set; }
        public long CategoryId { get; set; }
        public string ProcessName { get; set; }
        public DateTime CreatedOn { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public Guid ModifiedBy { get; set; }
        public decimal Fee { get; set; }
        public bool? IsDeleted { get; set; }
        public long StatusId { get; set; }

        public virtual Categories Category { get; set; }
        public virtual Statuses Status { get; set; }
        public virtual ICollection<Jobs> Jobs { get; set; }
        public virtual ICollection<ProcessItems> ProcessItems { get; set; }
    }
}
