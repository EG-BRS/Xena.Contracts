using System;
using System.Globalization;
using Xena.Contracts.Domain;


namespace Xena.Contracts.Helpers
{
    public class ReportLayoutDto : EntityDto
    {
        private string _xsl;
        public string Group { get; set; }
        public string GroupTranslated { get; set; }
        public string Name { get; set; }
        public string DefaultEmailBody { get; set; }

        public string XSL { get; set; }

        public string Culture { get; set; }
        public string CultureDisplayName { get; set; }
    }
}