namespace Xena.Contracts.Domain
{
    public class XenaFiscalSubscriptionLineDto : XenaFiscalDto
    {
        public long SubscriptionId { get; set; }
        public decimal Quantity { get; set; }
        public string Description { get; set; }
        public string ArticleNumber { get; set; }
        public int Index { get; set; }
        public decimal PriceNettTotal { get; set; }
    }
}