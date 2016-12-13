using System.Collections.Generic;
using Xena.Contracts.Domain;

namespace Xena.Contracts.Helpers
{
    public class VatDeclarationData
    {
        public VatSettlementTransactionDto Settlement { get; set; }
        public IList<VatFreeSalesTotalData> EUVATFreeSales { get; set; }
        public IList<VatFreeSalesTotalData> NonEUVATFreeSales { get; set; }
    }

    public class VatFreeSalesTotalData
    {
        public string Country { get; set; }
        public string EUVatType { get; set; }
        public decimal Amount { get; set; }
    }
}