using System.ComponentModel;
using Xena.Common.ExtensionMethods;

namespace Xena.Contracts.Domain
{
    public class ImportedFiscalYearDto : ImportedDto
    {
        public int FromDateDays { get; set; }
        public int ToDateDays { get; set; }
        public string Description { get; set; }
        public bool IsClosed { get; set; }

        //Convinience properties
        private string _fromDateDaysFriendly;
        [ReadOnly(true)]
        public string FromDateDaysFriendly
        {
            get { return _fromDateDaysFriendly ?? FromDateDays.FriendlyString(); }
            set { _fromDateDaysFriendly = value; }
        }

        private string _toDateDaysFriendly;
        public string ToDateDaysFriendly
        {
            get { return _toDateDaysFriendly ?? ToDateDays.FriendlyString(); }
            set { _toDateDaysFriendly = value; }
        }
    }
}