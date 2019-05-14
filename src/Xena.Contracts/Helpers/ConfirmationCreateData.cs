namespace Xena.Contracts.Helpers
{
    public class ConfirmationCreateData
    {
        public int? ConfirmationDate { get; set; }
        public long? ConfirmationReportLayoutId { get; set; }
        public long? OrderStatusId { get; set; }
    }
}