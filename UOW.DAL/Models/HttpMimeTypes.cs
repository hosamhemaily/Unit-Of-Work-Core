using System;
using System.Collections.Generic;

namespace UOW.DAL.Models
{
    public partial class HttpMimeTypes
    {
        public int Id { get; set; }
        public int MediaFileType { get; set; }
        public string FileExtension { get; set; }
        public string MimeType { get; set; }
    }
}
