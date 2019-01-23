using Xena.Contracts.Domain;

namespace Xena.Contracts.Helpers
{
    public class XenaAppBundlePriceDto : EntityDto
    {
        public long XenaAppBundleId { get; set; }
        public decimal PricePerFiscal { get; set; }
        public decimal PricePerUser { get; set; }
        public string CurrencyAbbreviation { get; set; }
    }
}