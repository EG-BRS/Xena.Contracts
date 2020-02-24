using System.ComponentModel;
using System.Globalization;
using Xena.Common.ExtensionMethods;

namespace Xena.Contracts.Domain
{
    public class ProviderReportLayoutDto: EntityDto
    {
        public string Name { get; set; }
        public string XSL { get; set; }
        public string Group { get;  set; }
        public bool IsPublic { get; set; }
        private string _culture = null;
        [ReadOnly(true)]
        public string Culture
        {
            get { return _culture ?? CultureInfo.InvariantCulture.Name; }
            set { _culture = value; }
        }
        private string _cultureDisplayName = null;
        [ReadOnly(true)]
        public string CultureDisplayName
        {
            get { return _cultureDisplayName ?? Culture.GetLocalizedCultureName(); }
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