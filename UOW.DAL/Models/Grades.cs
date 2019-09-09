using System;
using System.Collections.Generic;

namespace UOW.DAL.Models
{
    public partial class Grades
    {
        public int GradeId { get; set; }
        public long AccountId { get; set; }
        public string GradeName { get; set; }
    }
}
