namespace Xena.Contracts.Domain
{
    public class PartnerLocationDto : EntityDto
    {
        public long PartnerId { get; set; }
        public string Name { get; set; }
        public double? Longitude { get; set; }
        public double? Latitude { get; set; }
    }
}