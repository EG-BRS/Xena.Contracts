using System.ComponentModel;

namespace Xena.Contracts.Helpers
{
    public class OrderPayOnAccountTaskData
    {
        public long OrderTaskId { get; set; }
        public string OrderTaskDescription { get; set; }
        public int OrderNumber { get; set; }
        public int OrderTaskIndex { get; set; }
        public decimal PriceNettTotal { get; set; }
        private string _orderTaskAbbreviation = null;
        [ReadOnly(true)]
        public string OrderTaskAbbreviation
        {
            get { return _orderTaskAbbreviation ?? $"{OrderNumber}-{OrderTaskIndex}"; }
            set { _orderTaskAbbreviation = value; }
        }
        public decimal AlreadyPaidOnAccount { get; set; }
    }
}