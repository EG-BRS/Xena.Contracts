namespace Xena.Contracts.Domain
{
    public class XenaUserTermsDto : XenaUserDto
    {
        public string Description { get; set; }
        public string Details { get; set; }
        public int? IsActiveFromDays { get; set; }
        public int? DeadLineDays { get; set; }
        public string CountryName { get; set; }
    }
}