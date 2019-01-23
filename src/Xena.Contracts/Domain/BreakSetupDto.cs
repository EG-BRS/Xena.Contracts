
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Xena.Contracts.Domain
{
    public class BreakSetupDto : EntityDto
    {
        public int? StartTimeHours { get; set; }
        public int? StartTimeMinutes { get; set; }
        public int DurationHours { get; set; }
        public int DurationMinutes { get; set; }
        [Required]
        public string Description { get; set; }

        public bool Monday { get; set; }
        public bool Tuesday { get; set; }
        public bool Wednesday { get; set; }
        public bool Thursday { get; set; }
        public bool Friday { get; set; }
        public bool Saturday { get; set; }
        public bool Sunday { get; set; }
        //Convinience properties
        private string _startTimeFriendly;
        [ReadOnly(true)]
        public string StartTimeFriendly
        {
            get
            {
                return _startTimeFriendly ?? $"{StartTimeHours?.ToString("D2") ?? 0.ToString("D2")}:{StartTimeMinutes?.ToString("D2") ?? 0.ToString("D2")}";
            }
            set { _startTimeFriendly = value; }
        }

        private string _durationFriendly;
        [ReadOnly(true)]
        public string DurationFriendly
        {
            get { return _durationFriendly ?? $"{DurationHours:D2}:{DurationMinutes:D2}"; }
            set { _durationFriendly = value; }
        }
    }
}