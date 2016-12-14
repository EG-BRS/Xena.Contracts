

namespace Xena.Contracts.Domain
{
    public class ReminderTransactionDto : TransactionalDto
    {
        public string Description { get; set; }
        public int FiscalDateDays { get; set; }
        public string FiscalDateDaysFriendly
        { get; set; }
        public long TransactionId { get; set; }
        public long ReminderStepId { get; set; }
        public long PartnerPostId { get; set; }
        public long? DocumentId { get; set; }
    }
}