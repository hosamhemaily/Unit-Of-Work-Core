using System;
using System.Collections.Generic;

namespace UOW.DAL.Models
{
    public partial class TransactionTypes
    {
        public TransactionTypes()
        {
            Transactions = new HashSet<Transactions>();
        }

        public long TransactionTypeId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Transactions> Transactions { get; set; }
    }
}
