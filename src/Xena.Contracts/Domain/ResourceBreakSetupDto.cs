namespace Xena.Contracts.Domain
{
    public class ResourceBreakSetupDto : IHasIdDto
    {
        public int? StartTimeHours { get; set; }
        public int? StartTimeMinutes { get; set; }
        public string StartTimeFriendly
        { get; set; }


        public int DurationHours { get; set; }
        public int DurationMinutes { get; set; }

        public string DurationFriendly
        { get; set; }
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