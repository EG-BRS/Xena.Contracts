using System.Collections.Generic;
using Xena.Resources;

namespace Xena.Contracts.Domain
{
    public class VatSettlementTransactionDto : TransactionalDto
    {
        public int VatPeriodStartDays { get; set; }
        public string VatPeriodStartDaysFriendly
        {
            get { return VatPeriodStartDays.FriendlyString(); }
        }
        public int VatPeriodEndDays { get; set; }
        public string VatPeriodEndDaysFriendly
        {
            get { return VatPeriodEndDays.FriendlyString(); }
        }
        public int DueDateDays { get; set; }
        public string DueDateDaysFriendly
        {
            get { return DueDateDays.FriendlyString(); }
        }
        public long SettlementTransactionId { get; set; }
        public long? PaymentTransactionId { get; set; }
        public bool HasBeenCanceled { get; set; }
        public int SettlementVoucherNumber { get; set; }
        public int? PaymentVoucherNumber { get; set; }
        public string SettlementType { get; set; }
        public decimal TotalSettled { get; set; }
        public IList<VatSettlementPostDto> VatPosts { get; set; }
        public IList<TaxSettlementPostDto> TaxPosts { get; set; }
    }
}