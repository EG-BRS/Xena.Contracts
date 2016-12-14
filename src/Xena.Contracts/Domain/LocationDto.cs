

namespace Xena.Contracts.Domain
{
    public class LocationDto :  EntityDto
    {
        public long? WarehouseId { get; set; }
        public string Dimension1 { get; set; }
        public string Dimension2 { get; set; }
        public string Dimension3 { get; set; }
        public string Dimension4{ get; set; }
        public string Dimension5{ get; set; }
        public string Abbreviation { get; set; }
        public string Description { get; set; }
        public string WarehouseDescription { get; set; }
        public string WarehouseDimension1Description { get; set; }
        public string WarehouseDimension2Description { get; set; }
        public string WarehouseDimension3Description { get; set; }
        public string WarehouseDimension4Description { get; set; }
        public string WarehouseDimension5Description { get; set; }
        public string LocationType { get; set; }
        public int? LastCountedDays { get; set; }
        public string LocationTypeTranslated { get; set; }
        public string LastCountedDaysFriendly { get; set; }
    }
}