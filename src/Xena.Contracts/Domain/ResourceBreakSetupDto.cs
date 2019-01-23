using System.ComponentModel;

namespace Xena.Contracts.Domain
{
    public class ResourceBreakSetupDto : IHasIdDto
    {
        public int? StartTimeHours { get; set; }
        public int? StartTimeMinutes { get; set; }

        private string _startTimeFriendly = null;
        [ReadOnly(true)]
        public string StartTimeFriendly
        {
            get
            {
                return _startTimeFriendly ??
                       ($"{StartTimeHours?.ToString("D2") ?? 0.ToString("D2")}:{StartTimeMinutes?.ToString("D2") ?? 0.ToString("D2")}");
            }
            set { _startTimeFriendly = value; }
        }


        public int DurationHours { get; set; }
        public int DurationMinutes { get; set; }

        private string _durationFriendly = null;
        [ReadOnly(true)]
        public string DurationFriendly
        {
            get { return _durationFriendly ?? ($"{DurationHours:D2}:{DurationMinutes:D2}"); }
            set { _durationFriendly = value; }
        }
        public string Description { get; set; }
        public long BreakSetupId { get; set; }
        public long PartnerResourceContextId { get; set; }
        public bool Monday { get; set; }
        public bool Tuesday { get; set; }
        public bool Wednesday { get; set; }
        public bool Thursday { get; set; }
        public bool Friday { get; set; }
        public bool Saturday { get; set; }
        public bool Sunday { get; set; }
        public long? Id { get; set; }
    }
}