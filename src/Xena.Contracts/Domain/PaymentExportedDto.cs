using System.Collections.Generic;
using System.ComponentModel;

namespace Xena.Contracts.Domain
{
    public class PaymentExportedDto : IHasIdDto
    {
        [ReadOnly(true)]
        public long? Id { get; set; }
        [ReadOnly(true)]
        public long BankExportId { get; set; }
        [ReadOnly(true)]
        public int PaymentDateDays { get; set; }
        [ReadOnly(true)]
        public decimal Amount { get; set; }
        [ReadOnly(true)]
        public string PaymentLine { get; set; }
    }
}