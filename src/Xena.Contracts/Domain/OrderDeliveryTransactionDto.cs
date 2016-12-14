namespace Xena.Contracts.Domain
{
    public class OrderDeliveryTransactionDto : TransactionalDto
    {
        public long PhysicalTransactionId { get; set; }
        public OrderDeliveryDto OrderDelivery { get; set; }
    }
}