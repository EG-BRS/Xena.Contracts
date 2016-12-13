using System.Collections.Generic;
using Xena.Resources;

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
        public string ShortDescription => AccountNumber.HasValue ? $"{AccountNumber.Value}" : ArticleGroupDescription;
        public string LinkDescription => LedgerTagId.HasValue ? LedgerTagDescription : ArticleGroupId.HasValue ? $"{ArticleGroupDescription}, {LedgerAccount?.GetLocalizedConstant()}" : string.Empty;
        public string LedgerTagShortDescription => LedgerTagNumber?.ToString() ?? LedgerTagDescription;
        public string LedgerTagLongDescription => LedgerTagNumber.HasValue ? $"{LedgerTagNumber.Value} - {LedgerTagDescription}" : LedgerTagDescription;
        public string ContraTagShortDescription => ContraTagNumber?.ToString() ?? ContraTagDescription;
        public string ContraTagLongDescription => ContraTagNumber.HasValue ? $"{ContraTagNumber.Value} - {ContraTagDescription}" : ContraTagDescription;
        public string DifferenceTagShortDescription => DifferenceTagNumber?.ToString() ?? DifferenceTagDescription;
        public string DifferenceTagLongDescription => DifferenceTagNumber.HasValue ? $"{DifferenceTagNumber.Value} - {DifferenceTagDescription}" : DifferenceTagDescription;
        public string FiscalDateDaysFriendly => FiscalDateDays.ToDate().ToShortDateString();
        public string LedgerLineTypeTranslated => LedgerLineType?.GetLocalizedConstant() ?? string.Empty;

    }
}