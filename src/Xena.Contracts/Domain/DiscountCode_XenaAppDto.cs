using System.ComponentModel;
using Xena.Common.Constants;
using Xena.Common.ExtensionMethods;

namespace Xena.Contracts.Domain
{
    public class DiscountCode_XenaAppDto :XenaFiscalDto
    {
        private string _appName;
        public long DiscountCodeId { get; set; }

        [ReadOnly(true)]
        public string AppName
        {
            get { return AppId.HasValue ? _appName : DiscountCodeName.XenaPremium.GetLocalizedConstant();}
            set { _appName = value; }
        }

        public long? AppId { get; set; }

        public int ExpirationDateDays { get; protected set; }
        private string _expirationDateDaysFriendly;
        [ReadOnly(true)]
        public string ExpirationDateDaysFriendly
        {
            get { return _expirationDateDaysFriendly    ?? ExpirationDateDays.FriendlyString(); }
            set { _expirationDateDaysFriendly = value; }
        }
    }
}