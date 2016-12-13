using System;
using Xena.Resources;

namespace Xena.Contracts.Domain
{
    public class ReportEmailSetupDto : EntityDto
    {
        public string Culture { get; set; }
        public string CultureDisplayName
        {
            get { return !string.IsNullOrEmpty(Culture) ? Culture.GetLocalizedCultureName(): string.Empty; }
        }

        public string Body { get; set; }
        public string Subject { get; set; }
        public string ReportModule { get; set; }

        public string ReportModuleFriendly
        {
            get { return !string.IsNullOrEmpty(ReportModule) ? ReportModule.GetLocalizedReportName() : string.Empty; }
        }
    }
}