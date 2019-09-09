using System;
using System.Collections.Generic;

namespace UOW.DAL.Models
{
    public partial class ServiceSessions
    {
        public Guid Id { get; set; }
        public long ApplicationId { get; set; }
        public Guid UserId { get; set; }
        public DateTime TimeCreated { get; set; }
        public string RemoteIp { get; set; }
        public string DeviceId { get; set; }
        public DateTime LastAccess { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public bool? IsActive { get; set; }

        public virtual Applications Application { get; set; }
        public virtual Users User { get; set; }
    }
}
