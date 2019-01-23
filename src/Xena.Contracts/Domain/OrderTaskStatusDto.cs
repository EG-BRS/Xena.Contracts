namespace Xena.Contracts.Domain
{
    public class OrderTaskStatusDto: EntityDto
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public int Index { get; set; }
    }
}