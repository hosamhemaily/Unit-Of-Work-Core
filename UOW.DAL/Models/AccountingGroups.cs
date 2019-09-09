using System;
using System.Collections.Generic;

namespace UOW.DAL.Models
{
    public partial class AccountingGroups
    {
        public AccountingGroups()
        {
            ChartOfAccounts = new HashSet<ChartOfAccounts>();
        }

        public long AccountingGroupId { get; set; }
        public long AccountId { get; set; }
        public string GroupName { get; set; }

        public virtual Accounts Account { get; set; }
        public virtual ICollection<ChartOfAccounts> ChartOfAccounts { get; set; }
    }
}
