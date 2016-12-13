using Xena.Resources;

namespace Xena.Contracts.Domain
{
    public class XenaFiscalPartnerPostDto : XenaFiscalDto, IXenaPartnerPost
    {
        public int? VoucherNumber { get; set; }
        public int FiscalDateDays { get; set; }
        public string PostType { get; set; }

        public string PostTypeTranslated
        {
            get { return PostType.GetLocalizedConstant(); }
        }
        public decimal Amount { get; set; }
        public decimal CurrencyAmount { get; set; }
        public string CurrencyAbbreviation { get; set; }
        public long? OrderJournalEntryId { get; set; }
        public long? SettlementId { get; set; }

        public bool IsSettled
        {
            get { return SettlementId.HasValue; }
        }
        public string FiscalDateDaysFriendly
        {
            get { return FiscalDateDays.FriendlyString(); }
        }
    }
}