using System.ComponentModel;

namespace Xena.Contracts.Domain
{
    public class XenaFiscalPartnerDto:XenaFiscalDto
    {
        [ReadOnly(true)]
        public int? PartnerAccountNumber { get; set; }
        [ReadOnly(true)]
        public long? PartnerId { get; set; }
        [ReadOnly(true)]
        public string Name { get; set; }
        [ReadOnly(true)]
        public decimal Saldo { get; set; }
        [ReadOnly(true)]
        public int DocumentCount { get; set; }
    }
}