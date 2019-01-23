using System.ComponentModel;

namespace Xena.Contracts.Domain
{
    public class OrderTaskDto : EntityDto
    {
        public OrderTaskDto()
        {
        }

        public OrderTaskDto(int orderNumber, int index)
        {
            OrderNumber = orderNumber;
            Index = index;
        }
        private TotalsDto _totals;
        public long OrderId { get; set; }
        public string OrderContextType { get; set; }
        public bool PrintDetails { get; set; }
        public string Details { get; set; }
        public string Description { get; set; }
        public long? OrderTaskStatusId { get; set; }

        //Convinience properties
        [ReadOnly(true)]
        public TotalsDto Totals
        {
            get { return _totals ?? (_totals = new TotalsDto()); }
            set { _totals = value; }
        }
        [ReadOnly(true)]
        public AddressDto Address { get; set; }
        [ReadOnly(true)]
        public AddressDto DeliveryAddress { get; set; }
        [ReadOnly(true)]
        public string OrderTaskStatusName { get; set; }
        [ReadOnly(true)]
        public string OrderTaskStatusColor { get; set; }
        [ReadOnly(true)]
        public int OrderNumber { get;set; }
        [ReadOnly(true)]
        public int Index { get; set; }
        [ReadOnly(true)]
        public long? SubscriptionId { get; set; }
        [ReadOnly(true)]
        public bool IsInvoiced { get; set; }
        [ReadOnly(true)]
        public bool IsDelivered { get; set; }
        [ReadOnly(true)]
        public bool IsConfirmed { get; set; }
        private bool? _isReadonly = null;
        [ReadOnly(true)]
        public bool IsReadonly
        {
            get { return _isReadonly ?? IsInvoiced; }
            set { _isReadonly = value; }
        }
        private string _abbreviation = null;
        [ReadOnly(true)]
        public string Abbreviation
        {
            get { return _abbreviation ?? $"{OrderNumber}-{Index}"; }
            set { _abbreviation = value; }
        }
        [ReadOnly(true)]
        public long? ProjectId { get; set; }
        [ReadOnly(true)]
        public int? ProjectClosedDateDays { get; set; }
        [ReadOnly(true)]
        public int AppointmentCount { get; set; }
        private bool? _isPlanned = null;
        [ReadOnly(true)]
        public bool IsPlanned
        {
            get { return _isPlanned ?? AppointmentCount > 0; }
            set { _isPlanned = value; }
        }
    }
}