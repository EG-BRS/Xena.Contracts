namespace Xena.Contracts.Helpers
{
    public class PayProjectOnAccountData
    {
        public int? InvoicingDate { get; set; }
        public long? InvoiceLayoutId { get; set; }
        public string Description { get; set; }
        public PayProjectOnAccountDetailData[] Details { get; set; }
    }
}