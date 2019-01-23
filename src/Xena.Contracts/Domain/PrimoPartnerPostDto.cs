using System.ComponentModel;
using Xena.Common.ExtensionMethods;

namespace Xena.Contracts.Domain
{
    public class PrimoPartnerPostDto : EntityDto
    {
        public long FiscalPeriodId { get; set; }
        public decimal Amount { get; set; }
        public int? FiscalDateDays { get; set; }
        private string _fiscalDateDaysFriendly = null;
        [ReadOnly(true)]
        public string FiscalDateDaysFriendly
        {
            get { return _fiscalDateDaysFriendly ?? (FiscalDateDays?.FriendlyString() ?? string.Empty); }
            set { _fiscalDateDaysFriendly = value; }
        }
        public int DueDateDays { get; set; }
        private string _dueDateDaysFriendly = null;
        [ReadOnly(true)]
        public string DueDateDaysFriendly
        {
            get { return _dueDateDaysFriendly ?? DueDateDays.FriendlyString(); }
            set { _dueDateDaysFriendly = value; }
        }
        public string ContextType { get; set; }
        public long? PartnerId { get; set; }
        public string PartnerName { get; set; }
        public string SupplierInvoiceNumber { get; set; }
        public int? PartnerAccountNumber { get; set; }
        public bool IsBookkeept { get; set; }
    }
}