namespace Xena.Contracts.Domain
{
    public class WarehouseDto : EntityDto
    {
        public string Description { get; set; }
        public AddressDto Address { get; set; }
        public string Dimension1Description { get; set; }
        public string Dimension2Description { get; set; }
        public string Dimension3Description { get; set; }
        public string Dimension4Description { get; set; }
        public string Dimension5Description { get; set; }
        public string Dimension1Abbreviation { get; set; }
        public string Dimension2Abbreviation { get; set; }
        public string Dimension3Abbreviation { get; set; }
        public string Dimension4Abbreviation { get; set; }
        public string Dimension5Abbreviation { get; set; }
    }
}
