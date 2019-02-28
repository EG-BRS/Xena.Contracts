namespace Xena.Contracts.Domain
{
    public class PartnerPostPaymentDto : FiscalDto,IHasIdDto
    {
        public PartnerPostDto PartnerPost { get; set; }
        public decimal AmountPaid { get; set; }
        public long? Id { get; set; }
    }
}