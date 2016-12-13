using Xena.Resources;

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
        public string FiscalDateDaysFriendly
        {
            get { return FiscalDateDays.FriendlyString(); }
        }
        public string LedgerAccount { get; set; }
        public string LedgerAccountTranslated
        {
            get { return LedgerAccount.GetLocalizedConstant(); }
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
            get { return _dimensions?? new DimensionsDto(); }
            set { _dimensions = value; }
        }

        public long? SettlementId { get; set; }
        public long? PartnerId { get; set; }
        public string PartnerName { get; set; }
        public int? PartnerAccountNumber { get; set; }
        public decimal RunningTotal { get; set; }
        public long? BankSettlementId { get; set; }
    }
}