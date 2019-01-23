using System.Collections.Generic;
using Xena.Contracts.Domain;

namespace Xena.Contracts.Helpers
{
    public class SchedulingResourceData
    {
        public long ResourceId { get; set; }
        public string ResourceName { get; set; }
        public IList<ActivityDto> Activities { get; set; }
        public IList<AppointmentDto> Appointments { get; set; }
        public IList<AbsenceDto> Absences { get; set; }
    }
}