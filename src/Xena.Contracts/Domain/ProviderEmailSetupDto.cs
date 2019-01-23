using System.ComponentModel;
using System.Globalization;
using Xena.Common.ExtensionMethods;

namespace Xena.Contracts.Domain
{
    public class ProviderEmailSetupDto : EntityDto
    {
        public string Culture { get; set; }
        public string EmailPartConstant { get; set; }
        private string _emailPartConstantTranslated = null;
        [ReadOnly(true)]
        public string EmailPartConstantTranslated
        {
            get
            {
                return _emailPartConstantTranslated ?? (string.IsNullOrEmpty(EmailPartConstant)
                           ? string.Empty
                           : EmailPartConstant.GetEmailPartDescription());
            }
            set { _emailPartConstantTranslated = value; }
        }
        public string Template { get; set; }
        public long? ProviderContextId { get; set; }
        //Convinience properties
        private string _cultureDisplayName = null;
        [ReadOnly(true)]
        public string CultureDisplayName
        {
            get
            {
                return _cultureDisplayName ??
                       (!string.IsNullOrEmpty(Culture) ? Culture.GetLocalizedCultureName() : string.Empty);
            }
            set { _cultureDisplayName = value; }
        }
        public string DefaultTemplate { get; set; }
    }
}