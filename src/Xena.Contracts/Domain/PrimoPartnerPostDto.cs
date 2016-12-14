

namespace Xena.Contracts.Domain
{
    public class PrimoPartnerPostDto : EntityDto
    {
        public long FiscalPeriodId { get; set; }
        public decimal Amount { get; set; }
        public int? FiscalDateDays { get; set; }
        public string FiscalDateDaysFriendly
        { get; set; }
        public int DueDateDays { get; set; }
        public string DueDateDaysFriendly
        { get; set; }
        public string ContextType { get; set; }
        public long? PartnerId { get; set; }
        public string PartnerName { get; set; }
        public string SupplierInvoiceNumber { get; set; }
        public int? PartnerAccountNumber { get; set; }
    }
}