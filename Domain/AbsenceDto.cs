using Xena.Resources;

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

        public string StartFriendly => StartTimeHours.HasValue
            ? $"{StartDateDays.ToDate().ToShortDateString()} - {StartTimeHours.Value:D2}:{(StartTimeMinutes ?? 0):D2}"
            : $"{StartDateDays.ToDate().ToShortDateString()}";

        public int EndDateDays { get; set; }
        public int? EndTimeMinutes { get; set; }
        public int? EndTimeHours { get; set; }

        public string EndFriendly => EndTimeHours.HasValue
            ? $"{EndDateDays.ToDate().ToShortDateString()} - {EndTimeHours.Value:D2}:{(EndTimeMinutes ?? 0):D2}"
            : $"{EndDateDays.ToDate().ToShortDateString()}";

        public string StartEndFriendlyDescription => StartDateDays != EndDateDays
            ? (StartTimeHours.HasValue && EndTimeHours.HasValue
                ? $"{StartDateDays.ToDate().ToShortDateString()}/{StartTimeHours.Value:D2}:{(StartTimeMinutes ?? 0):D2} - {EndDateDays.ToDate().ToShortDateString()}/{EndTimeHours.Value:D2}:{(EndTimeMinutes ?? 0):D2} "
                : $"{StartDateDays.ToDate().ToShortDateString()} - {EndDateDays.ToDate().ToShortDateString()}")
            : (StartTimeHours.HasValue && EndTimeHours.HasValue
                ? $"{StartTimeHours.Value:D2}:{(StartTimeMinutes ?? 0):D2} - {EndTimeHours.Value:D2}:{(EndTimeMinutes ?? 0):D2}"
                : $"{StartDateDays.ToDate().ToShortDateString()} - {EndDateDays.ToDate().ToShortDateString()}");
    }
}