using System.ComponentModel;
using Xena.Contracts.Domain;

namespace Xena.Contracts.Helpers
{
    public class AppPriceDto : IHasIdDto
    {
        [ReadOnly(true)]
        public long? Id { get; set; }
        public long AppId { get; set; }
        [ReadOnly(true)]
        public decimal PricePerFiscal { get; set; }
        [ReadOnly(true)]
        public decimal PricePerUser { get; set; }
        public string CurrencyAbbreviation { get; set; }
    }
}