using System.ComponentModel;
using Xena.Common.ExtensionMethods;

namespace Xena.Contracts.Domain
{
    public class ReminderTransactionDto : TransactionalDto
    {
        public string Description { get; set; }
        public int FiscalDateDays { get; set; }

        private string _fiscalDateDaysFriendly = null;
        [ReadOnly(true)]
        public string FiscalDateDaysFriendly
        {
            get { return _fiscalDateDaysFriendly ?? FiscalDateDays.FriendlyString(); }
            set { _fiscalDateDaysFriendly = value; }
        }
        public long TransactionId { get; set; }
        public long ReminderStepId { get; set; }
        public long PartnerPostId { get; set; }
        public long? DocumentId { get; set; }
    }
}