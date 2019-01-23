using System.ComponentModel;
using Xena.Common.ExtensionMethods;

namespace Xena.Contracts.Domain
{
    public class FiscalSetupProviderContextDto : EntityDto
    {
        public string DefaultTheme { get; set; }
        private string _defaultThemeFriendly = null;
        [ReadOnly(true)]
        public string DefaultThemeFriendly
        {
            get { return _defaultThemeFriendly ?? DefaultTheme.GetLocalizedTheme(); }
            set { _defaultThemeFriendly = value; }
        }
        public string CssClass { get; set; }
        public string SenderEmail { get; set; }
    }
}