namespace Xena.Contracts.Domain
{
    public class XenaFiscalTermsDto : IHasIdDto
    {
        public long? Id { get; set; }
        public string Description { get; set; }
        public string TermsType { get; set; }
        public string Details { get; set; }
        public int? IsActiveFromDateDays { get; set; }
        public int? DeadLineDateDays { get; set; }
        public string CountryName { get; set; }
        public long ProviderId { get; set; }
    }
}