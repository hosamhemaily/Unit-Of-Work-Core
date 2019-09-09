using System;
using System.Collections.Generic;

namespace UOW.DAL.Models
{
    public partial class StageItemStatuses
    {
        public StageItemStatuses()
        {
            JobProcesses = new HashSet<JobProcesses>();
        }

        public long StageItemStatusId { get; set; }
        public string Status { get; set; }

        public virtual ICollection<JobProcesses> JobProcesses { get; set; }
    }
}
