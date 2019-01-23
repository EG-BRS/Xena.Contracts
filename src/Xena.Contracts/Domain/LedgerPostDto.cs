using System.ComponentModel;
using Xena.Common.ExtensionMethods;

namespace Xena.Contracts.Domain
{
    public class LedgerPostDto : TransactionalDto
    {
        private DimensionsDto _dimensions;

        public LedgerPostDto()
        {
            Dimensions = new DimensionsDto();
        }

        public decimal Amount { get; set; }
        public long EconomicTransactionId { get; set; }
        public long VoucherId { get; set; }
        public int VoucherNumber { get; set; }
        public decimal CurrencyAmount { get; set; }
        public string CurrencyAbbreviation { get; set; }
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

        public string LedgerAccount { get; set; }

        private string _ledgerAccountTranslated = null;
        [ReadOnly(true)]
        public string LedgerAccountTranslated
        {
            get { return _ledgerAccountTranslated ?? LedgerAccount.GetLocalizedConstant(); }
            set { _ledgerAccountTranslated = value; }
        }
        public long? LedgerTagId { get; set; }
        public int? LedgerTagNumber { get; set; }
        public string LedgerTagDescription { get; set; }
        public long? ArticleGroupId { get; set; }
        public string Description { get; set; }
        public string ArticleGroupDescription { get; set; }
        public decimal VatAmount { get; set; }
        public decimal? VatDeductionPercentage { get; set; }
        public long? VatId { get; set; }
        public string VatAbbreviation { get; set; }
        public string VatDescription { get; set; }
        public string DepartmentDescription { get; set; }
        public string PurposeDescription { get; set; }
        public string BearerDescription { get; set; }

        public DimensionsDto Dimensions
        {
            get { return _dimensions ?? (_dimensions = new DimensionsDto()); }
            set { _dimensions = value; }
        }

        public long? SettlementId { get; set; }
        public long? PartnerId { get; set; }
        public string PartnerName { get; set; }
        public int? PartnerAccountNumber { get; set; }
        public decimal RunningTotal { get; set; }
        public long? BankSettlementId { get; set; }
        public long? PrimoArticlePostId { get; set; }
    }
}