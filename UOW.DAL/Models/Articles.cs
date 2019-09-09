using System;
using System.Collections.Generic;

namespace UOW.DAL.Models
{
    public partial class Articles
    {
        public Articles()
        {
            ArticleAttributes = new HashSet<ArticleAttributes>();
            ArticleFiles = new HashSet<ArticleFiles>();
            ArticleWorkflows = new HashSet<ArticleWorkflows>();
            BookingBookingStatus = new HashSet<Booking>();
            BookingRoom = new HashSet<Booking>();
            Jobs = new HashSet<Jobs>();
        }


        public long ArticleId { get; set; }
        public long CategoryId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public long? AddressId { get; set; }
        public string StringContent { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
        public Guid ModifiedBy { get; set; }
        public bool? IsActive { get; set; }
        public long StatusId { get; set; }
        public long? ContentGroupId { get; set; }
        public bool ReadyToRender { get; set; }
        public bool RenderCompleted { get; set; }
        public bool Rendering { get; set; }
        public DateTime? SentToRenderAt { get; set; }
        public bool ReadyForAnimation { get; set; }
        public long ProductStatusId { get; set; }
        public bool? IsFeatured { get; set; }
        public long OfficeId { get; set; }

        public virtual Addresses Address { get; set; }
        public virtual ContentGroups ContentGroup { get; set; }
        public virtual Offices Office { get; set; }
        public virtual ICollection<ArticleAttributes> ArticleAttributes { get; set; }
        public virtual ICollection<ArticleFiles> ArticleFiles { get; set; }
        public virtual ICollection<ArticleWorkflows> ArticleWorkflows { get; set; }
        public virtual ICollection<Booking> BookingBookingStatus { get; set; }
        public virtual ICollection<Booking> BookingRoom { get; set; }
        public virtual ICollection<Jobs> Jobs { get; set; }
    }
}
