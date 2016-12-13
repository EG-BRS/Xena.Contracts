using Xena.Contracts.Domain;
using Xena.Resources;

namespace Xena.Contracts.Helpers
{
    public class ReportLayoutMinDto : EntityDto
    {
        public string Group { get; set; }
        public string GroupTranslated { get { return Group.GetLocalizedReportName(); }
        }
        public string Name { get; set; }
    }
}