using Xena.Resources;

namespace Xena.Contracts.Domain
{
    public class OrderOfferDto:TransactionalDto
    {
        public TotalsDto Totals { get; set; }
        public long? OrderId { get; set; }
        public int OfferDateDays { get; set; }
        public long ReportLayoutId { get; set; }
        public string OfferNumber { get; set; }
        public long? JournalId { get; set; }
        public long? PartnerId { get; set; }
        public string PartnerName { get; set; }
        public long? ResponsibleId { get; set; }
        public string ResponsibleName { get; set; }
        public int? PartnerAccountNumber { get; set; }
        public string OfferDateDaysFriendly => OfferDateDays.FriendlyString();
    }
}