namespace Xena.Contracts.Domain
{
    public class XenaUserPartnerDto : XenaUserDto
    {
        public string Name { get; set; }
        public decimal Saldo { get; set; }
        public int DocumentCount { get; set; }
    }
}