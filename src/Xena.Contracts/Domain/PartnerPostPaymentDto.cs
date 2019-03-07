namespace Xena.Contracts.Domain
{
    public class PartnerPostPaymentDto : FiscalDto,IHasIdDto
    {
        public long? Id { get; set; }
        public PartnerPostDto PartnerPost { get; set; }
        public decimal AmountPaid { get; set; }
        public long PaymentExportedId { get; set; }
    }
}