using System;
using System.Collections.Generic;

namespace UOW.DAL.Models
{
    public partial class Notifications
    {
        public long NotificationId { get; set; }
        public long AccountId { get; set; }
        public Guid ToUserId { get; set; }
        public Guid FromUserId { get; set; }
        public long JobId { get; set; }
        public long NotificationTypeId { get; set; }
        public string Title { get; set; }
        public string AssignByName { get; set; }
        public string Message { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateOpended { get; set; }
        public bool IsClosed { get; set; }
        public bool IsRead { get; set; }
        public DateTime? DateClosed { get; set; }
        public string ClosingNote { get; set; }

        public virtual Users FromUser { get; set; }
        public virtual NotificationTypes NotificationType { get; set; }
        public virtual Users ToUser { get; set; }
    }
}
