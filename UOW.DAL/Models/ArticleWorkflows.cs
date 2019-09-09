using System;
using System.Collections.Generic;

namespace UOW.DAL.Models
{
    public partial class ArticleWorkflows
    {
        public long ArticleWorkflowId { get; set; }
        public long ArticleId { get; set; }
        public long WorkFlowId { get; set; }
        public long StageId { get; set; }
        public long StageItemId { get; set; }
        public long JobId { get; set; }
        public string Value { get; set; }
        public long OptionId { get; set; }
        public bool? Approved { get; set; }
        public DateTime? ApprovalTime { get; set; }
        public decimal Cost { get; set; }
        public string Notes { get; set; }

        public virtual Articles Article { get; set; }
    }
}
