namespace Xena.Contracts.Helpers
{
    public class ArticlePartnerImportData
    {
        public string ArticleNumber { get; set; }
        public string Description { get; set; }
        public decimal? SalesPrice { get; set; }
        public decimal? PurchasingPrice { get; set; }
        
        public override string ToString()
        {
            return string.Format("{0} {1}", ArticleNumber, Description);
        }
    }
}