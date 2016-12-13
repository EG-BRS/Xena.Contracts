namespace Xena.Contracts.Helpers
{
    public class ArticleImportData
    {
        public string ArticleNumber { get; set; }
        public string Description { get; set; }
        public string GroupName { get; set; }
        public decimal SalesSetupDefaultQuantity { get; set; }
        public decimal? SalesSetupPrice { get; set; }
        public decimal PurchasingSetupDefaultQuantity { get; set; }
        public decimal? PurchasingSetupPrice { get; set; }
        public string SalesUnitAbbreviation { get; set; }        
        public string PurchasingUnitAbbreviation { get; set; }

        public override string ToString()
        {
            return $"{ArticleNumber} {Description} {GroupName}";
        }
    }
}