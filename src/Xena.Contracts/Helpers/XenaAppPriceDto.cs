using Xena.Contracts.Domain;

namespace Xena.Contracts.Helpers
{
    public class XenaAppPriceDto : EntityDto
    {
        public long XenaAppId { get; set; }
        public decimal PricePerFiscal { get; set; }
        public decimal PricePerUser { get; set; }
        public string CurrencyAbbreviation { get; set; }
    }
}