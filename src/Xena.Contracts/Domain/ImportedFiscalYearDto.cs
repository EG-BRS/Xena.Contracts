

namespace Xena.Contracts.Domain
{
    public class ImportedFiscalYearDto : ImportedDto
    {
        public int FromDateDays { get; set; }
        public string FromDateDaysFriendly
        { get; set; }
        public int ToDateDays { get; set; }
        public string ToDateDaysFriendly
        { get; set; }
        public string Description { get; set; }
        public bool IsClosed { get; set; }
    }
}