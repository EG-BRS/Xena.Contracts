using System.ComponentModel;
using Xena.Common.ExtensionMethods;

namespace Xena.Contracts.Domain
{
    public class XenaFiscalPartnerPostDto : XenaFiscalDto, IXenaPartnerPost
    {
        public int? VoucherNumber { get; set; }
        public int FiscalDateDays { get; set; }
        public string PostType { get; set; }

        private string _postTypeTranslated = null;
        [ReadOnly(true)]
        public string PostTypeTranslated
        {
            get { return _postTypeTranslated ?? PostType.GetLocalizedConstant(); }
            set { _postTypeTranslated = value; }
        }
        public decimal Amount { get; set; }
        public decimal CurrencyAmount { get; set; }
        public string CurrencyAbbreviation { get; set; }
        public long? OrderJournalEntryId { get; set; }
        public long? SettlementId { get; set; }

        private bool? _isSettled = null;
        [ReadOnly(true)]
        public bool IsSettled
        {
            get { return _isSettled ?? SettlementId.HasValue; }
            set { _isSettled = value; }
        }

        private string _fiscalDateDaysFriendly = null;
        [ReadOnly(true)]
        public string FiscalDateDaysFriendly
        {
            get { return _fiscalDateDaysFriendly ?? FiscalDateDays.FriendlyString(); }
            set { _fiscalDateDaysFriendly = value; }
        }
    }
}