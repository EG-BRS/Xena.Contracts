namespace Xena.Contracts.Domain
{
    public class OrderReceptionDraftDto : EntityDto
    {
        public OrderDto Order { get; set; }
        public long ResponsibleId { get; set; }
        public long? TemporaryLocationId { get; set; }
        public string TemporaryLocationAbbreviation { get; set; }
    }
}