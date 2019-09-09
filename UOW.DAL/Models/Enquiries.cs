using System;
using System.Collections.Generic;

namespace UOW.DAL.Models
{
    public partial class Enquiries
    {
        public long EnquiryId { get; set; }
        public long ApplicationId { get; set; }
        public DateTime DateAndTime { get; set; }
        public long AccountId { get; set; }
        public long OfficeId { get; set; }
        public long ArticleId { get; set; }
        public string ContactId { get; set; }
        public int EnquiryType { get; set; }
        public DateTime ContactDate { get; set; }
        public DateTime VisitDate { get; set; }
        public string ContactTime { get; set; }
        public string VisitTime { get; set; }
        public long AddressId { get; set; }
        public int ProductYear { get; set; }
        public string ProductType { get; set; }
        public string ProductUnits { get; set; }
        public int PurchaseYear { get; set; }
        public string EnquiryAddress { get; set; }
        public string TelephoneNumber { get; set; }
        public string MobileNumber { get; set; }
        public string Email { get; set; }
        public int Status { get; set; }
    }
}
