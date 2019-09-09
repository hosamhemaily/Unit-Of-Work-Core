using System;
using System.Collections.Generic;

namespace UOW.DAL.Models
{
    public partial class MediaFiles
    {
        public MediaFiles()
        {
            ActionPlanMedias = new HashSet<ActionPlanMedias>();
            ArticleFiles = new HashSet<ArticleFiles>();
            Customers = new HashSet<Customers>();
            JobProcessMedias = new HashSet<JobProcessMedias>();
            JobProcessOptionMedias = new HashSet<JobProcessOptionMedias>();
            MediaFileAttributes = new HashSet<MediaFileAttributes>();
            Users = new HashSet<Users>();
        }

        public long MediaFileId { get; set; }
        public string Caption { get; set; }
        public int FileTypeId { get; set; }
        public string MimeType { get; set; }
        public string Url { get; set; }
        public bool? IsCompressed { get; set; }
        public DateTime CreatedOn { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public Guid ModifiedBy { get; set; }
        public long? CategoryId { get; set; }
        public bool UseInVideo { get; set; }
        public string SourceUrl { get; set; }

        public virtual Categories Category { get; set; }
        public virtual FileTypes FileType { get; set; }
        public virtual ICollection<ActionPlanMedias> ActionPlanMedias { get; set; }
        public virtual ICollection<ArticleFiles> ArticleFiles { get; set; }
        public virtual ICollection<Customers> Customers { get; set; }
        public virtual ICollection<JobProcessMedias> JobProcessMedias { get; set; }
        public virtual ICollection<JobProcessOptionMedias> JobProcessOptionMedias { get; set; }
        public virtual ICollection<MediaFileAttributes> MediaFileAttributes { get; set; }
        public virtual ICollection<Users> Users { get; set; }
    }
}
