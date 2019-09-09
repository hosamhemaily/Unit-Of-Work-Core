using System;
using System.Collections.Generic;

namespace UOW.DAL.Models
{
    public partial class ChartOfAccounts
    {
        public long Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public long TreeItemTypeId { get; set; }
        public long BalanceSheetId { get; set; }
        public long AccountingGroupId { get; set; }
        public long? ParentId { get; set; }

        public virtual AccountingGroups AccountingGroup { get; set; }
        public virtual TreeItemTypes TreeItemType { get; set; }
    }
}
