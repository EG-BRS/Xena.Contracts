namespace Xena.Contracts.Search
{
    public class LocationSearchIndex
    {
        public long Id { get; set; }
        public long FiscalSetupId { get; set; }
        public string Abbreviation { get; set; }
        public string Description { get; set; }
        public string LocationType { get; set; }
        public string IndexedDimensions { get; set; }
        public string WarehouseAbbreviation { get; set; }
    }
}