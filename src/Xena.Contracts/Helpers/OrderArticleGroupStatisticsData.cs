using System.Collections.Generic;

namespace Xena.Contracts.Helpers
{
    public class OrderArticleGroupStatisticsData
    {
        public decimal TotalInvoiced { get; set; }
        public decimal InvoicedLast30Days { get; set; }
        public decimal InvoicedLast365Days { get; set; }
        public IList<ArticleGroupStatisticsDetailData> ArticleGroups { get; set; }
    }

    public class ArticleGroupStatisticsDetailData
    {
        public long? ArticleGroupId { get; set; }
        public string ArticleGroupDescription { get; set; }
        public decimal PeriodTotal { get; set; }
    }
}