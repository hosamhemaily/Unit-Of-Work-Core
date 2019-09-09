using System;
using System.Collections.Generic;

namespace UOW.DAL.Models
{
    public partial class WorkflowTriggers
    {
        public long WorkflowTriggerId { get; set; }
        public long WorkflowStageId { get; set; }
        public long StageItemId { get; set; }
        public string Name { get; set; }
        public bool? IsOnStart { get; set; }
        public bool? IsOnEnd { get; set; }
        public bool? IsEmailAction { get; set; }
        public bool? IsSmsAction { get; set; }
        public bool? IsNotificationAction { get; set; }
        public string SendTo { get; set; }
        public string Template { get; set; }
        public bool? IsHtmlBody { get; set; }
        public long ConditionAttributeId { get; set; }
        public string ConditionValueFrom { get; set; }
        public string ConditionValueTo { get; set; }
        public string ConditionValue { get; set; }
        public long? WorkflowStageItemId { get; set; }

        public virtual Attributes ConditionAttribute { get; set; }
        public virtual WorkflowStages WorkflowStage { get; set; }
        public virtual WorkflowStageItems WorkflowStageItem { get; set; }
    }
}
