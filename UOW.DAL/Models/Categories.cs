using System;
using System.Collections.Generic;

namespace UOW.DAL.Models
{
    public partial class Categories
    {
        public Categories()
        {
            Accounts = new HashSet<Accounts>();
            Attributes = new HashSet<Attributes>();
            MediaFiles = new HashSet<MediaFiles>();
            Processes = new HashSet<Processes>();
        }

        public long CategoryId { get; set; }
        public string CategoryName { get; set; }
        public long ParentId { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public Guid ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual ICollection<Accounts> Accounts { get; set; }
        public virtual ICollection<Attributes> Attributes { get; set; }
        public virtual ICollection<MediaFiles> MediaFiles { get; set; }
        public virtual ICollection<Processes> Processes { get; set; }
    }
}
