using System.Collections.Generic;
using System.Linq;
using Xena.Resources;

namespace Xena.Contracts.Domain
{
    public class BankPostingReconciliationSuggestionDto : FiscalDto, IHasIdDto
    {
        public long? Id { get; set; }
        public decimal Amount { get; set; }
        public int? FiscalDateDays { get; set; }
        public string FiscalDateDaysFriendly
        {
            get { return FiscalDateDays.HasValue ? FiscalDateDays.Value.FriendlyString() : string.Empty; }
        }
        public IList<BankPostingPartnerPostDto> PartnerPosts { get; set; }
        public long BankPostingId { get; set; }
        public long? PartnerId { get; set; }
        public int? PartnerAccountNumber { get; set; }
        public string PartnerName { get; set; }
        public decimal Probability { get; set; }
        public string SuggestionType { get; set; }
        public LedgerPostDetailsDto LedgerPostDetails { get; set; }
        public LedgerLineDetailsDto LedgerLineDetails { get; set; }
        public LedgerPostPreviewDetailsDto LedgerPostPreviewDetails { get; set; }
        public string FriendlyDescription
        {
            get
            {
                switch (SuggestionType)
                {
                    case Constants.BankPostingReconciliationSuggestionTypes.LedgerPost:
                        return string.Format("{0} - {1}", SuggestionType.GetLocalizedConstant(), LedgerPostDetails);
                    case Constants.BankPostingReconciliationSuggestionTypes.PartnerPost:
                    case Constants.BankPostingReconciliationSuggestionTypes.PartnerSaldo:
                        return string.Format("{0} - {1} {2}", SuggestionType.GetLocalizedConstant(), PartnerAccountNumber, PartnerName);
                    case Constants.BankPostingReconciliationSuggestionTypes.LedgerPostPreview:
                        return string.Format("{0} - {1}", SuggestionType.GetLocalizedConstant(), LedgerPostPreviewDetails);
                    case Constants.BankPostingReconciliationSuggestionTypes.LedgerLine:
                        return string.Format("{0} - {1}", SuggestionType.GetLocalizedConstant(), LedgerLineDetails);
                    default:
                        return string.Format("{0}", SuggestionType.GetLocalizedConstant());
                }
            }
        }
    }

    public class LedgerPostDetailsDto
    {
        public long? LedgerPostId { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public decimal CurrencyAmount { get; set; }
        public string CurrencyAbbreviation { get; set; }
        public int FiscalDateDays { get; set; }

        public string FiscalDateDaysFriendly
        {
            get { return FiscalDateDays.FriendlyString(); }
        }
        public override string ToString()
        {
            return string.Format("{0} {1}", FiscalDateDaysFriendly, Description);
        }
    }
    public class LedgerLineDetailsDto
    {
        public long? LedgerLineId { get; set; }
        public string Description { get; set; }
        public decimal CurrencyAmount { get; set; }
        public string CurrencyAbbreviation { get; set; }
        public int FiscalDateDays { get; set; }
        public string FiscalDateDaysFriendly
        {
            get { return FiscalDateDays.FriendlyString(); }
        }
        public override string ToString()
        {
            return string.Format("{0} {1}", FiscalDateDaysFriendly, Description);
        }
    }

    public class LedgerPostPreviewDetailsDto
    {
        public long? LedgerPostPreviewId { get; set; }
        public string Description { get; set; }
        public decimal CurrencyAmount { get; set; }
        public string CurrencyAbbreviation { get; set; }
        public int FiscalDateDays { get; set; }
        public string FiscalDateDaysFriendly
        {
            get { return FiscalDateDays.FriendlyString(); }
        }
        public override string ToString()
        {
            return string.Format("{0} {1}", FiscalDateDaysFriendly, Description);
        }
    }
    public class LedgerPostDraftDetailsDto
    {
        public long? LedgerPostDraftId { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public decimal CurrencyAmount { get; set; }
        public string CurrencyAbbreviation { get; set; }
        public int FiscalDateDays { get; set; }
        public string FiscalDateDaysFriendly
        {
            get { return FiscalDateDays.FriendlyString(); }
        }
        public override string ToString()
        {
            return string.Format("{0} {1}", FiscalDateDaysFriendly, Description);
        }
    }
    public class BankPostingPartnerPostDto
    {
        public long PartnerPostId { get; set; }
        public decimal Amount { get; set; }
        public decimal CurrencyAmount { get; set; }
        public string CurrencyAbbreviation { get; set; }
        public string PostType { get; set; }

        public string PostTypeTranslated
        {
            get { return PostType.GetLocalizedConstant(); }
        }
        public int DueDateDays { get; set; }
        public int FiscalDateDays { get; set; }
        public string SupplierInvoiceNumber { get; set; }
    }
}