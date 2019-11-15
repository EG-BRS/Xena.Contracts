using System.ComponentModel;
using Xena.Common.ExtensionMethods;

namespace Xena.Contracts.Domain
{
    public class LocationDto : EntityDto
    {
        public long? WarehouseId { get; set; }
        public string Dimension1 { get; set; }
        public string Dimension2 { get; set; }
        public string Dimension3 { get; set; }
        public string Dimension4 { get; set; }
        public string Dimension5 { get; set; }
        public string Abbreviation { get; set; }
        public string Description { get; set; }
        public string WarehouseAbbreviation { get; set; }
        public string WarehouseDescription { get; set; }
        public string WarehouseDimension1Description { get; set; }
        public string WarehouseDimension2Description { get; set; }
        public string WarehouseDimension3Description { get; set; }
        public string WarehouseDimension4Description { get; set; }
        public string WarehouseDimension5Description { get; set; }
        public string LocationType { get; set; }
        public int? LastCountedDays { get; set; }
        private string _locationTypeTranslated = null;

        [ReadOnly(true)]
        public string LocationTypeTranslated
        {
            get
            {
                return _locationTypeTranslated ?? (string.IsNullOrEmpty(LocationType)
                           ? string.Empty
                           : LocationType.GetLocalizedConstant());
            }
            set { _locationTypeTranslated = value; }
        }

        private string _lastCountedDaysFriendly = null;

        [ReadOnly(true)]
        public string LastCountedDaysFriendly
        {
            get
            {
                return _lastCountedDaysFriendly ??
                       (LastCountedDays.HasValue ? LastCountedDays.Value.FriendlyString() : string.Empty);
            }
            set { _lastCountedDaysFriendly = value; }
        }
    }
}