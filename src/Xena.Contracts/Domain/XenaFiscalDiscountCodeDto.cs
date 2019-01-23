using System.ComponentModel;

namespace Xena.Contracts.Domain
{
    public class XenaFiscalDiscountCodeDto : XenaFiscalDto
    {
        [ReadOnly(true)]
        public string Description { get; set; }
        [ReadOnly(true)]
        public string Code { get; set; }
        [ReadOnly(true)]
        public int ExpirationDateDays { get; set; }
    }
}