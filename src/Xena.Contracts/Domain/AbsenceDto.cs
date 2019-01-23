using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Xena.Common.ExtensionMethods;

namespace Xena.Contracts.Domain
{
    /// <summary>
    /// Represents absence for a PartnerResourceContext (employee) - the employee is not available for
    /// work during this timespan
    /// </summary>
    public class AbsenceDto : EntityDto
    {
        public string Description { get; set; }
        public long ResourceId { get; set; }
        [Required]
        public int StartDateDays { get; set; }
        public int? StartTimeMinutes { get; set; }
        public int? StartTimeHours { get; set; }
        [Required]
        public int EndDateDays { get; set; }
        public int? EndTimeMinutes { get; set; }
        public int? EndTimeHours { get; set; }

        [ReadOnly(true)]
        public string ResourceName { get; set; }

        private string _startFriendly = null;
        [ReadOnly(true)]
        public string StartFriendly
        {
            get
            {
                return _startFriendly ?? (StartTimeHours.HasValue
                           ? $"{StartDateDays.ToDate().ToString("d")} - {StartTimeHours.Value:D2}:{StartTimeMinutes ?? 0:D2}"
                           : $"{StartDateDays.ToDate().ToString("d")}");
            }
            set { _startFriendly = value; }
        }
         
        private string _endFriendly = null;
        [ReadOnly(true)]
        public string EndFriendly
        {
            get
            {
                return _endFriendly ?? (EndTimeHours.HasValue
                           ? $"{EndDateDays.ToDate().ToString("d")} - {EndTimeHours.Value:D2}:{EndTimeMinutes ?? 0:D2}"
                           : $"{EndDateDays.ToDate().ToString("d")}");
            }
            set { _endFriendly = value; }
        }

        private string _startEndFriendlyDescription = null;
        [ReadOnly(true)]
        public string StartEndFriendlyDescription
        {
            get
            {
                return _startEndFriendlyDescription ?? (StartDateDays != EndDateDays
                           ? StartTimeHours.HasValue && EndTimeHours.HasValue
                               ? $"{StartDateDays.ToDate().ToString("d")}/{StartTimeHours.Value:D2}:{StartTimeMinutes ?? 0:D2} - {EndDateDays.ToDate().ToString("d")}/{EndTimeHours.Value:D2}:{EndTimeMinutes ?? 0:D2} "
                               : $"{StartDateDays.ToDate().ToString("d")} - {EndDateDays.ToDate().ToString("d")}"
                           : StartTimeHours.HasValue && EndTimeHours.HasValue
                               ? $"{StartTimeHours.Value:D2}:{StartTimeMinutes ?? 0:D2} - {EndTimeHours.Value:D2}:{EndTimeMinutes ?? 0:D2}"
                               : $"{StartDateDays.ToDate().ToString("d")} - {EndDateDays.ToDate().ToString("d")}");
            }
            set { _startEndFriendlyDescription = value; }
        }
    }
}