using Xena.Contracts.Domain;


namespace Xena.Contracts.Helpers
{
    public class ReportLayoutMinDto : EntityDto
    {
        public string Group { get; set; }
        public string GroupTranslated { get; set; }
        public string Name { get; set; }
    }
}