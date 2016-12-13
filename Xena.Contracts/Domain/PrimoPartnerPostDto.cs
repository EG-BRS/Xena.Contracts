using Xena.Resources;

namespace Xena.Contracts.Domain
{
    public class PrimoPartnerPostDto : EntityDto
    {
        public long FiscalPeriodId { get; set; }
        public decimal Amount { get; set; }
        public int? FiscalDateDays { get; set; }
        public string FiscalDateDaysFriendly
        {
            get { return FiscalDateDays?.FriendlyString()??string.Empty; }
        }
        public int DueDateDays { get; set; }
        public string DueDateDaysFriendly
        {
            get { return DueDateDays.FriendlyString(); }
        }
        public string ContextType { get; set; }
        public long? PartnerId { get; set; }
        public string PartnerName { get; set; }
        public string SupplierInvoiceNumber { get; set; }
        public int? PartnerAccountNumber { get; set; }
    }
}