using System;
using System.Collections.Generic;

namespace UOW.DAL.Models
{
    public partial class Widgets
    {
        public long WidgetId { get; set; }
        public long DashboardId { get; set; }
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int SortOrder { get; set; }
        public string Operator { get; set; }
        public bool? IsLegend { get; set; }
        public string SeriesTitleX { get; set; }
        public string SeriesTitleY { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public Guid ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }

        public virtual Dashboards Dashboard { get; set; }
    }
}
