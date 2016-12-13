using Xena.Resources;

namespace Xena.Contracts.Domain
{
    public class EconomicTransactionDto : TransactionalDto
    {
        public int FiscalDateDays { get; set; }
        public string FiscalDateDaysFriendly
        {
            get { return FiscalDateDays.FriendlyString(); }
        }
        public long VoucherId { get; set; }
    }
}