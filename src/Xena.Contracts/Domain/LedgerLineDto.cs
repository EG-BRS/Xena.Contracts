using System.Collections.Generic;
using System.ComponentModel;
using Xena.Common.ExtensionMethods;

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
        public string LedgerAccount { get; set; }
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
        public long? CostTypeId { get; set; }
        public long? OrderTaskId { get; set; }
        public long? PartiallySettledPostId { get; set; }
        public decimal? VatDeductionPercentage { get; set; }
        public string PaymentIdentification { get; set; }
        public IList<SettledPartnerPostDto> SettledPartnerPosts { get; set; }
        public int? Index { get; set; }

        //Convinience properties
        public string LineDescription
        {
            get
            {
                var description = LedgerTagId.HasValue ? LedgerTagDescription : ArticleGroupId.HasValue ? ArticleGroupDescription : string.Empty;
                return AccountNumber.HasValue ? $"{AccountNumber} {description}" : description;
            }
        }
        [ReadOnly(true)]
        public int DocumentCount { get; set; }
        [ReadOnly(true)]
        public int? AccountNumber { get; set; }
        [ReadOnly(true)]
        public string CostTypeDescription { get; set; }
        [ReadOnly(true)]
        public int? OrderNumber { get; set; }
        [ReadOnly(true)]
        public string OrderTaskDescription { get; set; }

        private string _orderTaskAbbreviation;
        [ReadOnly(true)]
        public string OrderTaskAbbreviation
        {
            get { return _orderTaskAbbreviation ?? (OrderTaskId.HasValue ? $"{OrderNumber}-{OrderTaskIndex}" : string.Empty); }
            set { _orderTaskAbbreviation = value; }
        }

        [ReadOnly(true)]
        public string OrderTaskIndex { get; set; }
        [ReadOnly(true)]
        public string DepartmentDescription { get; set; }
        [ReadOnly(true)]
        public string BearerDescription { get; set; }
        [ReadOnly(true)]
        public string PurposeDescription { get; set; }
        [ReadOnly(true)]
        public int? LedgerTagNumber { get; set; }
        [ReadOnly(true)]
        public string LedgerTagDescription { get; set; }
        [ReadOnly(true)]
        public int? ContraTagNumber { get; set; }
        [ReadOnly(true)]
        public string ContraTagDescription { get; set; }
        [ReadOnly(true)]
        public int? DifferenceTagNumber { get; set; }
        [ReadOnly(true)]
        public string DifferenceTagDescription { get; set; }
        [ReadOnly(true)]
        public string VatAbbreviation { get; set; }
        [ReadOnly(true)]
        public string VatDescription { get; set; }
        [ReadOnly(true)]
        public string ArticleGroupDescription { get; set; }
        [ReadOnly(true)]
        public int? PartnerAccountNumber { get; set; }
        [ReadOnly(true)]
        public string PartnerName { get; set; }

        private string _shortDescription;
        [ReadOnly(true)]
        public string ShortDescription
        {
            get { return _shortDescription ?? (AccountNumber.HasValue ? $"{AccountNumber.Value}" : ArticleGroupDescription); }
            set { _shortDescription = value; }
        }

        private string _linkDescription = null;
        [ReadOnly(true)]
        public string LinkDescription
        {
            get
            {
                return _linkDescription ?? (LedgerTagId.HasValue
                           ? LedgerTagDescription
                           :
                           ArticleGroupId.HasValue
                               ?
                               $"{ArticleGroupDescription}, {LedgerAccount?.GetLocalizedConstant()}"
                               : string.Empty);
            }
            set { _linkDescription = value; }
        }

        private string _ledgerTagShortDescription;
        [ReadOnly(true)]
        public string LedgerTagShortDescription
        {
            get { return _ledgerTagShortDescription ?? (LedgerTagNumber?.ToString() ?? LedgerTagDescription); }
            set { _ledgerTagShortDescription = value; }
        }


        private string _ledgerTagLongDescription;
        [ReadOnly(true)]
        public string LedgerTagLongDescription
        {
            get
            {
                return _ledgerTagLongDescription ?? (LedgerTagNumber.HasValue
                    ? $"{LedgerTagNumber.Value} - {LedgerTagDescription}"
                    : LedgerTagDescription);
            }
            set { _ledgerTagLongDescription = value; }
        }

        private string _contraTagShortDescription;
        [ReadOnly(true)]
        public string ContraTagShortDescription
        {
            get { return _contraTagShortDescription?? (ContraTagNumber?.ToString() ?? ContraTagDescription); }
            set { _contraTagShortDescription = value; }
        }

        private string _contraTagLongDescription;
        [ReadOnly(true)]
        public string ContraTagLongDescription
        {
            get
            {
                return _contraTagLongDescription ?? (ContraTagNumber.HasValue
                    ? $"{ContraTagNumber.Value} - {ContraTagDescription}"
                    : ContraTagDescription);
            }
            set { _contraTagLongDescription = value; }
        }

        private string _differenceTagShortDescription;
        [ReadOnly(true)]
        public string DifferenceTagShortDescription
        {
            get { return _differenceTagShortDescription ?? (DifferenceTagNumber?.ToString() ?? DifferenceTagDescription); }
            set { _differenceTagShortDescription = value; }
        }

        private string _differenceTagLongDescription;
        [ReadOnly(true)]
        public string DifferenceTagLongDescription
        {
            get
            {
                return _differenceTagLongDescription ?? (DifferenceTagNumber.HasValue
                           ? $"{DifferenceTagNumber.Value} - {DifferenceTagDescription}"
                           : DifferenceTagDescription);
            }
            set { _differenceTagLongDescription = value; }
        }

        private string _fiscalDateDaysFriendly;
        [ReadOnly(true)]
        public string FiscalDateDaysFriendly
        {
            get { return _fiscalDateDaysFriendly ?? FiscalDateDays.ToDate().ToString("d"); }
            set { _fiscalDateDaysFriendly = value; }
        }

        private string _ledgerLineTypeTranslated = null;
        [ReadOnly(true)]
        public string LedgerLineTypeTranslated
        {
            get { return _ledgerLineTypeTranslated ?? (LedgerLineType?.GetLocalizedConstant() ?? string.Empty); }
            set { _ledgerLineTypeTranslated = value; }
        }
    }
}