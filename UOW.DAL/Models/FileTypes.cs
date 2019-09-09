using System;
using System.Collections.Generic;

namespace UOW.DAL.Models
{
    public partial class FileTypes
    {
        public FileTypes()
        {
            MediaFiles = new HashSet<MediaFiles>();
        }

        public int FileTypeId { get; set; }
        public string Name { get; set; }
        public string Extention { get; set; }
        public string MimeType { get; set; }
        public bool? IsBinaryFile { get; set; }

        public virtual ICollection<MediaFiles> MediaFiles { get; set; }
    }
}
