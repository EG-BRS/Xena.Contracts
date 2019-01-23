using System.ComponentModel;
using Xena.Common.ExtensionMethods;

namespace Xena.Contracts.Domain
{
    public class OrderConfirmationDto:TransactionalDto
    {
        public TotalsDto Totals { get; set; }
        public long? OrderId { get; set; }
        public int ConfirmationDateDays { get; set; }
        private string _confirmationDateDaysFriendly = null;
        [ReadOnly(true)]
        public string ConfirmationDateDaysFriendly
        {
            get { return _confirmationDateDaysFriendly ?? ConfirmationDateDays.FriendlyString(); }
            set { _confirmationDateDaysFriendly = value; }
        }
        public long ReportLayoutId { get; set; }
        public int ConfirmationNumber { get; set; }
        public long? JournalId { get; set; }
        public long? PartnerId { get; set; }
        public string PartnerName { get; set; }
        public int? PartnerAccountNumber { get; set; }
    }
}