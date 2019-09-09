using System;
using System.Collections.Generic;

namespace UOW.DAL.Models
{
    public partial class Languages
    {
        public long LanguageId { get; set; }
        public string LanguageName { get; set; }
        public string LanguageCode { get; set; }
    }
}
