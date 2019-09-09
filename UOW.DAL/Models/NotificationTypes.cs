using System;
using System.Collections.Generic;

namespace UOW.DAL.Models
{
    public partial class NotificationTypes
    {
        public NotificationTypes()
        {
            Notifications = new HashSet<Notifications>();
        }

        public long Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Notifications> Notifications { get; set; }
    }
}
