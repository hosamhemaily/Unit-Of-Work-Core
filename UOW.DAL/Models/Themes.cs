using System;
using System.Collections.Generic;

namespace UOW.DAL.Models
{
    public partial class Themes
    {
        public long ThemeId { get; set; }
        public long ApplicationId { get; set; }
        public string ThemeName { get; set; }
        public string RelativePath { get; set; }
        public string Note { get; set; }

        public virtual Applications Application { get; set; }
    }
}
