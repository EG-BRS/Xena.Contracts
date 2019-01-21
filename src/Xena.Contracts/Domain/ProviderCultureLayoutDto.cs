using System.ComponentModel;
using Xena.Common.ExtensionMethods;

namespace Xena.Contracts.Domain
{
    public class ProviderCultureLayoutDto : EntityDto
    {
        public long ProviderReportLayoutId { get; set; }
        public string Name { get; set; }
        public string XSL { get; set; }
        public string Group { get; set; }
        public bool IsPublic { get; set; }
        public string Culture { get; set; }
        private string _cultureDisplayName = null;
        [ReadOnly(true)]
        public string CultureDisplayName
        {
            get
            {
                return _cultureDisplayName ??
                       (string.IsNullOrEmpty(Culture) ? string.Empty : Culture.GetLocalizedCultureName());
            }
            set { _cultureDisplayName = value; }
        }
        private string _groupTranslated = null;
        [ReadOnly(true)]
        public string GroupTranslated
        {
            get { return _groupTranslated ?? Group.GetLocalizedReportName(); }
            set { _groupTranslated = value; }
        }
    }
}