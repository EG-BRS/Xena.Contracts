namespace Xena.Contracts.Domain
{
    public class PartnerWithFiscalReference
    {
        public long? PartnerId { get; set; }
        public long Id { get; set; }
        public string Description { get; set; }
        public decimal? Saldo { get; set; }
        public long FiscalSetupId { get; set; }
        public int DocumentCount { get; set; }
    }
}