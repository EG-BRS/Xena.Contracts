namespace Xena.Contracts.Helpers
{
    public class PartnerArticleStatisticsReportData
    {
        public int DateFrom { get; set; }
        public int DateTo { get; set; }
        public long PartnerId { get; set; }
        public long? ArticleGroupId { get; set; }
        public long? ArticleId { get; set; }
        public long? ReportLayoutId { get; set; }
    }
}