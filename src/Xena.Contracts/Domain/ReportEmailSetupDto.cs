using System;


namespace Xena.Contracts.Domain
{
    public class ReportEmailSetupDto : EntityDto
    {
        public string Culture { get; set; }
        public string CultureDisplayName
        { get; set; }

        public string Body { get; set; }
        public string Subject { get; set; }
        public string ReportModule { get; set; }

        public string ReportModuleFriendly
        { get; set; }
    }
}