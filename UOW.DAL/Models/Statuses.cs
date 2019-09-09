using System;
using System.Collections.Generic;

namespace UOW.DAL.Models
{
    public partial class Statuses
    {
        public Statuses()
        {
            Jobs = new HashSet<Jobs>();
            Processes = new HashSet<Processes>();
        }

        public long StatusId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Jobs> Jobs { get; set; }
        public virtual ICollection<Processes> Processes { get; set; }
    }
}
