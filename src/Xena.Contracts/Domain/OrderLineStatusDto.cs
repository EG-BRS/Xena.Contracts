namespace Xena.Contracts.Domain
{
    public class OrderLineStatusDto: EntityDto
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public int Index { get; set; }
    }
}