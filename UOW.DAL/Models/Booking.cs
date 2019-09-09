using System;
using System.Collections.Generic;

namespace UOW.DAL.Models
{
    public partial class Booking
    {
        public long Id { get; set; }
        public string GuestName { get; set; }
        public DateTime? CheckIn { get; set; }
        public DateTime? CheckOut { get; set; }
        public long? BookingStatusId { get; set; }
        public string GuestPhone { get; set; }
        public string Notes { get; set; }
        public Guid? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public long? RoomId { get; set; }
        public bool? CheckedOut { get; set; }

        public virtual Articles BookingStatus { get; set; }
        public virtual Articles Room { get; set; }
    }
}
