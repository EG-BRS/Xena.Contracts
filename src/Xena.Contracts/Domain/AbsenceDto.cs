

namespace Xena.Contracts.Domain
{
    public class AbsenceDto : EntityDto
    {
        public string Description { get; set; }
        public long? ResourceId { get; set; }
        public string ResourceName { get; set; }
        public long AbsenceTypeId { get; set; }
        public string AbsenceTypeDescription { get; set; }
        public string AbsenceTypeColor { get; set; }
        public int StartDateDays { get; set; }
        public int? StartTimeMinutes { get; set; }
        public int? StartTimeHours { get; set; }

        public string StartFriendly { get; set; }

        public int EndDateDays { get; set; }
        public int? EndTimeMinutes { get; set; }
        public int? EndTimeHours { get; set; }

        public string EndFriendly { get; set; }

        public string StartEndFriendlyDescription { get; set; }
    }
}