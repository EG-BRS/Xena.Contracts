namespace Xena.Contracts.Domain
{
    public class CompositeOrderTaskDto
    {
        public OrderDto Order { get; set; }
        public OrderTaskDto OrderTask { get; set; }
    }
}