using System;
using Xena.Resources;

namespace Xena.Contracts.Domain
{
    public class AppointmentDto : EntityDto
    {
        public int StartDateDays { get; set; }
        public int? StartTimeMinutes { get; set; }
        public int? StartTimeHours { get; set; }
        public int EndDateDays { get; set; }
        public int? EndTimeMinutes { get; set; }
        public int? EndTimeHours { get; set; }
        public long? ActivityTypeId { get; set; }
        public string ActivityTypeDescription { get; set; }
        public string Description { get; set; }
        public long ResourceId { get; set; }
        public string ResourceName { get; set; }
        public int? OrderNumber { get; set; }
        public long? OrderId { get; set; }
        public string StartFriendly
        {
            get
            {
                return StartTimeHours.HasValue
                    ? string.Format("{0} - {1}:{2}", StartDateDays.ToDate().ToShortDateString(), StartTimeHours.Value.ToString("D2"), (StartTimeMinutes ?? 0).ToString("D2"))
                    : string.Format("{0}", StartDateDays.ToDate().ToShortDateString());
            }
        } 
        public string StartNoDateFriendly
        {
            get
            {
                return StartTimeHours.HasValue
                    ? string.Format("{0}:{1}", StartTimeHours.Value.ToString("D2"), (StartTimeMinutes ?? 0).ToString("D2"))
                    : string.Format("{0}", StartDateDays.ToDate().ToShortDateString());
            }
        }

        public string EndFriendly
        {
            get
            {
                return EndTimeHours.HasValue
                    ? string.Format("{0} - {1}:{2}", EndDateDays.ToDate().ToShortDateString(), EndTimeHours.Value.ToString("D2"), (EndTimeMinutes ?? 0).ToString("D2"))
                    : string.Format("{0}", EndDateDays.ToDate().ToShortDateString());
            }
        }

        public string StartEndFriendlyDescription
        {
            get
            {
                if (StartDateDays != EndDateDays)
                {
                    if (StartTimeHours.HasValue && EndTimeHours.HasValue)
                        return string.Format("{0}/{1}:{2} - {3}/{4}:{5} ",
                            StartDateDays.ToDate().ToShortDateString(), StartTimeHours.Value.ToString("D2"),
                            (StartTimeMinutes ?? 0).ToString("D2"), EndDateDays.ToDate().ToShortDateString(),
                            EndTimeHours.Value.ToString("D2"), (EndTimeMinutes ?? 0).ToString("D2"));
                    return string.Format("{0} - {1}", StartDateDays.ToDate().ToShortDateString(),
                        EndDateDays.ToDate().ToShortDateString());
                }
                if (StartTimeHours.HasValue && EndTimeHours.HasValue)
                    return string.Format("{0}:{1} - {2}:{3}", StartTimeHours.Value.ToString("D2"), (StartTimeMinutes ?? 0).ToString("D2"), EndTimeHours.Value.ToString("D2"), (EndTimeMinutes ?? 0).ToString("D2"));
                return string.Format("{0} - {1}", StartDateDays.ToDate().ToShortDateString(), EndDateDays.ToDate().ToShortDateString());
            }
        }

        public int DurationHours { get; set; }
        public int DurationMinutes { get; set; }

        public string DurationFriendly
        {
            get
            {
                return string.Format("({0}:{1})", DurationHours.ToString("D2"), DurationMinutes.ToString("D2"));
            }
        }

        public string OrderStatusColor { get; set; }
    }
}