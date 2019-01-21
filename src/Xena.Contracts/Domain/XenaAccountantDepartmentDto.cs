namespace Xena.Contracts.Domain
{
    public class XenaAccountantDepartmentDto : IHasIdDto
    {
        public long? Id { get; set; }
        public string Description { get; set; }
        public long AccountantId { get; set; }
    }
}