using System;
using System.Collections.Generic;

namespace UOW.DAL.Models
{
    public partial class Transactions
    {
        public long TransactionId { get; set; }
        public long AccountId { get; set; }
        public string Code { get; set; }
        public long TransactionTypeId { get; set; }

        public virtual Accounts Account { get; set; }
        public virtual TransactionTypes TransactionType { get; set; }
    }
}
