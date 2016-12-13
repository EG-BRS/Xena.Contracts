using Xena.Resources;

namespace Xena.Contracts.Domain
{
    public class VoucherDto : TransactionalDto
    {
        public long FiscalPeriodId { get; set; }
        public int VoucherNumber { get; set; }
        public string Description { get; set; }
        public string CreatedByName { get; set; }
        public int FiscalDateDays { get; set; }

        public string FiscalDateDaysFriendly
        {
            get { return FiscalDateDays.FriendlyString(); }
        }

        public decimal DebetAmount { get; set; }
        public decimal CreditAmount { get; set; }
        public long? FirstDocumentId { get; set; }
        public int DocumentRelationCount { get; set; }
    }
}