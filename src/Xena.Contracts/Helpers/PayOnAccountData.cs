namespace Xena.Contracts.Helpers
{
    public class PayOnAccountData
    {
        public int? InvoicingDate { get; set; }
        public long? InvoiceLayoutId { get; set; }
        public string Description { get; set; }
        public PayOnAccountDetailData[] Details { get; set; }
    }
}