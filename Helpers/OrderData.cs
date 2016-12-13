using System.Collections.Generic;
using Xena.Contracts.Domain;

namespace Xena.Contracts.Helpers
{
    public class OrderData
    {
        public IEnumerable<DepartmentDto> Departments { get; set; }
        public IEnumerable<PurposeDto> Purposes { get; set; }
        public IEnumerable<LocationDto> Locations { get; set; }
        public IEnumerable<BearerDto> Bearers { get; set; }
        public IEnumerable<object> DueTypes { get; set; }
    }
}