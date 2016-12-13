using Xena.Resources;

namespace Xena.Contracts.Domain
{
    public class OrderConfirmationDto:TransactionalDto
    {
        public TotalsDto Totals { get; set; }
        public long? OrderId { get; set; }
        public int ConfirmationDateDays { get; set; }
        public string ConfirmationDateDaysFriendly
        {
            get { return ConfirmationDateDays.FriendlyString(); }
        }
        public long ReportLayoutId { get; set; }
        public int ConfirmationNumber { get; set; }
        public long? JournalId { get; set; }
        public long? PartnerId { get; set; }
        public string PartnerName { get; set; }
        public int? PartnerAccountNumber { get; set; }
    }
}