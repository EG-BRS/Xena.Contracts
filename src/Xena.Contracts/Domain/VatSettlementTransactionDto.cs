using System.Collections.Generic;
using System.ComponentModel;
using Xena.Common.ExtensionMethods;

namespace Xena.Contracts.Domain
{
    public class VatSettlementTransactionDto : TransactionalDto
    {
        public int VatPeriodStartDays { get; set; }
        private string _vatPeriodStartDaysFriendly = null;
        [ReadOnly(true)]
        public string VatPeriodStartDaysFriendly
        {
            get { return _vatPeriodStartDaysFriendly ?? VatPeriodStartDays.FriendlyString(); }
            set { _vatPeriodStartDaysFriendly = value; }
        }
        public int VatPeriodEndDays { get; set; }
        private string _vatPeriodEndDaysFriendly = null;
        [ReadOnly(true)]
        public string VatPeriodEndDaysFriendly
        {
            get { return _vatPeriodEndDaysFriendly ?? VatPeriodEndDays.FriendlyString(); }
            set { _vatPeriodEndDaysFriendly = value; }
        }
        public int DueDateDays { get; set; }
        private string _dueDateDaysFriendly = null;
        [ReadOnly(true)]
        public string DueDateDaysFriendly
        {
            get { return _dueDateDaysFriendly ?? DueDateDays.FriendlyString(); }
            set { _dueDateDaysFriendly = value; }
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