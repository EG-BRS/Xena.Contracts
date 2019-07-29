using System.ComponentModel;
using Xena.Common.ExtensionMethods;

namespace Xena.Contracts.Domain
{
    public class AveragePriceChangeDto : TransactionalDto
    {
        public long ArticleId { get; set; }
        public int FiscalDateDays { get; set; }

        public decimal? OldAveragePrice { get; set; }
        public decimal? NewAveragePrice { get; set; }
        public string AveragePriceChangeType { get; set; }
        private string _fiscalDateDaysFriendly;
        [ReadOnly(true)]
        public string FiscalDateDaysFriendly
        {
            get => _fiscalDateDaysFriendly ?? FiscalDateDays.FriendlyString();
            set => _fiscalDateDaysFriendly = value;
        }
        private string _averagePriceChangeTypeTranslated;
        [ReadOnly(true)]
        public string AveragePriceChangeTypeTranslated
        {
            get => _averagePriceChangeTypeTranslated ?? AveragePriceChangeType.GetLocalizedConstant();
            set => _averagePriceChangeTypeTranslated = value;
        }
        private int? _registrationDateDays;
        [ReadOnly(true)]
        public int RegistrationDateDays
        {
            get { return _registrationDateDays ?? CreatedAt.DaysSince1970_01_01(); }
            set { _registrationDateDays = value; }
        }
    }
}