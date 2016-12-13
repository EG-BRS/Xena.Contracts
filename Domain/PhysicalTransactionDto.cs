namespace Xena.Contracts.Domain
{
    public class PhysicalTransactionDto : TransactionalDto
    {
        public long EconomicTransactionId { get; set; }
    }
}