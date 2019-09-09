using System;
using System.Collections.Generic;

namespace UOW.DAL.Models
{
    public partial class Invoice
    {
        public long Id { get; set; }
        public long? BookingId { get; set; }
        public string GuestName { get; set; }
        public double? TotalAmount { get; set; }
        public DateTime? CreatedOn { get; set; }
        public Guid? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public Guid? ModifiedBy { get; set; }
    }
}
