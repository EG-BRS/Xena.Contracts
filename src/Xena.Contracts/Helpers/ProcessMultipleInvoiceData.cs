namespace Xena.Contracts.Helpers
{
    public class ProcessMultipleInvoiceData
    {
        public long[] OrderIds { get; set; }
        public int InvoiceDate { get; set; }
        public long? OrderStatusId { get; set; }
    }
}