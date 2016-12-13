namespace Xena.Contracts.Domain
{
    public class XenaFiscalPartnerDto:XenaFiscalDto
    {
        public int? PartnerAccountNumber { get; set; }
        public long? PartnerId { get; set; }
        public string Name { get; set; }
        public decimal Saldo { get; set; }
        public int DocumentCount { get; set; }
    }
}