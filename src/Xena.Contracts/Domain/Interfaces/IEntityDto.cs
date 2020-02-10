namespace Xena.Contracts.Domain
{
    public interface IEntityDto : IHasIdDto
    {
        int Version { get; }
        bool IsDeactivated { get; }
    }
}
