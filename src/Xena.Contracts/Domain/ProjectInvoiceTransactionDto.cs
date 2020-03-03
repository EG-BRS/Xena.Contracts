using System.ComponentModel;
using Xena.Common.ExtensionMethods;

namespace Xena.Contracts.Domain
{
    public class ProjectInvoiceTransactionDto : TransactionalDto
    {
        [ReadOnly(true)]
        public int FiscalDateDays { get; set; }
        [ReadOnly(true)]
        public long ProjectId { get; set; }

        //Convinience properties
        private string _fiscalDateDaysFriendly;
        [ReadOnly(true)]
        public string FiscalDateDaysFriendly
        {
            get { return _fiscalDateDaysFriendly ?? FiscalDateDays.FriendlyString(); }
            set { _fiscalDateDaysFriendly = value; }
        }
    }
}