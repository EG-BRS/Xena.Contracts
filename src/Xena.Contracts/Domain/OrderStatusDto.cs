namespace Xena.Contracts.Domain
{
    public class OrderStatusDto: EntityDto
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public int Index { get; set; }
        public string ContextType { get; set; }
        public long? LinkedTaskStatusId { get; set; }
    }
}