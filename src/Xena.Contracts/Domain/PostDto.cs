

namespace Xena.Contracts.Domain
{
    public class PostDto : TransactionalDto
    {
        public int FiscalDateDays { get; set; }
        public string FiscalDateDaysFriendly
        { get; set; }
        public long? PartnerId { get; set; }
        public long? SettlementId { get; set; }
        public long? LedgerTagId { get; set; }
        public long? ArticleGroupId { get; set; }
        public decimal Amount { get; set; }
        public decimal CurrencyAmount { get; set; }
        public string CurrencyAbbreviation { get; set; }
        public long? VatId { get; set; }
        public decimal VatAmount { get; set; }
        public DimensionsDto Dimensions { get; set; }
        public string LedgerAccount { get; set; }
        public string LedgerAccountTranslated
        { get; set; }
        public long EconomicTransactionId { get; set; }
        public string PostType { get; set; }
        public int? PartnerAccountNumber { get; set; }
        public string PartnerName { get; set; }
        public int? LedgerTagNumber { get; set; }
        public string LedgerTagDescription { get; set; }
        public string ArticleGroupDescription { get; set; }
        public string VatAbbreviation { get; set; }
        public string VatDescription { get; set; }
        public string DepartmentDescription { get; set; }
        public string PurposeDescription { get; set; }
        public string BearerDescription { get; set; }
        public long VoucherId { get; set; }
        public int VoucherNumber { get; set; }
    }
}