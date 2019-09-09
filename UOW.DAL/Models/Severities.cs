using System;
using System.Collections.Generic;

namespace UOW.DAL.Models
{
    public partial class Severities
    {
        public Severities()
        {
            JobProcessOptions = new HashSet<JobProcessOptions>();
            JobProcesses = new HashSet<JobProcesses>();
        }

        public long SeverityId { get; set; }
        public string SeverityName { get; set; }

        public virtual ICollection<JobProcessOptions> JobProcessOptions { get; set; }
        public virtual ICollection<JobProcesses> JobProcesses { get; set; }
    }
}
