using System;
using System.Collections.Generic;

namespace UOW.DAL.Models
{
    public partial class Dashboards
    {
        public Dashboards()
        {
            Widgets = new HashSet<Widgets>();
        }

        public long DashboardId { get; set; }
        public long ProfileId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool? IsDefault { get; set; }
        public bool? IsDeleted { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public Guid ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }

        public virtual UserProfiles Profile { get; set; }
        public virtual ICollection<Widgets> Widgets { get; set; }
    }
}
