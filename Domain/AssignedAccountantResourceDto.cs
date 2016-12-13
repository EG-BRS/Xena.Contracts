namespace Xena.Contracts.Domain
{
    public class AssignedAccountantResourceDto : FiscalDto, IHasIdDto
    {
        public long? Id { get; set; }
        public long AccountantResourceId { get; set; }
        public long AccountantClientId { get; set; }
        public string SecurityGroups { get; set; }
    }
}