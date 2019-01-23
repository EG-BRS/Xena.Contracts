using System.ComponentModel;
using Xena.Common.ExtensionMethods;

namespace Xena.Contracts.Domain
{
    public class VoucherDto : TransactionalDto
    {
        public long FiscalPeriodId { get; set; }
        public int VoucherNumber { get; set; }
        public string Description { get; set; }
        public long? ResponsibleId { get; set; }
        public string ResponsibleName { get; set; }
        public int FiscalDateDays { get; set; }
        private string _fiscalDateDaysFriendly = null;
        [ReadOnly(true)]
        public string FiscalDateDaysFriendly
        {
            get { return _fiscalDateDaysFriendly ?? FiscalDateDays.FriendlyString(); }
            set { _fiscalDateDaysFriendly = value; }
        }
        public decimal DebetAmount { get; set; }
        public decimal CreditAmount { get; set; }
        public long? FirstDocumentId { get; set; }
        public int DocumentRelationCount { get; set; }
    }
}