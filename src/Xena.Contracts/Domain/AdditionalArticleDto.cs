namespace Xena.Contracts.Domain
{
    public class AdditionalArticleDto:EntityDto
    {
        public long? ArticleId { get; set; }
        public decimal Quantity { get; set; }
        public string ChildArticleNumber { get; set; }
        public long? ChildArticleId { get; set; }
        public string ChildArticleDescription { get; set; }
    }
}