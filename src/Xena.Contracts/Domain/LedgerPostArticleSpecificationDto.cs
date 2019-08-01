using System.ComponentModel;
using Xena.Common.ExtensionMethods;

namespace Xena.Contracts.Domain
{
    public class LedgerPostArticleSpecificationDto : TransactionalDto
    {
        public long ArticleId { get; set; }
        public long LedgerPostId { get; set; }
        public long EconomicTransactionId { get; set; }
        public long VoucherId { get; set; }
        public long ArticleGroupId { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal LedgerPostAmount { get; set; }
        public int VoucherNumber { get; set; }
        public string LedgerAccount { get; set; }
        public string ArticleGroupDescription { get; set; }
        public string LedgerPostDescription { get; set; }
        public string ArticleNumber { get; set; }
        public string ArticleDescription { get; set; }
        public int FiscalDateDays { get; set; }

        private string _fiscalDateDaysFriendly;
        [ReadOnly(true)]
        public string FiscalDateDaysFriendly
        {
            get { return _fiscalDateDaysFriendly ?? FiscalDateDays.FriendlyString(); }
            set { _fiscalDateDaysFriendly = value; }
        }
        private int? _registrationDateDays;
        [ReadOnly(true)]
        public int RegistrationDateDays
        {
            get { return _registrationDateDays ?? CreatedAt.DaysSince1970_01_01(); }
            set { _registrationDateDays = value; }
        }

        private string _registrationDateDaysFriendly;
        [ReadOnly(true)]
        public string RegistrationDateDaysFriendly
        {
            get { return _registrationDateDaysFriendly ?? ((int?)RegistrationDateDays).FriendlyString(); }
            set { _registrationDateDaysFriendly = value; }
        }
        private string _ledgerAccountTranslated = null;
        [ReadOnly(true)]
        public string LedgerAccountTranslated
        {
            get { return _ledgerAccountTranslated ?? LedgerAccount.GetLocalizedConstant(); }
            set { _ledgerAccountTranslated = value; }
        }
    }
}