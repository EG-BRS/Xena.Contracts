namespace Xena.Contracts.Helpers
{
    public class ArticleInventoryManagementImportData
    {
        public string ArticleNumber { get; set; }
        public decimal? MaximumStock { get; set; }
        public decimal? MinimumStock { get; set; }
        public string DefaultLocation { get; set; }
        public int? DefaultSupplier { get; set; }
    }
}