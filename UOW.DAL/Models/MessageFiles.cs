using System;
using System.Collections.Generic;

namespace UOW.DAL.Models
{
    public partial class MessageFiles
    {
        public long MessageFileId { get; set; }
        public long MessageId { get; set; }
        public long MediaFileId { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
