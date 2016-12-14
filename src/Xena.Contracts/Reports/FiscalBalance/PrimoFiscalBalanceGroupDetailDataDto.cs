using System.Collections.Generic;

namespace Xena.Contracts.Reports.FiscalBalance
{
    /// <summary>
    /// Ledgeraccount summary
    /// </summary>
    public class PrimoFiscalBalanceGroupDetailDataDto
    {
        public string Description { get; set; }
        public decimal AmountPrimo { get; set; }
        public string TranslatedGroup { get; set; }
        public IList<PrimoFiscalBalanceDetailDataDto> Details { get; set; }
    }
}