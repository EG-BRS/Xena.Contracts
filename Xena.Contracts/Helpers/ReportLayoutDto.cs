using System;
using System.Globalization;
using Xena.Contracts.Domain;
using Xena.Resources;

namespace Xena.Contracts.Helpers
{
    public class ReportLayoutDto : EntityDto
    {
        private string _xsl;
        public string Group { get; set; }
        public string GroupTranslated { get { return Group.GetLocalizedReportName(); } }
        public string Name { get; set; }
        public string DefaultEmailBody { get; set; }

        public string XSL
        {
            get
            {
                if (!string.IsNullOrEmpty(_xsl))
                    return _xsl;

                try
                {
                    var culture = CultureInfo.GetCultureInfo(Culture);
                    return Group.GetLocalizedReportXSLT(culture);
                }
                catch (Exception)
                {
                    return null;
                }
            }
            set { _xsl = value; }
        }

        public string Culture { get; set; }
        public string CultureDisplayName
        {
            get { return Culture.GetLocalizedCultureName(); }
        }
    }
}