

namespace Xena.Contracts.Domain
{
    public class EconomicTransactionDto : TransactionalDto
    {
        public int FiscalDateDays { get; set; }
        public string FiscalDateDaysFriendly
        { get; set; }
        public long VoucherId { get; set; }
    }
}