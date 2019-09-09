using System;
using System.Collections.Generic;

namespace UOW.DAL.Models
{
    public partial class Applications
    {
        public Applications()
        {
            ApplicationDepartments = new HashSet<ApplicationDepartments>();
            ServiceSessions = new HashSet<ServiceSessions>();
            Themes = new HashSet<Themes>();
        }

        public long ApplicationId { get; set; }
        public string ApplicationName { get; set; }
        public long CategoryId { get; set; }
        public string WebAddress { get; set; }
        public string PhysicalPath { get; set; }
        public long DefaultLanguageId { get; set; }
        public long AccountId { get; set; }
        public bool? AllowThemes { get; set; }
        public long DefaultThemeId { get; set; }
        public bool? IsActive { get; set; }
        public long Status { get; set; }
        public int Severity { get; set; }
        public string TrackingId { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public Guid ModifiedBy { get; set; }
        public DateTime DateModified { get; set; }

        public virtual Accounts Account { get; set; }
        public virtual ICollection<ApplicationDepartments> ApplicationDepartments { get; set; }
        public virtual ICollection<ServiceSessions> ServiceSessions { get; set; }
        public virtual ICollection<Themes> Themes { get; set; }
    }
}
