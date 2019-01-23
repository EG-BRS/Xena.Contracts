using System.ComponentModel;
using Xena.Common.ExtensionMethods;

namespace Xena.Contracts.Domain
{
    public class ResourceAuthorizationContextDto : TransactionalDto
    {
        public int? StartDateDays { get; set; }
        public decimal AmountMax { get; set; }
        public int? EndDateDays { get; set; }
        public long ResourceId { get; set; }
        public string ResourceName { get; set; }

        //Convinience properties
        private string _startDateDaysFriendly = null;
        [ReadOnly(true)]
        public string StartDateDaysFriendly
        {
            get { return _startDateDaysFriendly ?? StartDateDays.FriendlyString(); }
            set { _startDateDaysFriendly = value; }
        }

        private string _endDateDaysFriendly = null;
        [ReadOnly(true)]
        public string EndDateDaysFriendly
        {
            get { return _endDateDaysFriendly ?? EndDateDays.FriendlyString(); }
            set { _endDateDaysFriendly = value; }
        }
    }
}