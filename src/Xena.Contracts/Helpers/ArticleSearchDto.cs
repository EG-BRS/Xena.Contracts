namespace Xena.Contracts.Helpers
{
    public class ArticleSearchDto
    {
        public long? ArticleId { get; set; }
        public string Provider { get; set; }
        public string ProviderId { get; set; }
        public string ArticleNumber { get; set; }
        public string Description { get; set; }
        public long? GroupId { get; set; }
        public long? SupplierId { get; set; }
        public string ArticleGroupDescription { get; set; }
        public string SupplierName { get; set; }
        public decimal? PurchasePrice { get; set; }
        public decimal? ListPrice { get; set; }
        public decimal? SalesPrice { get; set; }
        public string ImageUrl { get; set; }
        public string InfoUrl { get; set; }
    }
}