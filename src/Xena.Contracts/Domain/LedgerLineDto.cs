using System.Collections.Generic;


namespace Xena.Contracts.Domain
{
    public class LedgerLineDto : EntityDto
    {
        public long LedgerId { get; set; }
        public int? VoucherNumber { get; set; }
        public int FiscalDateDays { get; set; }
        public string SupplierInvoiceNumber { get; set; }
        public string LedgerLineType { get; set; }
        public long? BankPostingId { get; set; }
        public long? DifferenceTagId { get; set; }
        public int DocumentCount { get; set; }
        public int? AccountNumber { get; set; }
        public string LedgerAccount { get; set; }

        public string LineDescription
        {
            get
            {
                var description = LedgerTagId.HasValue ? LedgerTagDescription : ArticleGroupId.HasValue ? ArticleGroupDescription : string.Empty;
                return AccountNumber.HasValue ? $"{AccountNumber} {description}" : description;
            }
        }
        public string CurrencyAbbreviation { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public long? DepartmentId { get; set; }
        public long? BearerId { get; set; }
        public long? PurposeId { get; set; }
        public long? LedgerTagId { get; set; }
        public long? VatId { get; set; }
        public long? VoucherId { get; set; }
        public long? ContraTagId { get; set; }
        public long? ArticleGroupId { get; set; }
        public long? PartnerId { get; set; }
        public IList<SettledPartnerPostDto> SettledPartnerPosts { get; set; }
        public int? Index { get; set; }
        //Convinience properties
        public string DepartmentDescription { get; set; }
        public string BearerDescription { get; set; }
        public string PurposeDescription { get; set; }
        public int? LedgerTagNumber { get; set; }
        public string LedgerTagDescription { get; set; }
        public int? ContraTagNumber { get; set; }
        public string ContraTagDescription { get; set; }
        public int? DifferenceTagNumber { get; set; }
        public string DifferenceTagDescription { get; set; }
        public string VatAbbreviation { get; set; }
        public string VatDescription { get; set; }
        public string ArticleGroupDescription { get; set; }
        public int? PartnerAccountNumber { get; set; }
        public string PartnerName { get; set; }
        public decimal? VatDeductionPercentage { get; set; }
        public string ShortDescription { get; set; }
        public string LinkDescription { get; set; }
        public string LedgerTagShortDescription { get; set; }
        public string LedgerTagLongDescription { get; set; }
        public string ContraTagShortDescription { get; set; }
        public string ContraTagLongDescription { get; set; }
        public string DifferenceTagShortDescription { get; set; }
        public string DifferenceTagLongDescription { get; set; }
        public string FiscalDateDaysFriendly { get; set; }
        public string LedgerLineTypeTranslated { get; set; }

    }
}