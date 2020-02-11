namespace Xena.Contracts.Domain
{
    public class DefaultReportLayoutDto : FiscalDto, IHasXSLLayoutDto
    {
        public long? Id { get; set; }
        public string Group { get; set; }
        public string XSL { get; set; }
        public string Culture { get; set; }
    }
}