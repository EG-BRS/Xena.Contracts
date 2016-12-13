namespace Xena.Contracts.Domain
{
    public class BarCodeDto:EntityDto
    {
        public BarCodeDto()
        {
            Quantity = 1m;
        }
        public string EANNumber { get; set; }
        public long ArticleId { get; set; }
        public decimal Quantity { get; set; }
        public string ArticleNumber { get; set; }
        public string ArticleDescription { get; set; }
    }
}