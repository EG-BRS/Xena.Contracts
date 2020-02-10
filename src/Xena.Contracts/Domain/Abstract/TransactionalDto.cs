namespace Xena.Contracts.Domain
{
    public abstract class TransactionalDto : FiscalDto, IHasIdDto
    {
        public long? Id { get; set; }
        public int Version { get; set; }
    }
}