using System.ComponentModel;
using Xena.Common.ExtensionMethods;
using Xena.Contracts.Domain;

namespace Xena.Contracts.Helpers
{
    public class GroupedActivityData : IHasIdDto
    {
        public long? Id { get; set; }
        public int StartDateDays { get; set; }
        public int? StartTimeMinutes { get; set; }
        public int? StartTimeHours { get; set; }
        public int? EndDateDays { get; set; }
        public int? EndTimeMinutes { get; set; }
        public int? EndTimeHours { get; set; }
        public int? DurationHours { get; set; }
        public int? DurationMinutes { get; set; }
        public long ResourceId { get; set; }
        public string ResourceName { get; set; }

        private string _startDateFriendly;
        [ReadOnly(true)]
        public string StartDateFriendly
        {
            get { return _startDateFriendly ?? $"{StartDateDays.ToDate().ToString("d")}"; }
            set { _startDateFriendly = value; }
        }

        private string _startFriendly;
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

        private string _startTimeFriendly;
        [ReadOnly(true)]
        public string StartTimeFriendly
        {
            get
            {
                return _startTimeFriendly ?? (StartTimeHours.HasValue
                           ? $"{StartTimeHours.Value:D2}:{StartTimeMinutes ?? 0:D2}"
                           : $"{StartDateDays.ToDate().ToString("d")}");
            }
            set { _startTimeFriendly = value; }
        }

        private string _endFriendly;
        [ReadOnly(true)]
        public string EndFriendly
        {
            get
            {
                return _endFriendly ?? (EndDateDays.HasValue
                           ? EndTimeHours.HasValue
                               ? $"{EndDateDays.Value.ToDate().ToString("d")} - {EndTimeHours.Value:D2}:{EndTimeMinutes ?? 0:D2}"
                               : $"{EndDateDays.Value.ToDate().ToString("d")}"
                           : string.Empty);
            }
            set { _endFriendly = value; }
        }

        private string _endTimeFriendly;
        [ReadOnly(true)]
        public string EndTimeFriendly
        {
            get
            {
                return _endTimeFriendly ?? (EndTimeHours.HasValue
                           ? $"{EndTimeHours.Value:D2}:{EndTimeMinutes ?? 0:D2}"
                           : string.Empty);
            }
            set { _endTimeFriendly = value; }
        }

        public bool AnyNotes { get; set; }
    }
}