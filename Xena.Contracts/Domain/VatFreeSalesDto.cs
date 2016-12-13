using System.Collections.Generic;

namespace Xena.Contracts.Domain
{
    public class VatFreeSalesDto : IHasIdDto
    {
        public long? Id { get; set; }
        public decimal Amount { get; set; }
        public long PartnerId { get; set; }
        public string PartnerName { get; set; }
        public int PartnerAccountNumber { get; set; }
        public int FiscalDateDays { get; set; }
        public long FiscalSetupId { get; set; }
        public string CountryName { get; set; }
        public string OrgNumber { get; set; }
        public string EUType { get; set; }
    }
}