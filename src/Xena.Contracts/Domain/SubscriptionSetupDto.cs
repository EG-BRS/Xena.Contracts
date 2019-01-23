using System.ComponentModel;
using Xena.Common.ExtensionMethods;

namespace Xena.Contracts.Domain
{
    public class SubscriptionSetupDto : EntityDto
    {
        public string Culture { get; set; }
        private string _cultureDisplayName = null;
        [ReadOnly(true)]
        public string CultureDisplayName
        {
            get { return _cultureDisplayName ?? Culture.GetLocalizedCultureName(); }
            set { _cultureDisplayName = value; }
        }

        public string Body { get; set; }
        public string Subject { get; set; }
        public string Email { get; set; }
    }
}