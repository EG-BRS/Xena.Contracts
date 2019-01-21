using System.ComponentModel;
using Xena.Common.ExtensionMethods;

namespace Xena.Contracts.Domain
{
    public class ActivityLogDto : FiscalDto, IHasIdDto
    {
        [ReadOnly(true)]
        public long? Id { get; set; }
        [ReadOnly(true)]
        public int DateDays { get; set; }

        private string _dateDaysFriendly;
        [ReadOnly(true)]
        public string DateDaysFriendly
        {
            get { return _dateDaysFriendly ?? DateDays.FriendlyString(); }
            set { _dateDaysFriendly = value; }
        }

        [ReadOnly(true)]
        public string Description { get; set; }
        [ReadOnly(true)]
        public long ResourceId { get; set; }
        [ReadOnly(true)]
        public long ChangerId { get; set; }
        [ReadOnly(true)]
        public string ResourceName { get; set; }
        [ReadOnly(true)]
        public string ChangerName { get; set; }
    }
}