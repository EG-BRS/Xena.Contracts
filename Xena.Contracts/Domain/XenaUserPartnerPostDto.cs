using Xena.Resources;

namespace Xena.Contracts.Domain
{
    public class XenaUserPartnerPostDto : XenaUserDto , IXenaPartnerPost
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

    public interface IXenaPartnerPost
    {
        bool IsSettled { get; }
        long Id { get; set; }
        long FiscalSetupId { get; set; }
        decimal Amount { get; set; }
        string CurrencyAbbreviation { get; set; }
    }
}