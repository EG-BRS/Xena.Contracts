namespace Xena.Contracts.Domain
{
    public class XenaUserSubscriptionLineDto : XenaUserDto
    {
        public long SubscriptionId { get; set; }
        public decimal Quantity { get; set; }
        public string Description { get; set; }
        public string ArticleNumber { get; set; }
        public int Index { get; set; }
        public decimal PriceNettTotal { get; set; }
    }
}