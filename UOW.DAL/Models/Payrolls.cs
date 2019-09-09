using System;
using System.Collections.Generic;

namespace UOW.DAL.Models
{
    public partial class Payrolls
    {
        public long PayrollId { get; set; }
        public Guid UserId { get; set; }
        public decimal Salary { get; set; }
        public int SayaryCategory { get; set; }
        public int EmploymentStatus { get; set; }
        public bool IsActive { get; set; }
        public string AccountingReference { get; set; }
        public int Grade { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public Guid ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
    }
}
