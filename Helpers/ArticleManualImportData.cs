namespace Xena.Contracts.Helpers
{
    public class ArticleManualImportData
    {
        public string ArticleNumber { get; set; }
        public string Description { get; set; }
        public string GroupName { get; set; }
        public string CurrencyAbbreviation { get; set; }
        public decimal UnitPrice { get; set; }
        public string SuppliersProductNo { get; set; }
        public string OriginalId { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1} {2}", ArticleNumber, Description, GroupName);
        }
    }
}