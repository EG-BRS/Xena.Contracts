using System;
using System.ComponentModel;
using Xena.Common.ExtensionMethods;

namespace Xena.Contracts.Domain
{
    public class ReportLayoutDto : EntityDto
    {
        private string _xsl;
        public string Group { get; set; }
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
                    return Group.GetLocalizedReportXSLT();
                }
                catch (Exception)
                {
                    return null;
                }
            }
            set { _xsl = value; }
        }

        private string _groupTranslated = null;
        [ReadOnly(true)]
        public string GroupTranslated
        {
            get { return _groupTranslated ?? Group.GetLocalizedReportName(); }
            set { _groupTranslated = value; }
        }
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
    }
}