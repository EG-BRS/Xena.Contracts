using System.ComponentModel;
using Xena.Common.Constants;
using Xena.Common.ExtensionMethods;

namespace Xena.Contracts.Domain
{
    public class OrderTaskJournalEntryDto : TransactionalDto
    {
        private string _description;
        public string Description
        {
            get => string.IsNullOrEmpty(_description) ? OrderTaskJournalEntryDescription.Default.GetLocalizedConstant() :_description;
            set => _description = value;
        }

        public long OrderTaskId { get; set; }
        public long JournalId { get; set; }
        public bool HasDocument { get; set; }
        public int? VoucherNumber { get; set; }
        public int? FiscalDateDays { get; set; }

        private string _fiscalDateDaysFriendly = null;
        [ReadOnly(true)]
        public string FiscalDateDaysFriendly
        {
            get { return _fiscalDateDaysFriendly ?? FiscalDateDays?.FriendlyString(); }
            set { _fiscalDateDaysFriendly = value; }
        }

        public long? OrderInvoiceTransactionId { get; set; }
        public long? OrderDeliveryTransactionId { get; set; }
        public long? EconomicTransactionId { get; set; }

        public string JournalType { get; set; }
    }
}