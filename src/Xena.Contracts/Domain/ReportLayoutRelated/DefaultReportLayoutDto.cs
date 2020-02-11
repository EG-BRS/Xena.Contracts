using System;

namespace Xena.Contracts.Domain
{
    public class DefaultReportLayoutDto : IHasXSLLayoutDto
    {
        public long? Id { get; set; }
        public string Group { get; set; }
        public string XSL { get; set; }
        public string Culture { get; set; }
        public long FiscalSetupId { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}