namespace Xena.Contracts.Helpers
{
    public class VoucherListOptions: ListOptions
    {
        public string QueryString { get; set; }
        public long? ResponsibleId { get; set; }
        public int? VoucherNumberFrom { get; set; }
        public int? VoucherNumberTo { get; set; }
        public int? FiscalDateFrom { get; set; }
        public int? FiscalDateTo { get; set; }
        public decimal? AmountFrom { get; set; }
        public decimal? AmountTo { get; set; }
    }
}