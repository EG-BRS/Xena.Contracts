namespace Xena.Contracts.Helpers
{
    public class BarcodeImportData
    {
        public string ArticleNumber { get; set; }
        public string EANNumber { get; set; }
        public decimal Quantity { get; set; }
        public override string ToString()
        {
            return $"{ArticleNumber} {EANNumber} {Quantity.ToString("N2")}";
        }
    }
}