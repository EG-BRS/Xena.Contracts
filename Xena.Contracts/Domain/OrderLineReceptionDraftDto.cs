namespace Xena.Contracts.Domain
{
    public class OrderLineReceptionDraftDto : EntityDto
    {
        public long OrderReceptionDraftId { get; set; }
        public OrderLineDto OrderLine { get; set; }
        public decimal ReceivedQuantity { get; set; }
    }
}