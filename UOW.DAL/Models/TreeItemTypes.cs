using System;
using System.Collections.Generic;

namespace UOW.DAL.Models
{
    public partial class TreeItemTypes
    {
        public TreeItemTypes()
        {
            ChartOfAccounts = new HashSet<ChartOfAccounts>();
        }

        public long TreeItemTypeId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<ChartOfAccounts> ChartOfAccounts { get; set; }
    }
}
