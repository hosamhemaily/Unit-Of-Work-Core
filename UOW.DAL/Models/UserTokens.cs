﻿using System;
using System.Collections.Generic;

namespace UOW.DAL.Models
{
    public partial class UserTokens
    {
        public Guid UserId { get; set; }
        public string LoginProvider { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }

        public virtual Users User { get; set; }
    }
}
