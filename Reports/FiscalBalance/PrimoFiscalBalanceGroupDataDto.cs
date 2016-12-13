using System.Collections.Generic;

namespace Xena.Contracts.Reports.FiscalBalance
{
    /// <summary>
    /// Income-, asset- or liabilitystatement
    /// </summary>
    public class PrimoFiscalBalanceGroupDataDto
    {
        public string Description { get; set; }
        public decimal AmountPrimo { get; set; }
        public string TranslatedDescription { get; set; }
        public IList<PrimoFiscalBalanceGroupDetailDataDto> Details { get; set; }
    }
}