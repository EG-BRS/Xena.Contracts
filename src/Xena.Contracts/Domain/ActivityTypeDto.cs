namespace Xena.Contracts.Domain
{
    public class ActivityTypeDto : EntityDto
    {
        public long? ArticleId { get; set; }
        public string ArticleNumber { get; set; }
        public string ArticleDescription { get; set; }
        public string Abbreviation { get; set; }
        public string Description { get; set; }
        public string Colour { get; set; }
        public bool IsBillable { get; set; }
        public int? DefaultDurationHours { get; set; }
        public int? DefaultDurationMinutes { get; set; }

        public string DefaultDurationFriendly
        { get; set; }
    }
}