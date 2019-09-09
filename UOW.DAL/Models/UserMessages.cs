using System;
using System.Collections.Generic;

namespace UOW.DAL.Models
{
    public partial class UserMessages
    {
        public long UserMessageId { get; set; }
        public long MessageId { get; set; }
        public long RecieverId { get; set; }
        public bool? IsDraft { get; set; }
        public bool? IsRead { get; set; }
        public bool? IsTrash { get; set; }
        public bool? IsDeleted { get; set; }
        public bool? IsEmailed { get; set; }
        public DateTime? EmailDate { get; set; }
        public bool? IsRecieved { get; set; }

        public virtual Messages Message { get; set; }
        public virtual UserProfiles Reciever { get; set; }
    }
}
