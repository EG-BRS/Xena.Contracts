namespace Xena.Contracts.Domain
{
    public interface IHasXSLLayoutDto : IHasIdDto
    {
        string Group { get; }
        string XSL { get; }
        string Culture { get; }
    }
}
