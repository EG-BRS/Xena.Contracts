namespace Xena.Contracts.Helpers
{
    public class LedgerLineData
    {
        public int? FiscalDateDays { get; set; }
        public int? VoucherNumber { get; set; }
        public int? Account { get; set; }
        public decimal? Amount { get; set; }
        public decimal? Debit { get; set; }
        public decimal? Credit { get; set; }
        public int? ContraAccount { get; set; }
        public int? Partner { get; set; }
        public string Description { get; set; }
        public string Currency { get; set; }
        public string Vat { get; set; }
        public decimal? VatDeductionPercentage { get; set; }
        public string Department { get; set; }
        public string Bearer { get; set; }
        public string Purpose { get; set; }
    }
}