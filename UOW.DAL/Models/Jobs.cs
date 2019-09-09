using System;
using System.Collections.Generic;

namespace UOW.DAL.Models
{
    public partial class Jobs
    {
        public Jobs()
        {
            JobProcesses = new HashSet<JobProcesses>();
        }

        public long JobId { get; set; }
        public long ProcessId { get; set; }
        public long CategoryId { get; set; }
        public long AccountId { get; set; }
        public long CustomerId { get; set; }
        public long ArticleId { get; set; }
        public string Title { get; set; }
        public DateTime JobDate { get; set; }
        public long QualityStatusId { get; set; }
        public int? ProcessStatus { get; set; }
        public bool Invoiced { get; set; }
        public bool Qcchecked { get; set; }
        public long ServiceId { get; set; }
        public long StatusId { get; set; }
        public bool Completed { get; set; }
        public decimal Fee { get; set; }
        public decimal AmendedFee { get; set; }
        public long LogType { get; set; }
        public string LogTitle { get; set; }
        public string LogMessage { get; set; }
        public long DepartmentId { get; set; }
        public Guid AssignedToId { get; set; }
        public string CurrentStageName { get; set; }
        public DateTime ModifiedOn { get; set; }
        public Guid ModifiedBy { get; set; }
        public string Note { get; set; }
        public string Summary { get; set; }
        public bool IsDeleted { get; set; }

        public virtual Accounts Account { get; set; }
        public virtual Articles Article { get; set; }
        public virtual Users AssignedTo { get; set; }
        public virtual Accounts Customer { get; set; }
        public virtual Processes Process { get; set; }
        public virtual Services Service { get; set; }
        public virtual Statuses Status { get; set; }
        public virtual ICollection<JobProcesses> JobProcesses { get; set; }
    }
}
