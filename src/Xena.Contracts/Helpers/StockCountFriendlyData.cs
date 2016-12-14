namespace Xena.Contracts.Helpers
{
    public class StockCountFriendlyData
    {
        public long Id { get; set; }
        public string ArticleNumber_Translated { get; set; }
        public string ArticleDescription_Translated { get; set; }
        public string Location_Translated { get; set; }
        public string ArticleVariantAbbreviation_Translated { get; set; }
        public decimal Quantity_Translated { get; set; }
        public decimal QuantityReserved_Translated { get; set; }
        public decimal? QuantityCounted_Translated { get; set; }
    }

    public class StockCountProblemData
    {
        public long Id { get; set; }
        public decimal OriginallyQuantity { get; set; }
        public decimal OriginallyQuantityReserved { get; set; }
        public decimal CurrentQuantity { get; set; }
    }
}