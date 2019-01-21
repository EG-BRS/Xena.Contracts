using System.Collections.Generic;
using System.ComponentModel;
using Xena.Common.Constants;
using Xena.Common.ExtensionMethods;

namespace Xena.Contracts.Domain
{
    public class BankPostingReconciliationSuggestionDto : FiscalDto, IHasIdDto
    {
        public long? Id { get; set; }
        public decimal Amount { get; set; }
        public int? FiscalDateDays { get; set; }

        private string _fiscalDateDaysFriendly;
        [ReadOnly(true)]
        public string FiscalDateDaysFriendly
        {
            get { return _fiscalDateDaysFriendly ?? (FiscalDateDays.HasValue ? FiscalDateDays.Value.FriendlyString() : string.Empty); }
            set { _fiscalDateDaysFriendly = value; }
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
        //Convinience properties

        private string _friendlyDescription = null;
        [ReadOnly(true)]
        public string FriendlyDescription
        {
            get
            {
                if (_friendlyDescription != null)
                {
                    return _friendlyDescription;
                }
                switch (SuggestionType)
                {
                    case BankPostingReconciliationSuggestionTypes.LedgerPost:
                        return $"{SuggestionType.GetLocalizedConstant()} - {LedgerPostDetails}";
                    case BankPostingReconciliationSuggestionTypes.PartnerPost:
                    case BankPostingReconciliationSuggestionTypes.PartnerSaldo:
                        return $"{SuggestionType.GetLocalizedConstant()} - {PartnerAccountNumber} {PartnerName}";
                    case BankPostingReconciliationSuggestionTypes.LedgerPostPreview:
                        return $"{SuggestionType.GetLocalizedConstant()} - {LedgerPostPreviewDetails}";
                    case BankPostingReconciliationSuggestionTypes.LedgerLine:
                        return $"{SuggestionType.GetLocalizedConstant()} - {LedgerLineDetails}";
                    default:
                        return $"{SuggestionType.GetLocalizedConstant()}";
                }
            }
            set { _friendlyDescription = value; }
        }
    }
}