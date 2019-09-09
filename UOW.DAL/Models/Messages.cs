using System;
using System.Collections.Generic;

namespace UOW.DAL.Models
{
    public partial class Messages
    {
        public Messages()
        {
            UserMessages = new HashSet<UserMessages>();
        }

        public long MessageId { get; set; }
        public long SenderId { get; set; }
        public long? ReplyId { get; set; }
        public long? ArticleId { get; set; }
        public long? JobId { get; set; }
        public long? PriorityId { get; set; }
        public string Subject { get; set; }
        public string MessageBody { get; set; }
        public DateTime? EmailDate { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public Guid ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }

        public virtual UserProfiles Sender { get; set; }
        public virtual ICollection<UserMessages> UserMessages { get; set; }
    }
}
