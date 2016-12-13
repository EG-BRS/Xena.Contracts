using Xena.Resources;

namespace Xena.Contracts.Domain
{
    public class ImportedFiscalYearDto : ImportedDto
    {
        public int FromDateDays { get; set; }
        public string FromDateDaysFriendly
        {
            get { return FromDateDays.FriendlyString(); }
        }
        public int ToDateDays { get; set; }
        public string ToDateDaysFriendly
        {
            get { return ToDateDays.FriendlyString(); }
        }
        public string Description { get; set; }
        public bool IsClosed { get; set; }
    }
}